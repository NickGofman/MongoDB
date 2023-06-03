using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        IMongoCollection<Event> eventsCollection;
        IMongoCollection<EventMusician> eventMusicianCollection;

        public UpdateOrDeleteEvent()
        {
            InitializeComponent();
        }
        public UpdateOrDeleteEvent(IMongoCollection<Event> events, IMongoCollection<EventMusician> eventMusicianCollection)
        {
            InitializeComponent();
            this.eventsCollection = events;
            this.eventMusicianCollection = eventMusicianCollection;
        }
     
        private void btn_DeleteEvent_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker_EventDateUpdate.Value;
            string eventId = textBox_ID.Text;

            // Show a message box to confirm the deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete the event on: " + dateTime + "?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //filter by eventId
                    var filter = Builders<Event>.Filter.Eq(p => p.EventID, eventId);

                    // Delete the event from the 'events' collection
                    DeleteResult deleteResult = eventsCollection.DeleteOne(filter);

                    if (deleteResult.DeletedCount == 1)
                    {
                        // Delete the corresponding records from the EventMusicianCollection
                        var eventMusicianFilter = Builders<EventMusician>.Filter.Eq(p => p.EventID, eventId);
                        eventMusicianCollection.DeleteMany(eventMusicianFilter);

                        MessageBox.Show("Event on: " + dateTime + "\n deleted successfully",
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
            string eventId = textBox_ID.Text;
            string eventName = textBox_EventName.Text;
            string eventMusicialtype = textBox_EventMusicialtype.Text;
            DateTime eventDateTimeLocal = dateTimePicker_EventDateUpdate.Value; // Get the selected date in local time
            DateTime time = TimePicker_EventTimeUpdate.Value.ToLocalTime(); // Get the selected time in local time
            eventDateTimeLocal = eventDateTimeLocal.Date + time.TimeOfDay; // Combine the date and time
            DateTime eventDateTimeUtc = eventDateTimeLocal.ToUniversalTime(); // Convert to UTC

            // Show a message box to confirm the update
            DialogResult result = MessageBox.Show("Are you sure you want to update the event on: " + eventDateTimeLocal + "?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            DateTime startDate = eventDateTimeLocal; // Extract the date portion
            DateTime endDate = startDate.AddDays(1).AddSeconds(-1); // Set the end time of the day

            FilterDefinition<Event> filterDate = Builders<Event>.Filter.Gte(p => p.Date, startDate) &
                                              Builders<Event>.Filter.Lt(p => p.Date, endDate);
            bool eventExists = eventsCollection.Find(filterDate).Any();
            if (eventExists)
            {
                MessageBox.Show("Event Already Exists on this date", "Event Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    //filter by eventId
                    var filter = Builders<Event>.Filter.Eq(p => p.EventID, eventId);
                    ////build Update
                    var update = Builders<Event>.Update
                        .Set(p => p.EventName, eventName)
                        .Set(p => p.Date, eventDateTimeUtc) 
                        .Set(p => p.MusicalStyle, eventMusicialtype);
                    //update event table
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
