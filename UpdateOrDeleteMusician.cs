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
            DialogResult result = MessageBox.Show("Are you sure you want to delete the musician" + musicianName + " with ID: " + musicianId + "?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //filter by MusicianID
                    var musicianFilter = Builders<Musician>.Filter.Eq(p => p.MusicianID, musicianId);

                    // Delete the musician from the musicians table
                    DeleteResult musicianDeleteResult = musiciansCollection.DeleteOne(musicianFilter);

                    // Delete the musician from the eventMusicianCollection table
                    var eventMusicianFilter = Builders<EventMusician>.Filter.Eq(p => p.MusicianID, musicianId);
                    //delete from table
                    DeleteResult eventMusicianDeleteResult = eventMusicianCollection.DeleteMany(eventMusicianFilter);

                    if (musicianDeleteResult.DeletedCount == 1 && eventMusicianDeleteResult.DeletedCount > 0)
                    {
                        MessageBox.Show("Musician " + musicianName + " with ID: " + musicianId + " deleted successfully",
                                        "Musician Deleted",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                     

                    }
                    else
                    {
                        MessageBox.Show("Musician " + musicianName + " delete failed\n" + musicianId,
                                        "Musician Delete Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Musician delete failed\n" + musicianId +
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
            DialogResult result = MessageBox.Show("Are you sure you want to update the musician " + musicianName + " with ID: " + musicianId + "?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

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
                        MessageBox.Show("Musician " + musicianName + " with ID: " + musicianId + " updated successfully",
                                        "Musician Updated",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Musician update failed\n" + musicianId,
                                        "Musician Update Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Musician update failed\n" + musicianId +
                                    "we got the following exception:\n" + ex.Message,
                                    "Musician Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

    }
}
