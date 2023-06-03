using MongoDB.Driver;
using MongoDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MongoDB
{
    public partial class Form1 : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        private readonly string externalFile = ConfigurationManager.AppSettings["ExternalFileForBulkActivities"];
        IMongoCollection<Models.Musician> musicianCollection;
        IMongoCollection<Models.Event> eventCollection;
        IMongoCollection<Models.EventMusician> EventMusicianCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // Get ONLY the db NAME as a string
            MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;
            // Create Mongo Client
            MongoClient mongoClient;
            dateTimePicker_EventTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_EventTime.ShowUpDown = true;
            //disable creating events in the past
            dateTimePicker_EventDate.MinDate = DateTime.Now;



            try
            {
                //Create the client Object
                mongoClient = new MongoClient(connectionString);

                // get the DB  OBJECT
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                // Get the collection that is called 'Musician,Event,EventMusicianCollection'
                musicianCollection = db.GetCollection<Models.Musician>("Musician");
                eventCollection = db.GetCollection<Models.Event>("Event");
                EventMusicianCollection = db.GetCollection<Models.EventMusician>("EventMusician");



                //list the collection data in the form
                LoadMusiciansUponScreen();
                LoadEventsUponScreen();
                LoadEventMusicanDetails();
                // insert default file path for bulk activities, when first form loaded
                // textBox_FullPathForBulk.Text = externalFile;
                WindowState = FormWindowState.Maximized;

            }
            catch (Exception ex)
            {
                mongoClient = null;
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadEventMusicanDetails()
        {
            // Rest of the code remains the same
            List<EventMusician> musicianAssignToEvents;
            musicianAssignToEvents = EventMusicianCollection.Aggregate().ToList();


            List<EventDetails> eventDetailsList = new List<EventDetails>();

            foreach (EventMusician eventMusician in musicianAssignToEvents)
            {
                // Retrieve the event and musician details based on the IDs
                foreach (string MusicianID in eventMusician.MusicianList)
                {
                    Event eventDetails = eventCollection.Find(Builders<Event>.Filter.Eq(e => e.EventID, eventMusician.EventID)).FirstOrDefault();
                    Musician musicianDetails = musicianCollection.Find(Builders<Musician>.Filter.Eq(m => m.MusicianID, MusicianID)).FirstOrDefault();
                    if (eventDetails != null && musicianDetails != null)
                    {
                        // Create an EventDetails object with the relevant details
                        EventDetails eventDetailsObj = new EventDetails
                        (
                            eventDetails.Date,
                            eventDetails?.EventName,
                            eventDetails?.MusicalStyle,
                            musicianDetails?.Name,
                            musicianDetails?.Instrument,
                            eventMusician.EventMusicianID
                        );
                        // Check if eventDetails and musicianDetails are null

                        // Add the EventDetails object to the list
                        eventDetailsList.Add(eventDetailsObj);
                    }

                }
            }

            // Set the eventDetailsList as the data source for the dataGridView_AllAssignEvents control
            dataGridView_AllAssignEvents.DataSource = eventDetailsList;
        }



        public void LoadEventsUponScreen()
        {
            List<Event> events;
            events = eventCollection.Aggregate().ToList();
            dataGridView_Events.DataSource = events;
        }

        public void LoadMusiciansUponScreen()
        {
            List<Musician> musicians;
            musicians = musicianCollection.Aggregate().ToList();
            dataGridView_Musician.DataSource = musicians;

        }



        public void btn_InsertMusician_Click(object sender, EventArgs e)
        {
            // Get musician details from the screen
            Musician musician = GetMusicianDetailsFromScreen();

            // Validate the input fields
            if (string.IsNullOrWhiteSpace(musician.Name) || string.IsNullOrWhiteSpace(musician.Age) || string.IsNullOrWhiteSpace(musician.Instrument))
            {
                MessageBox.Show("Please fill in all the required fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is empty
            }

            try
            {
                // Insert the musician into the collection
                musicianCollection.InsertOne(musician);

                // Refresh the collection view
                LoadMusiciansUponScreen();

                MessageBox.Show("Musician details: " + musician.ToString() + "\nInserted successfully", "Musician Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error occurred:\n" + ex.Message, "Musician NOT Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Musician GetMusicianDetailsFromScreen()
        {
            string musicianInstrument = textBox_MusicianIns.Text.ToLower();
            string musicianName = textBox_MusicianName.Text.ToLower();
            string musicianAge = textBox_MusicianAge.Text;
            return new Musician(musicianName, musicianAge, musicianInstrument);
        }

        public void btn_insertEvent_Click(object sender, EventArgs e)
        {

            // Create the event
            Event eventDetails = GetEventDetailsFromScreen();

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(eventDetails.EventName) || string.IsNullOrWhiteSpace(eventDetails.MusicalStyle))
            {
                MessageBox.Show("Please fill in all the required fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is empty
            }

            // Check if event already exists for the specified date
            DateTime startDate = eventDetails.Date.Date; // Extract the date portion
            DateTime endDate = startDate.AddDays(1).AddSeconds(-1); // Set the end time of the day

            FilterDefinition<Event> filter = Builders<Event>.Filter.Gte(p => p.Date, startDate) &
                                              Builders<Event>.Filter.Lt(p => p.Date, endDate);

            bool eventExists = eventCollection.Find(filter).Any();
            if (eventExists)
            {
                MessageBox.Show("Event details: " + eventDetails.ToString() + "\nEvent Already Exists on this date", "Event Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Insert the event into the collection
                eventCollection.InsertOne(eventDetails);

                // Refresh the collection view
                LoadEventsUponScreen(); ;

                MessageBox.Show("Event details: " + eventDetails.ToString() + "\nInserted successfully", "Event Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:\n" + ex.Message, "Event NOT Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public Event GetEventDetailsFromScreen()
        {
            string eventDate = dateTimePicker_EventDate.Text;
            string eventTime = dateTimePicker_EventTime.Text;

            // Combine the date and time strings into a single string
            string eventDateTimeString = $"{eventDate} {eventTime}";

            // Define the format of the input string (including Hebrew day and month names)
            string format = "dddd d MMMM yyyy HH:mm:ss";

            // Parse the combined string into a DateTime object
            DateTime dateTime = DateTime.ParseExact(eventDateTimeString, format, new CultureInfo("he-IL"));

            string eventName = textBox_EventName.Text.ToLower();
            string musicalType = textBox_MusicalType.Text.ToLower();



            return new Event(dateTime, eventName, musicalType);
        }


        private void btn_filterEventMusicalStyle_Click(object sender, EventArgs e)
        {
            List<Event> results;
            string musicalStyle = textBox_FilterMusicalStyle.Text;
            //build the filter ('WHERE') filter by Event musicalStyle, and add reference
            FilterDefinition<Event> filter =
                Builders<Event>.Filter.Eq(p => p.MusicalStyle, musicalStyle);
            //preform the filter - make the filter query
            results = eventCollection.Find(filter).ToList();
            //present the resukts upon the grid
            dataGridView_Events.DataSource = results;
        }



        private void btn_RefreshEvents_Click(object sender, EventArgs e)
        {

            try
            {


                //refresh the collection view
                LoadEventsUponScreen();
                MessageBox.Show("Event list upload refreshed successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void dataGridView_Events_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ToDo- change the call and use the pther ctor (the one that gets a table)
            UpdateOrDeleteEvent updateOrDeleteEventWin = new UpdateOrDeleteEvent(eventCollection, EventMusicianCollection);
            updateOrDeleteEventWin.textBox_ID.Text = dataGridView_Events.CurrentRow.Cells[0].Value.ToString();
            updateOrDeleteEventWin.textBox_EventName.Text = dataGridView_Events.CurrentRow.Cells[2].Value.ToString();
            updateOrDeleteEventWin.textBox_EventMusicialtype.Text = dataGridView_Events.CurrentRow.Cells[3].Value.ToString();
            string eventDateTime = dataGridView_Events.CurrentRow.Cells[1].Value.ToString();
            //create a  dateTime object
            DateTime dateTime = DateTime.Parse(eventDateTime);

            // Assign date to DateTimePicker
            updateOrDeleteEventWin.dateTimePicker_EventDateUpdate.Value = dateTime.Date;
            // Set the CustomFormat to display and parse only the time component
            updateOrDeleteEventWin.TimePicker_EventTimeUpdate.Format = DateTimePickerFormat.Custom;
            updateOrDeleteEventWin.TimePicker_EventTimeUpdate.CustomFormat = "HH:mm:ss";

            // Assign time to TimePicker
            updateOrDeleteEventWin.TimePicker_EventTimeUpdate.Value = dateTime;
            //todo- fill the rest of the fields...

            updateOrDeleteEventWin.ShowDialog();
            LoadEventsUponScreen();
        }



        //private void btn_AssignMusicanToEvent_Click(object sender, EventArgs e)
        //{
        //    // Get the selected event and musician IDs
        //    string eventId = dataGridView_Events.CurrentRow.Cells[0].Value.ToString();
        //    List<string> listMusicianId = new List<string>();

        //    string musicianId = dataGridView_Musician.CurrentRow.Cells[0].Value.ToString();
        //    listMusicianId.Add(musicianId);
        //    try
        //    {


        //        FilterDefinition<EventMusician> eventFilter = Builders<EventMusician>.Filter.Eq(p => p.EventID, eventId);
        //        FilterDefinition<EventMusician> musicianAssignedFilter = Builders<EventMusician>.Filter.Eq(p => p.MusicianList, listMusicianId);
        //        FilterDefinition<EventMusician> filter = Builders<EventMusician>.Filter.And(eventFilter, musicianAssignedFilter);

        //        bool musicianAssigned = EventMusicianCollection.Find(filter).Any();
        //        if (musicianAssigned)
        //        {
        //            MessageBox.Show("The selected musician is already assigned to the event.", "Assignment Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }
        //        var eventMusician2 = EventMusicianCollection.Find(eventFilter);


        //        // Create a new EventMusician object
        //        EventMusician eventMusician = new EventMusician(eventId, listMusicianId);

        //        // Insert the EventMusician object into the collection
        //        EventMusicianCollection.InsertOne(eventMusician);
        //        LoadEventMusicanDetails();

        //        MessageBox.Show("Musician assigned to the event successfully.", "Assignment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while assigning musician to the event:\n" + ex.Message, "Assignment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btn_AssignMusicanToEvent_Click(object sender, EventArgs e)
        {
            // Get the selected event and musician IDs
            string eventId = dataGridView_Events.CurrentRow.Cells[0].Value.ToString();
            string musicianId = dataGridView_Musician.CurrentRow.Cells[0].Value.ToString();
            try
            {
                // Retrieve the existing EventMusician object from the collection based on the eventId
                EventMusician existingEventMusician = EventMusicianCollection.Find(p => p.EventID == eventId).FirstOrDefault();
                // Check if the musician is already assigned to the event
                bool musicianAssigned = EventMusicianCollection.Find(p => p.EventID == eventId && p.MusicianList.Contains(musicianId)).Any();
                if (musicianAssigned)
                {
                    MessageBox.Show("The selected musician is already assigned to the event.", "Assignment Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Check if the EventMusician object already exists
                if (existingEventMusician != null)
                {
                    // Update the MusicianIDs property by adding the new musicianId to the existing list
                    existingEventMusician.MusicianList.Add(musicianId);

                    // Update the EventMusician object in the collection
                    var updateResult = EventMusicianCollection.ReplaceOne(p => p.EventMusicianID == existingEventMusician.EventMusicianID, existingEventMusician);

                    if (updateResult.IsAcknowledged && updateResult.ModifiedCount > 0)
                    {
                        MessageBox.Show("Musician assigned to the event successfully.", "Assignment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEventMusicanDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign musician to the event.", "Assignment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Create a new EventMusician object with the eventId and a list containing the musicianId
                    EventMusician eventMusician = new EventMusician(eventId, new List<string> { musicianId });

                    // Insert the EventMusician object into the collection
                    EventMusicianCollection.InsertOne(eventMusician);
                    LoadEventMusicanDetails();

                    MessageBox.Show("Musician assigned to the event successfully.", "Assignment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while assigning musician to the event:\n" + ex.Message, "Assignment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Musician_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string musicianId = dataGridView_Musician.Rows[e.RowIndex].Cells[0].Value.ToString();
            string musicianName = dataGridView_Musician.Rows[e.RowIndex].Cells[1].Value.ToString();
            string musicianAge = dataGridView_Musician.Rows[e.RowIndex].Cells[2].Value.ToString();
            string musicianInstrument = dataGridView_Musician.Rows[e.RowIndex].Cells[3].Value.ToString();

            // Instantiate the UpdateOrDeleteMusician form and pass the musicians collection
            UpdateOrDeleteMusician updateOrDeleteMusicianWin = new UpdateOrDeleteMusician(musicianCollection, EventMusicianCollection);

            // Populate the text boxes with the selected musician's details
            updateOrDeleteMusicianWin.textBox_MusicianID.Text = musicianId;
            updateOrDeleteMusicianWin.textBox_MusicianNameUpdate.Text = musicianName;
            updateOrDeleteMusicianWin.textBox_MusicianAgeUpdate.Text = musicianAge;
            updateOrDeleteMusicianWin.textBox_MusicianInstrumentUpdate.Text = musicianInstrument;

            // Show the UpdateOrDeleteMusician form as a dialog
            updateOrDeleteMusicianWin.ShowDialog();

            // Reload the musicians upon screen after the dialog is closed
            LoadMusiciansUponScreen();


        }

        private void btn_RefreshMusician_Click_1(object sender, EventArgs e)
        {
            try
            {

                //refresh the collection view
                LoadMusiciansUponScreen();
                MessageBox.Show("Musician list upload refreshed successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btn_FilterByMusicalType_Click(object sender, EventArgs e)
        {
            //string musicalType = textBox_FilterMusicalStyle.Text;

            //// Filter the event details based on the musical type
            //List<EventDetails> filteredEvents = EventMusicianCollection
            //    .Where(eventDetails => eventDetails.MusicalStyle.Equals(musicalType, StringComparison.OrdinalIgnoreCase))
            //    .ToList();

            //// Set the filtered events as the data source for the dataGridView_AllAssignEvents control
            //dataGridView_AllAssignEvents.DataSource = filteredEvents;

        }



        private void btn_refreshAllAssignEvents_Click(object sender, EventArgs e)
        {
            try
            {
                LoadEventMusicanDetails();

                MessageBox.Show("EventMusican list upload refreshed successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void dateTimePicker_filterDate_ValueChanged(object sender, EventArgs e)
        {
            List<Event> results;
            string date = dateTimePicker_filterDate.Text;

            // Define the format of the input string (including Hebrew day and month names)
            string format = "dddd d MMMM yyyy";

            // Parse the combined string into a DateTime object
            DateTime dateParse = DateTime.ParseExact(date, format, new CultureInfo("he-IL"));

            // Get the start and end DateTime objects for the specified date
            DateTime startDate = dateParse.Date;
            //create a fake day for range
            DateTime endDate = startDate.AddDays(1);

            // Build the filter for Event date range
            FilterDefinition<Event> filter = Builders<Event>.Filter.Gte(p => p.Date, startDate) &
                                              Builders<Event>.Filter.Lt(p => p.Date, endDate);

            // Perform the filter query
            results = eventCollection.Find(filter).ToList();

            // Present the results on the grid
            dataGridView_Events.DataSource = results;
        }

        private void textBox_FilterMusicalStyle_TextChanged(object sender, EventArgs e)
        {
            List<Event> results;
            string musicalStyle = textBox_FilterMusicalStyle.Text;
            //build the filter ('WHERE') filter by Event musicalStyle, and add reference
            FilterDefinition<Event> filter =
                Builders<Event>.Filter.Eq(p => p.MusicalStyle, musicalStyle);
            //preform the filter - make the filter query
            results = eventCollection.Find(filter).ToList();
            //present the resukts upon the grid
            dataGridView_Events.DataSource = results;
        }

        private void textBox_filterEventName_TextChanged(object sender, EventArgs e)
        {
            List<Event> results;
            string eventName = textBox_filterEventName.Text;
            if (eventName.Length == 0)
            {
                LoadEventsUponScreen();
            }
            //build the filter ('WHERE') filter by Event EventName, and add reference
            FilterDefinition<Event> filter =
                Builders<Event>.Filter.Eq(p => p.EventName, eventName);
            //preform the filter - make the filter query
            results = eventCollection.Find(filter).ToList();
            //present the resukts upon the grid
            dataGridView_Events.DataSource = results;
        }

        private void textBox_FilterMusicianName_TextChanged(object sender, EventArgs e)
        {
            List<Musician> results;
            string name = textBox_FilterMusicianName.Text;
            //build the filter ('WHERE') filter by Musician age, and add reference
            FilterDefinition<Musician> filter =
                Builders<Musician>.Filter.Eq(p => p.Name, name);
            //preform the filter - make the filter query
            results = musicianCollection.Find(filter).ToList();
            //present the resukts upon the grid
            dataGridView_Musician.DataSource = results;
        }

        private void textBox_FilterMusicianAge_TextChanged(object sender, EventArgs e)
        {
            List<Musician> results;
            string age = textBox_FilterMusicianAge.Text;
            //build the filter ('WHERE') filter by Musician age, and add reference
            FilterDefinition<Musician> filter =
                Builders<Musician>.Filter.Eq(p => p.Age, age);
            //preform the filter - make the filter query
            results = musicianCollection.Find(filter).ToList();
            //present the resukts upon the grid
            dataGridView_Musician.DataSource = results;
        }

        private void textBox_FilterMusicianInstrument_TextChanged(object sender, EventArgs e)
        {
            List<Musician> results;
            string instrument = textBox_FilterMusicianInstrument.Text;
            //build the filter ('WHERE') filter by Musician instrument, and add reference
            FilterDefinition<Musician> filter =
                Builders<Musician>.Filter.Eq(p => p.Instrument, instrument);
            //preform the filter - make the filter query
            results = musicianCollection.Find(filter).ToList();
            //present the resukts upon the grid
            dataGridView_Musician.DataSource = results;
        }

        private void dataGridView_AllAssignEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateOrDeleteEventMusician updateOrDeleteEventMusician = new UpdateOrDeleteEventMusician(EventMusicianCollection);
            updateOrDeleteEventMusician.textBox_UpdateDeleteEventMusicianEventId.Text= dataGridView_AllAssignEvents.CurrentRow.Cells[5].Value.ToString();
            updateOrDeleteEventMusician.textBox_UpdateEventMusicianEventDate.Text= dataGridView_AllAssignEvents.CurrentRow.Cells[0].Value.ToString();
            updateOrDeleteEventMusician.ShowDialog();

        }


    }
}
