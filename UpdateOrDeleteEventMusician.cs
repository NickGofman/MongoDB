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
    public partial class UpdateOrDeleteEventMusician : Form
    {
        IMongoCollection<EventMusician> eventMusicianCollection;
        public UpdateOrDeleteEventMusician()
        {
            InitializeComponent();
        }
        public UpdateOrDeleteEventMusician( IMongoCollection<EventMusician> eventMusicianCollection)
        {
            InitializeComponent();
            this.eventMusicianCollection = eventMusicianCollection;
        }
        private void DeleteMusicianByID(string musicianID)
        {
            try
            {
                // Retrieve the event musicians that contain the musician ID in the MusicianList
                var musiciansToUpdate = eventMusicianCollection.Find(m => m.MusicianList.Contains(musicianID)).ToList();

                foreach (var musician in musiciansToUpdate)
                {
                    // Remove the musician from the MusicianList
                    musician.MusicianList.Remove(musicianID);

                    // Update the event musician document in the collection
                    eventMusicianCollection.ReplaceOne(m => m.EventMusicianID == musician.EventMusicianID, musician);
                }

                Console.WriteLine($"Musician with ID {musicianID} removed from the EventMusician list successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while removing musician with ID {musicianID} from the EventMusician list: {ex.Message}");
            }
        }
        private void btn_DeleteMusicianFromList_Click(object sender, EventArgs e)
        {
            // Get the selected musician IDs from the ListBox
            List<string> selectedMusicianIDs = AssignedMusicians.SelectedItems.Cast<string>().ToList();

            // Iterate through the selected musician IDs and delete them
            foreach (string musicianID in selectedMusicianIDs)
            {
                // Perform the deletion operation for each musician ID
                DeleteMusicianByID(musicianID);
            }

            // Refresh the list of musicians
            //LoadMusicians();
        }

    }
}
