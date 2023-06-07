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
using System.Text.RegularExpressions;
using MongoDB.Bson;
using System.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.IO;

namespace MongoDB
{
    public partial class Form1 : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        private readonly string externalFile = ConfigurationManager.AppSettings["ExternalFileForBulkActivities"];
        IMongoCollection<Models.Musician> musicianCollection;
        IMongoCollection<Models.Event> eventCollection;
        IMongoCollection<Models.EventMusician> EventMusicianCollection;
        IMongoDatabase db;
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
            dateTimePicker_FilterByTime.Format = DateTimePickerFormat.Time;
            dateTimePicker_FilterByTime.ShowUpDown = true;
            //disable creating events in the past
            dateTimePicker_EventDate.MinDate = DateTime.Now;


            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


            try
            {
                //Create the client Object
                mongoClient = new MongoClient(connectionString);

                // get the DB  OBJECT
                db = mongoClient.GetDatabase(dbName);
                // Get the collection that is called 'Musician,Event,EventMusicianCollection'
                musicianCollection = db.GetCollection<Models.Musician>("Musician");
                eventCollection = db.GetCollection<Models.Event>("Event");
                EventMusicianCollection = db.GetCollection<Models.EventMusician>("EventMusician");



                //list the collection data in the form
                LoadMusiciansUponScreen();
                LoadEventsUponScreen();
                LoadEventMusicanDetails();
                //  WindowState = FormWindowState.Maximized;

            }
            catch (Exception ex)
            {
                mongoClient = null;
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadEventMusicanDetails()
        //load alll the assigned evnets details from the database to the view
        {

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
                    // Check if eventDetails and musicianDetails are null
                    if (eventDetails != null && musicianDetails != null)
                    {
                        // Create an EventDetails object with the relevant details
                        EventDetails eventDetailsObj = new EventDetails
                        (
                            eventDetails.Date,
                            eventDetails?.EventName,
                            eventDetails?.MusicalStyle,
                            eventMusician.EventMusicianID,
                            eventMusician.MusicianList.Count

                        );

                        // Add the EventDetails object to the list
                        eventDetailsList.Add(eventDetailsObj);
                    }

                }
            }
            //group all the assign muscian in one row(for the view)
            List<EventDetails> uniqueEventDetailsList = eventDetailsList.GroupBy(e => e.eventDate).Select(d => d.First()).ToList();
            // Set the eventDetailsList as the data source for the dataGridView_AllAssignEvents control
            dataGridView_AllAssignEvents.DataSource = uniqueEventDetailsList;

            dataGridView_AllAssignEvents.Columns[0].HeaderText = "Date";
            dataGridView_AllAssignEvents.Columns[1].HeaderText = "Event Name";
            dataGridView_AllAssignEvents.Columns[2].HeaderText = "Musical Style";
            dataGridView_AllAssignEvents.Columns[3].HeaderText = "Assigned Musician(s)";
            dataGridView_AllAssignEvents.Columns[4].Visible = false;
            dataGridView_AllAssignEvents.RowHeadersVisible = false;
        }



        public void LoadEventsUponScreen()
        //load all the event's details from the database to the view
        {
            List<Event> events;
            events = eventCollection.Aggregate().ToList();
            //events = events.OrderBy(e => e.Date).ToList();
            dataGridView_Events.DataSource = events;
            dataGridView_Events.Columns[2].HeaderText = "Event Name";
            dataGridView_Events.Columns[3].HeaderText = "Musical Style";
            dataGridView_Events.RowHeadersVisible = false;
            dataGridView_Events.Columns[0].Visible = false;

            //dataGridView_EventsMiscellaneos
            dataGridView_EventsMiscellaneos.DataSource = events;
            dataGridView_EventsMiscellaneos.Columns[2].HeaderText = "Event Name";
            dataGridView_EventsMiscellaneos.Columns[3].HeaderText = "Musical Style";
            dataGridView_EventsMiscellaneos.RowHeadersVisible = false;
            dataGridView_EventsMiscellaneos.Columns[0].Visible = false;
        }

        public void LoadMusiciansUponScreen()
        //load all the musicians details from the database to the view
        {
            List<Musician> musicians;
            musicians = musicianCollection.Aggregate().ToList();
            dataGridView_Musician.DataSource = musicians;
            dataGridView_Musician.Columns[0].Visible = false;
            dataGridView_Musician.RowHeadersVisible = false;
            dataGridView_MusicianMiscellaneos.DataSource = musicians;
            dataGridView_MusicianMiscellaneos.Columns[0].Visible = false;
            dataGridView_MusicianMiscellaneos.RowHeadersVisible = false;
        }



        public void btn_InsertMusician_Click(object sender, EventArgs e)
        {
            // Get musician details from the screen
            Musician musician = GetMusicianDetailsFromScreen();
            if (!Regex.IsMatch(musician.Age, @"^\d+$"))
            {
                MessageBox.Show("Musician Age must be a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return; // age must be a number
            }
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
        //get all the details about musician form the screen to insert them to the database
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
                MessageBox.Show("Please fill in all the required fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Event details:\n" + eventDetails.ToString() + "\nEvent Already Exists on this date!", "Event Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {


                // Insert the event into the collection
                eventCollection.InsertOne(eventDetails);

                // Refresh the list view
                LoadEventsUponScreen();

                MessageBox.Show("Event details:\n" + eventDetails.ToString() + "\nInserted successfully", "Event Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Get the local time zone for Israel
            TimeZoneInfo israelTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time");

            // Convert the event date and time to UTC using the Israel time zone
            DateTime utcDateTime = TimeZoneInfo.ConvertTimeToUtc(dateTime, israelTimeZone);

            // Get the local time zone offset
            TimeSpan timeZoneOffset = israelTimeZone.GetUtcOffset(dateTime);

            // Apply the offset to the UTC date and time
            DateTime localDateTime = utcDateTime.Add(timeZoneOffset);

            string eventName = textBox_EventName.Text.ToLower();
            string musicalType = textBox_MusicalType.Text.ToLower();

            Event newEvent = new Event(localDateTime, eventName, musicalType);
            return newEvent;
        }


        private void btn_RefreshEvents_Click(object sender, EventArgs e)
        {

            try
            {
                //refresh the collection view
                LoadEventsUponScreen();
                MessageBox.Show("Events list refreshed successfully", "Refresh succeed");

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void dataGridView_Events_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateOrDeleteEvent updateOrDeleteEventWin = new UpdateOrDeleteEvent(eventCollection, EventMusicianCollection);
            updateOrDeleteEventWin.textBox_ID.Text = dataGridView_Events.CurrentRow.Cells[0].Value.ToString();
            updateOrDeleteEventWin.textBox_EventName.Text = dataGridView_Events.CurrentRow.Cells[2].Value.ToString();
            updateOrDeleteEventWin.textBox_EventMusicialtype.Text = dataGridView_Events.CurrentRow.Cells[3].Value.ToString();
            string eventDateTime = dataGridView_Events.CurrentRow.Cells[1].Value.ToString();
            //create a  dateTime object
            DateTime dateTime = DateTime.Parse(eventDateTime);

            // Assign date to DateTimePicker
            updateOrDeleteEventWin.dateTimePicker_EventDateUpdate.Value = dateTime.Date;
            updateOrDeleteEventWin.dateTimePicker_EventDateUpdate.MinDate = DateTime.Now;
            // Set the CustomFormat to display and parse only the time component
            updateOrDeleteEventWin.TimePicker_EventTimeUpdate.Format = DateTimePickerFormat.Custom;
            updateOrDeleteEventWin.TimePicker_EventTimeUpdate.CustomFormat = "HH:mm:ss";

            // Assign time to TimePicker
            updateOrDeleteEventWin.TimePicker_EventTimeUpdate.Value = dateTime;
            

            updateOrDeleteEventWin.ShowDialog();

            //refresh the lists with updated data
            LoadEventsUponScreen();
            LoadEventMusicanDetails();
        }




        private void btn_AssignMusicanToEvent_Click(object sender, EventArgs e)
        {

            if (dataGridView_Events.CurrentRow == null || dataGridView_Musician.CurrentRow == null)
            {
                MessageBox.Show("You must Select a musician and Event from the list.", "Assignment Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
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
                        MessageBox.Show("The selected musician is already assigned to the event.", "Assignment Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadEventMusicanDetails();


        }

        private void btn_RefreshMusician_Click_1(object sender, EventArgs e)
        {
            try
            {

                //refresh the collection view
                LoadMusiciansUponScreen();
                MessageBox.Show("Musicians list refreshed successfully", "Refresh succeed");

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void btn_refreshAllAssignEvents_Click(object sender, EventArgs e)
        {
            try
            {
                LoadEventMusicanDetails();

                MessageBox.Show("Assigned events list refreshed successfully", "Refresh succeed");

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following Error accured:\n" + ex.Message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        //private void dateTimePicker_filterDate_ValueChanged(object sender, EventArgs e)
        //{
        //    List<Event> results;
        //    string date = dateTimePicker_filterDate.Text;




        //    // Define the format of the input string (including Hebrew day and month names)
        //    string format = "dddd d MMMM yyyy";

        //    // Parse the combined string into a DateTime object
        //    DateTime dateParse = DateTime.ParseExact(date, format, new CultureInfo("he-IL"));

        //    // Get the start and end DateTime objects for the specified date
        //    DateTime startDate = dateParse.Date;
        //    //create a fake day for range
        //    DateTime endDate = startDate.AddDays(1);

        //    // Build the filter for Event date range
        //    FilterDefinition<Event> filter = Builders<Event>.Filter.Gte(p => p.Date, startDate) &
        //                                      Builders<Event>.Filter.Lt(p => p.Date, endDate);

        //    // Perform the filter query
        //    results = eventCollection.Find(filter).ToList();


        //    // Present the results on the grid
        //    dataGridView_EventsMiscellaneos.DataSource = results;


        //}

        //****************************************************************************************************************************//
        //****************************************************************************************************************************//
        //****************************************************************************************************************************//
        //*****THERE IS A BUG WITH THIS FUNCTION IT DOESN'T SHOW TO CORRECT FILTERED DATE IN THE LIST AND ALSO THE FUNCTION ABOVE****//
        //****************************************************************************************************************************//
        //****************************************************************************************************************************//
        //****************************************************************************************************************************//
        private void dateTimePicker_filterDate_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = dateTimePicker_filterDate.Value.Date;

            // Get the local time zone for Israel
            TimeZoneInfo israelTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time");

            // Convert the selected date to the local time zone
            DateTime selectedDateLocal = TimeZoneInfo.ConvertTime(selectedDate, israelTimeZone);

            // Get the start and end DateTime objects for the specified date in UTC
            DateTime startDateUtc = selectedDateLocal.ToUniversalTime();
            DateTime endDateUtc = startDateUtc.AddDays(1);

            // Build the filter for Event date range
            FilterDefinition<Event> filter = Builders<Event>.Filter.Gte(p => p.Date, startDateUtc) &
                                              Builders<Event>.Filter.Lt(p => p.Date, endDateUtc);

            // Perform the filter query
            List<Event> results = eventCollection.Find(filter).ToList();

            // Present the results on the grid
            dataGridView_EventsMiscellaneos.DataSource = results;
        }





        private void textBox_FilterMusicalStyle_TextChanged(object sender, EventArgs e)
        {
            List<Event> results;
            string musicalStyle = textBox_FilterMusicalStyle.Text;
            if (musicalStyle.Equals(""))
            {
                LoadMusiciansUponScreen();
            }
            {
                //build the filter ('WHERE') filter by Event musicalStyle, and add reference
                FilterDefinition<Event> filter =
                    Builders<Event>.Filter.Where(p => p.MusicalStyle.Contains(musicalStyle));
                //preform the filter - make the filter query
                results = eventCollection.Find(filter).ToList();
                //present the resukts upon the grid
                dataGridView_EventsMiscellaneos.DataSource = results;
            }
        }

        private void textBox_filterEventName_TextChanged(object sender, EventArgs e)
        {
            List<Event> results;
            string eventName = textBox_filterEventName.Text;
            if (eventName.Equals(""))
            {
                LoadEventsUponScreen();
            }
            else
            {
                //build the filter ('WHERE') filter by Event EventName, and add reference
                FilterDefinition<Event> filter =
                    Builders<Event>.Filter.Where(p => p.EventName.Contains(eventName));
                //preform the filter - make the filter query
                results = eventCollection.Find(filter).ToList();
                //present the resukts upon the grid
                dataGridView_EventsMiscellaneos.DataSource = results;
            }
        }

        private void textBox_FilterMusicianName_TextChanged(object sender, EventArgs e)
        {
            List<Musician> results;
            string name = textBox_FilterMusicianName.Text;
            if (name.Equals(""))
            {
                LoadMusiciansUponScreen();
            }
            else
            {
                //build the filter ('WHERE') filter by Musician age, and add reference
                FilterDefinition<Musician> filter =
                Builders<Musician>.Filter.Where(p => p.Name.Contains(name));
                //preform the filter - make the filter query
                results = musicianCollection.Find(filter).ToList();
                //present the resukts upon the grid
                dataGridView_MusicianMiscellaneos.DataSource = results;
            }
        }

        private void textBox_FilterMusicianAge_TextChanged(object sender, EventArgs e)
        {

            List<Musician> results;
            string age = textBox_FilterMusicianAge.Text;
            if (age.Equals(""))
            {
                LoadMusiciansUponScreen();
            }
            else
            {
                //build the filter ('WHERE') filter by Musician age, and add reference
                FilterDefinition<Musician> filter =
                Builders<Musician>.Filter.Eq(p => p.Age, age);
                //preform the filter - make the filter query
                results = musicianCollection.Find(filter).ToList();
                //present the resukts upon the grid
                dataGridView_MusicianMiscellaneos.DataSource = results;
            }
        }

        private void textBox_FilterMusicianInstrument_TextChanged(object sender, EventArgs e)
        {
            List<Musician> results;
            string instrument = textBox_FilterMusicianInstrument.Text;
            if (instrument.Equals(""))
            {
                LoadMusiciansUponScreen();
            }
            else
            {


                //build the filter ('WHERE') filter by Musician instrument, and add reference
                FilterDefinition<Musician> filter =
                    Builders<Musician>.Filter.Where(p => p.Instrument.Contains(instrument));
                //preform the filter - make the filter query
                results = musicianCollection.Find(filter).ToList();
                //present the resukts upon the grid
                dataGridView_MusicianMiscellaneos.DataSource = results;
            }
        }

        private void dataGridView_AllAssignEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string eventMusicianID = dataGridView_AllAssignEvents.CurrentRow.Cells[4].Value.ToString();
            string eventMusicianDate = dataGridView_AllAssignEvents.CurrentRow.Cells[0].Value.ToString();

            UpdateOrDeleteEventMusician updateOrDeleteEventMusician = new UpdateOrDeleteEventMusician(EventMusicianCollection, musicianCollection,
                eventMusicianID, eventMusicianDate);
            updateOrDeleteEventMusician.ShowDialog();
            //load new data to the list of assigned events after closing the dialog
            LoadEventMusicanDetails();
        }



        private void dateTimePicker_FilterByTime_ValueChanged(object sender, EventArgs e)
        {
            List<Event> results;
            string time = dateTimePicker_FilterByTime.Text;

            // Define the format of the input time string
            string timeFormat = "HH:mm:ss";

            // Parse the time string into a DateTime object
            DateTime timeParse = DateTime.ParseExact(time, timeFormat, CultureInfo.InvariantCulture);

            // Get the selected time value
            TimeSpan selectedTime = timeParse.TimeOfDay;

            // Build the filter for Event time range
            FilterDefinition<Event> filter = Builders<Event>.Filter.Empty; // Start with an empty filter

            // Perform the filter query and sort by time
            results = eventCollection.Find(filter)
                .ToList()
                .Where(p => p.Date.TimeOfDay == selectedTime)
                .OrderBy(p => p.Date.TimeOfDay)
                .ToList();

            // Present the results on the grid
            dataGridView_EventsMiscellaneos.DataSource = results;
        }
        public void BackupAllCollections<T>(string backupFolderPath)
        {
            try
            {
                if (string.IsNullOrEmpty(backupFolderPath))
                {
                    MessageBox.Show("Backup folder path cannot be empty or null.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //get a list of collections name that we want to backup
                var collectionNames = db.ListCollectionNames().ToList();//get a list of collections name that we want to backup


                foreach (var collectionName in collectionNames)
                {
                    var collection = db.GetCollection<T>(collectionName);//get the current collection from mongoDB
                    var documents = collection.Find(new BsonDocument()).ToList();

                    string backupFilePath = Path.Combine(backupFolderPath, $"{collectionName}.json");

                    using (var writer = new StreamWriter(backupFilePath))
                    {
                        foreach (var document in documents)
                        {
                            writer.WriteLine(document.ToJson());
                        }
                    }
                }
                MessageBox.Show("Database Backup saved successfully at\n" + backupFolderPath, "Backup success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during backup: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_BackupDB_Click(object sender, EventArgs e)
        {
            string backupFolderPath = textBox_BackupDBFilePath.Text;
            BackupAllCollections<BsonDocument>(backupFolderPath);

        }
        public void RestoreAllCollections<T>(string backupFolderPath)
        {
            try
            {
                if (string.IsNullOrEmpty(backupFolderPath))
                {
                    MessageBox.Show("Restore folder path cannot be empty or null.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var backupFiles = Directory.GetFiles(backupFolderPath, "*.json");

                foreach (var backupFilePath in backupFiles)
                {
                    string collectionName = Path.GetFileNameWithoutExtension(backupFilePath);
                    var collection = db.GetCollection<T>(collectionName);

                    using (var reader = new StreamReader(backupFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            try
                            {
                                var document = BsonDocument.Parse(line);
                                var typedDocument = BsonSerializer.Deserialize<T>(document);
                                collection.InsertOne(typedDocument);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error restoring document in collection {collectionName}: {ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                MessageBox.Show("Database Restored successfully", "Restore success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during restore: {ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_RestoreDB_Click(object sender, EventArgs e)
        {
            string backupFolderPath = textBox_RestoreDBFilePath.Text;
            RestoreAllCollections<BsonDocument>(backupFolderPath);

            //loads the data after perform restore
            LoadMusiciansUponScreen();
            LoadEventMusicanDetails();
            LoadEventsUponScreen();
        }
    }
}
