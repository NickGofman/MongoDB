﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Models;
namespace MongoDB
{

    public partial class UpdateOrDeleteEvent : Form
    {
        IMongoCollection<Event> eventsCollection;//eventsCollection contains all events
        IMongoCollection<EventMusician> eventMusicianCollection;//eventsCollection contains all events and there musician list

        public UpdateOrDeleteEvent()
        {
            InitializeComponent();

        }
        public UpdateOrDeleteEvent(IMongoCollection<Event> events, IMongoCollection<EventMusician> eventMusicianCollection)
        {
            InitializeComponent();
            //set collections
            this.eventsCollection = events;
            this.eventMusicianCollection = eventMusicianCollection;
        }

        private void btn_DeleteEvent_Click(object sender, EventArgs e)
        {
            //get data from screen
            DateTime dateTime = dateTimePicker_EventDateUpdate.Value;
            string eventId = textBox_ID.Text;

            // Show a message box to confirm the deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete the event on:\n" + dateTime.ToString("dd/MM/yyyy") + "?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //filter by eventId
                    var filter = Builders<Event>.Filter.Eq(p => p.EventID, eventId);

                    // Delete the event from the events collection
                    DeleteResult deleteResult = eventsCollection.DeleteOne(filter);

                    if (deleteResult.DeletedCount == 1)
                    {
                        // Delete the corresponding records from the EventMusicianCollection
                        var eventMusicianFilter = Builders<EventMusician>.Filter.Eq(p => p.EventID, eventId);
                        eventMusicianCollection.DeleteMany(eventMusicianFilter);

                        MessageBox.Show("Event on: " + dateTime.ToString("dd/MM/yyyy") + "\n deleted successfully",
                                        "Event Deleted",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Event delete failed\n" + eventId,
                                        "Event Delete Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Event delete failed\n" + eventId +
                                    "we got the following exception:\n " + ex.Message,
                                    "Event Delete Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btn_UpdateEvent_Click(object sender, EventArgs e)
        {
            // Get data from the screen
            string eventId = textBox_ID.Text;
            string eventName = textBox_EventName.Text;
            string eventMusicalType = textBox_EventMusicialtype.Text;

            // Check if input is valid
            if (eventName == "" || eventMusicalType == "")
            {
                MessageBox.Show("Inputs shouldn't be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected date and time in local time
            DateTime eventDateTimeLocal = dateTimePicker_EventDateUpdate.Value;
            DateTime eventTimeLocal = TimePicker_EventTimeUpdate.Value;

            // Combine the date and time to create the updated event date and time in local time zone
            DateTimeOffset localDateTimeOffset = new DateTimeOffset(eventDateTimeLocal.Year, eventDateTimeLocal.Month, eventDateTimeLocal.Day,
                eventTimeLocal.Hour, eventTimeLocal.Minute, eventTimeLocal.Second, TimeSpan.Zero);

            // Get the local time zone for Israel
            TimeZoneInfo israelTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time");

            // Convert the local date and time to UTC using the Israel time zone
            DateTimeOffset updatedDateTimeOffset = TimeZoneInfo.ConvertTime(localDateTimeOffset, israelTimeZone);

            // Extract the UTC date and time
            DateTime updatedDateTimeUtc = updatedDateTimeOffset.UtcDateTime;

            // Show a message box to confirm the update
            DialogResult result = MessageBox.Show("Are you sure you want to update the event to:\n"+"Event name: "+eventName +", Musical style: " +
                eventMusicalType+", Event time: "+ updatedDateTimeUtc + "?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Filter to get the event
                FilterDefinition<Event> filter = Builders<Event>.Filter.Eq(p => p.EventID, eventId);

                // Get the event that we want to update
                Event existingEvent = eventsCollection.Find(filter).FirstOrDefault();

                if (existingEvent != null)
                {
                    // Check if the updated date conflicts with any other existing events
                    FilterDefinition<Event> conflictFilter = Builders<Event>.Filter.Ne(p => p.EventID, eventId)
                                                             & Builders<Event>.Filter.Gte(p => p.Date, updatedDateTimeUtc.Date)
                                                             & Builders<Event>.Filter.Lt(p => p.Date, updatedDateTimeUtc.Date.AddDays(1));

                    // Check if there is an event that already has the same date
                    bool eventExists = eventsCollection.Find(conflictFilter).Any();
                    if (eventExists)
                    {
                        MessageBox.Show("Another event already exists on the updated date.", "Event Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    // Build the update
                    var update = Builders<Event>.Update
                        .Set(p => p.EventName, eventName)
                        .Set(p => p.Date, updatedDateTimeUtc)
                        .Set(p => p.MusicalStyle, eventMusicalType);

                    // Update the event in the collection
                    UpdateResult updateResult = eventsCollection.UpdateOne(filter, update);

                    if (updateResult.ModifiedCount == 1)
                    {
                        MessageBox.Show("Event updated successfully",
                                        "Event Updated",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Event update failed\n" + eventId + "\n" + eventDateTimeLocal,
                                        "Event Update Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Event update failed\n" + eventId + "\n" + eventDateTimeLocal +
                                    "\nwe got the following exception:\n " + ex.Message,
                                    "Event Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }




    }
}
