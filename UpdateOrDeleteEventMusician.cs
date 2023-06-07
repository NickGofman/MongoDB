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
        IMongoCollection<Musician> musicianCollection;
        string eventMusicianID; 

        public UpdateOrDeleteEventMusician()
        {
            InitializeComponent();
        }

        public UpdateOrDeleteEventMusician(IMongoCollection<EventMusician> eventMusicianCollection, IMongoCollection<Musician> musicianCollection, string eventMusicianID, string eventMusicianDate)
        {
            InitializeComponent();
            this.eventMusicianCollection = eventMusicianCollection;
            this.musicianCollection = musicianCollection;
            this.eventMusicianID = eventMusicianID;
            // Set the text box values
            label_UpdateEventMusicianEventDate.Text = eventMusicianDate;

            // Load the data
            LoadAssignedMusicians();
            LoadAvailableMusicians(eventMusicianID);
        }

        private void DeleteMusicianByID(string musicianID)
        {
            try
            {
                // Retrieve the event musicians list that contain the musician ID in the MusicianList
                var musiciansToUpdate = eventMusicianCollection.Find(mv => mv.MusicianList.Contains(musicianID) && mv.EventMusicianID == eventMusicianID).ToList();

                foreach (var musician in musiciansToUpdate)
                {
                    // Remove the musician from the MusicianList
                    musician.MusicianList.Remove(musicianID);

                    // Update the event musician document in the collection
                    eventMusicianCollection.ReplaceOne(m => m.EventMusicianID == musician.EventMusicianID, musician);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing musician with ID {musicianID} from the EventMusician list: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAssignedMusicians()
        {
            try
            {
                // Retrieve the list of assigned musicians for the current eventMusicianID
                var assignedMusicians = eventMusicianCollection.AsQueryable()
                    .Where(em => em.EventMusicianID == eventMusicianID)
                    .SelectMany(em => em.MusicianList)
                    .Distinct()
                    .ToList();

                // Create a DataTable to hold the musician data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Select", typeof(bool));
                dataTable.Columns.Add("MusicianName");
                dataTable.Columns.Add("Instrument");
                dataTable.Columns.Add("MusicianID");

                // Iterate through the assigned musicians and add rows to the DataTable
                foreach (var musicianID in assignedMusicians)
                {
                    // Retrieve the musician information from the database or any other source
                    var musician = GetMusicianByID(musicianID);

                    // Add a row to the DataTable with the musician information
                    dataTable.Rows.Add(false, musician.Name, musician.Instrument, musicianID);
                }

                // Set the DataTable as the data source for the DataGridView
                dataGridView_AllAssignMusicianToEvent.DataSource = dataTable;

                dataGridView_AllAssignMusicianToEvent.Columns[1].HeaderText = "Musician Name";
                dataGridView_AllAssignMusicianToEvent.Columns[2].HeaderText = "Instrument";

                dataGridView_AllAssignMusicianToEvent.Columns[3].Visible = false;

                dataGridView_AllAssignMusicianToEvent.RowHeadersVisible = false;
                // Disable cell value incrementing for the "Select" column
                dataGridView_AllAssignMusicianToEvent.Columns["Select"].DefaultCellStyle.NullValue = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading assigned musicians: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Musician GetMusicianByID(string musicianID)
        {
            try
            {
                // Retrieve the musician from the database based on the ID
                var musician = musicianCollection.Find(m => m.MusicianID == musicianID).FirstOrDefault();
                return musician;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving musician with ID {musicianID}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LoadAvailableMusicians(string eventMusicianID)
        {
            try
            {
                // Retrieve the assigned musicians for the specified eventMusician ID
                var assignedMusicians = eventMusicianCollection.Find(em => em.EventMusicianID == eventMusicianID)
                    .FirstOrDefault()?.MusicianList ?? new List<string>();

                // Retrieve the list of all musicians that are not assigned to the event
                var availableMusicians = musicianCollection.Find(m => !assignedMusicians.Contains(m.MusicianID)).ToList();

                // Create a new DataTable
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Select", typeof(bool));
                dataTable.Columns.Add("MusicianName");
                dataTable.Columns.Add("Instrument");
                dataTable.Columns.Add("MusicianID");

                // Populate the DataTable with the available musicians
                foreach (var musician in availableMusicians)
                {
                    dataTable.Rows.Add(false, musician.Name, musician.Instrument, musician.MusicianID);
                }

                // Set the DataTable as the data source for the DataGridView
                dataGridView_AddMusciansToEvent.DataSource = dataTable;
                dataGridView_AddMusciansToEvent.Columns[1].HeaderText = "Musician Name";
                dataGridView_AddMusciansToEvent.Columns[2].HeaderText = "Instrument";

                dataGridView_AddMusciansToEvent.Columns[3].Visible = false;

                dataGridView_AddMusciansToEvent.RowHeadersVisible = false;

                // Disable cell value incrementing for the "Select" column
                dataGridView_AddMusciansToEvent.Columns["Select"].DefaultCellStyle.NullValue = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading available musicians: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_DeleteMusicianFromList_Click(object sender, EventArgs e)
        {
            // Get the selected musician IDs and names from the DataGridView
            List<string> selectedMusicianIDs = new List<string>();

            foreach (DataGridViewRow row in dataGridView_AllAssignMusicianToEvent.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                if (checkboxCell.Value != null && (bool)checkboxCell.Value)
                {
                    string musicianID = row.Cells["MusicianID"].Value.ToString();

                    selectedMusicianIDs.Add(musicianID);
                }
            }
            if (selectedMusicianIDs.Count == 0)
            {
                MessageBox.Show("You must select a Musician to delete from event", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 

            // Delete the selected musicians
            foreach (string musicianID in selectedMusicianIDs)
            {
                DeleteMusicianByID(musicianID);
            }

            // Refresh the list of musicians
            LoadAssignedMusicians();

            // Refresh the list of available musicians
            LoadAvailableMusicians(eventMusicianID);

            // Display a message
            MessageBox.Show($"Deleted {selectedMusicianIDs.Count} musician(s) from the EventMusician list.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_UpdateMusicianList_Click(object sender, EventArgs e)
        {
            // Get the selected musician IDs from the DataGridView
            List<string> selectedMusicianIDs = new List<string>();

            foreach (DataGridViewRow row in dataGridView_AddMusciansToEvent.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                if (checkboxCell.Value != null && (bool)checkboxCell.Value)
                {
                    string musicianID = row.Cells["MusicianID"].Value.ToString();
                    selectedMusicianIDs.Add(musicianID);
                }
            }
            if (selectedMusicianIDs.Count == 0)
            {

                MessageBox.Show("You must select a Musician to assign to event", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {


                // Retrieve the event musician ID

                try
                {
                // Find the event musician document in the collection
                var eventMusician = eventMusicianCollection.Find(em => em.EventMusicianID == eventMusicianID).FirstOrDefault();

                if (eventMusician != null)
                {
                    // Add the selected musicians to the MusicianList
                    eventMusician.MusicianList.AddRange(selectedMusicianIDs);

                    // Update the event musician document in the collection
                    eventMusicianCollection.ReplaceOne(em => em.EventMusicianID == eventMusicianID, eventMusician);

                    MessageBox.Show("Musicians added to the EventMusician list successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"EventMusician with ID {eventMusicianID} not found.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the EventMusician list: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the list of musicians
            LoadAssignedMusicians();
            LoadAvailableMusicians(eventMusicianID);
            }
        }

   
    }
}
