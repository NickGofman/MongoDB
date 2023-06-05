using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Models;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace MongoDB
{
    public partial class UpdateOrDeleteMusician : Form
    {
        IMongoCollection<Musician> musiciansCollection;
        IMongoCollection<EventMusician> eventMusicianCollection;
        public UpdateOrDeleteMusician()
        {
            InitializeComponent();
        }
        public UpdateOrDeleteMusician(IMongoCollection<Musician> musiciansCollection, IMongoCollection<EventMusician> eventMusicianCollection)
        {
            InitializeComponent();
            this.musiciansCollection = musiciansCollection;
            this.eventMusicianCollection = eventMusicianCollection;
        }


        private void btn_DeleteMusician_Click(object sender, EventArgs e)
        {
            string musicianId = textBox_MusicianID.Text;
            string musicianName = textBox_MusicianNameUpdate.Text;


            // Show a message box to confirm the deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete the musician" + musicianName + "?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            var eventMusicianFilter = Builders<EventMusician>.Filter.Empty;
            if (result == DialogResult.Yes)
            {
                try
                {
                    //filter by MusicianID
                    var musicianFilter = Builders<Musician>.Filter.Eq(p => p.MusicianID, musicianId);

                    // Delete the musician from the musicians table
                    DeleteResult musicianDeleteResult = musiciansCollection.DeleteOne(musicianFilter);

                    // Delete the musician from the eventMusicianCollection table
                    List<EventMusician> musicianAssignToEvents;
                    musicianAssignToEvents = eventMusicianCollection.Aggregate().ToList();
                    foreach (EventMusician eventMusician in musicianAssignToEvents)
                    {
                        var musicianList = eventMusician.MusicianList;
                        if (musicianList.Contains(musicianId))
                        {
                            musicianList.Remove(musicianId);
                            eventMusicianFilter = Builders<EventMusician>.Filter.Eq(p => p.EventMusicianID, eventMusician.EventMusicianID);
                            var update = Builders<EventMusician>.Update.Set(p => p.MusicianList, musicianList);
                            eventMusicianCollection.UpdateOne(eventMusicianFilter, update);
                        }
                    }

         

                    if (musicianDeleteResult.DeletedCount == 1 )
                    {
                        MessageBox.Show("Musician " + musicianName + " with ID: " + musicianId + " deleted successfully",
                                        "Musician Deleted",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                     

                    }
                    else
                    {
                        MessageBox.Show("Musician " + musicianName + " delete failed\n" ,
                                        "Musician Delete Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Musician delete failed\n" + musicianName +
                                    "we got the following exception:\n" + ex.Message,
                                    "Musician Delete Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btn_UpdateMusician_Click(object sender, EventArgs e)
        {
            string musicianId = textBox_MusicianID.Text;
            string musicianName = textBox_MusicianNameUpdate.Text;
            string musicianAge = textBox_MusicianAgeUpdate.Text;

            string musicianInstrument = textBox_MusicianInstrumentUpdate.Text;

            // Show a message box to confirm the update
            DialogResult result = MessageBox.Show("Are you sure you want to update the musician " + musicianName  + "?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (musicianInstrument == "" || musicianName == "")
            {
                MessageBox.Show("Inputes shouldn't be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; 
            }
            if (!Regex.IsMatch(musicianAge, @"^\d+$"))
            {
                MessageBox.Show("Musician Age must be a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // age must be a number
            }

            if (result == DialogResult.Yes)
            {
                try
                {
                    //build filter by musicianId
                    var filter = Builders<Musician>.Filter.Eq(p => p.MusicianID, musicianId);
                    ////build Update
                    var update = Builders<Musician>.Update
                        .Set(p => p.Name, musicianName)
                        .Set(p => p.Instrument, musicianInstrument)
                        .Set(p => p.Age, musicianAge);
                    //Update table
                    UpdateResult updateResult = musiciansCollection.UpdateOne(filter, update);

                    if (updateResult.ModifiedCount == 1)
                    {
                        MessageBox.Show("Musician " + musicianName +  " updated successfully",
                                        "Musician Updated",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Musician update failed\n" + musicianName,
                                        "Musician Update Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Musician update failed\n" + musicianName +
                                    "we got the following exception:\n" + ex.Message,
                                    "Musician Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

    }
}
