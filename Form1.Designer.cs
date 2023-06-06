
using System;

namespace MongoDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_refreshAllAssignEvents = new System.Windows.Forms.Button();
            this.dataGridView_AllAssignEvents = new System.Windows.Forms.DataGridView();
            this.btn_AssignMusicanToEvent = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_RefreshMusician = new System.Windows.Forms.Button();
            this.dataGridView_Musician = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_FilterMusicianInstrument = new System.Windows.Forms.TextBox();
            this.textBox_FilterMusicianAge = new System.Windows.Forms.TextBox();
            this.textBox_FilterMusicianName = new System.Windows.Forms.TextBox();
            this.groupBox_InsertProduct = new System.Windows.Forms.GroupBox();
            this.btn_InsertMusician = new System.Windows.Forms.Button();
            this.textBox_MusicianName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MusicianAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MusicianIns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RefreshEvents = new System.Windows.Forms.Button();
            this.dataGridView_Events = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_FilterByTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_filterEventName = new System.Windows.Forms.TextBox();
            this.textBox_FilterMusicalStyle = new System.Windows.Forms.TextBox();
            this.dateTimePicker_filterDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker_EventTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EventDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_insertEvent = new System.Windows.Forms.Button();
            this.textBox_EventName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MusicalType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_BackupDBFilePath = new System.Windows.Forms.TextBox();
            this.textBox_RestoreDBFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_BackupDB = new System.Windows.Forms.Button();
            this.btn_RestoreDB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllAssignEvents)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Musician)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox_InsertProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_AssignMusicanToEvent);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(2136, 1132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active Stage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_refreshAllAssignEvents);
            this.groupBox2.Controls.Add(this.dataGridView_AllAssignEvents);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1401, 380);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(710, 687);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assigned Events";
            // 
            // btn_refreshAllAssignEvents
            // 
            this.btn_refreshAllAssignEvents.Location = new System.Drawing.Point(224, 630);
            this.btn_refreshAllAssignEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refreshAllAssignEvents.Name = "btn_refreshAllAssignEvents";
            this.btn_refreshAllAssignEvents.Size = new System.Drawing.Size(289, 42);
            this.btn_refreshAllAssignEvents.TabIndex = 7;
            this.btn_refreshAllAssignEvents.Text = "Refresh Assigned Events";
            this.btn_refreshAllAssignEvents.UseVisualStyleBackColor = true;
            this.btn_refreshAllAssignEvents.Click += new System.EventHandler(this.btn_refreshAllAssignEvents_Click);
            // 
            // dataGridView_AllAssignEvents
            // 
            this.dataGridView_AllAssignEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllAssignEvents.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AllAssignEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_AllAssignEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AllAssignEvents.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_AllAssignEvents.EnableHeadersVisualStyles = false;
            this.dataGridView_AllAssignEvents.Location = new System.Drawing.Point(7, 36);
            this.dataGridView_AllAssignEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_AllAssignEvents.Name = "dataGridView_AllAssignEvents";
            this.dataGridView_AllAssignEvents.ReadOnly = true;
            this.dataGridView_AllAssignEvents.RowHeadersWidth = 51;
            this.dataGridView_AllAssignEvents.RowTemplate.Height = 30;
            this.dataGridView_AllAssignEvents.Size = new System.Drawing.Size(696, 578);
            this.dataGridView_AllAssignEvents.TabIndex = 0;
            this.dataGridView_AllAssignEvents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllAssignEvents_CellDoubleClick);
            // 
            // btn_AssignMusicanToEvent
            // 
            this.btn_AssignMusicanToEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AssignMusicanToEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssignMusicanToEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AssignMusicanToEvent.Location = new System.Drawing.Point(1408, 28);
            this.btn_AssignMusicanToEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AssignMusicanToEvent.Name = "btn_AssignMusicanToEvent";
            this.btn_AssignMusicanToEvent.Size = new System.Drawing.Size(431, 169);
            this.btn_AssignMusicanToEvent.TabIndex = 34;
            this.btn_AssignMusicanToEvent.Text = "Assign Musician To Event";
            this.btn_AssignMusicanToEvent.UseVisualStyleBackColor = false;
            this.btn_AssignMusicanToEvent.Click += new System.EventHandler(this.btn_AssignMusicanToEvent_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_RefreshMusician);
            this.groupBox6.Controls.Add(this.dataGridView_Musician);
            this.groupBox6.Controls.Add(this.groupBox10);
            this.groupBox6.Controls.Add(this.groupBox_InsertProduct);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(729, 12);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(665, 1055);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "All Musician:";
            // 
            // btn_RefreshMusician
            // 
            this.btn_RefreshMusician.Location = new System.Drawing.Point(197, 310);
            this.btn_RefreshMusician.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RefreshMusician.Name = "btn_RefreshMusician";
            this.btn_RefreshMusician.Size = new System.Drawing.Size(289, 42);
            this.btn_RefreshMusician.TabIndex = 25;
            this.btn_RefreshMusician.Text = "Refresh Musicains";
            this.btn_RefreshMusician.UseVisualStyleBackColor = true;
            this.btn_RefreshMusician.Click += new System.EventHandler(this.btn_RefreshMusician_Click_1);
            // 
            // dataGridView_Musician
            // 
            this.dataGridView_Musician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Musician.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Musician.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_Musician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Musician.EnableHeadersVisualStyles = false;
            this.dataGridView_Musician.Location = new System.Drawing.Point(7, 36);
            this.dataGridView_Musician.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Musician.Name = "dataGridView_Musician";
            this.dataGridView_Musician.ReadOnly = true;
            this.dataGridView_Musician.RowHeadersWidth = 51;
            this.dataGridView_Musician.RowTemplate.Height = 30;
            this.dataGridView_Musician.Size = new System.Drawing.Size(647, 258);
            this.dataGridView_Musician.TabIndex = 0;
            this.dataGridView_Musician.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Musician_CellDoubleClick);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.textBox_FilterMusicianInstrument);
            this.groupBox10.Controls.Add(this.textBox_FilterMusicianAge);
            this.groupBox10.Controls.Add(this.textBox_FilterMusicianName);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox10.Location = new System.Drawing.Point(7, 742);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(647, 298);
            this.groupBox10.TabIndex = 33;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Musician Filter";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(397, 29);
            this.label19.TabIndex = 35;
            this.label19.Text = "Filter ONLY By Musician Instrument:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(329, 29);
            this.label18.TabIndex = 34;
            this.label18.Text = "Filter ONLY By Musician Age:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(351, 29);
            this.label17.TabIndex = 33;
            this.label17.Text = "Filter ONLY By Musician Name:";
            // 
            // textBox_FilterMusicianInstrument
            // 
            this.textBox_FilterMusicianInstrument.Location = new System.Drawing.Point(404, 221);
            this.textBox_FilterMusicianInstrument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FilterMusicianInstrument.Name = "textBox_FilterMusicianInstrument";
            this.textBox_FilterMusicianInstrument.Size = new System.Drawing.Size(228, 35);
            this.textBox_FilterMusicianInstrument.TabIndex = 26;
            this.textBox_FilterMusicianInstrument.TextChanged += new System.EventHandler(this.textBox_FilterMusicianInstrument_TextChanged);
            // 
            // textBox_FilterMusicianAge
            // 
            this.textBox_FilterMusicianAge.Location = new System.Drawing.Point(404, 136);
            this.textBox_FilterMusicianAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FilterMusicianAge.Name = "textBox_FilterMusicianAge";
            this.textBox_FilterMusicianAge.Size = new System.Drawing.Size(228, 35);
            this.textBox_FilterMusicianAge.TabIndex = 24;
            this.textBox_FilterMusicianAge.TextChanged += new System.EventHandler(this.textBox_FilterMusicianAge_TextChanged);
            // 
            // textBox_FilterMusicianName
            // 
            this.textBox_FilterMusicianName.Location = new System.Drawing.Point(404, 42);
            this.textBox_FilterMusicianName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FilterMusicianName.Name = "textBox_FilterMusicianName";
            this.textBox_FilterMusicianName.Size = new System.Drawing.Size(228, 35);
            this.textBox_FilterMusicianName.TabIndex = 23;
            this.textBox_FilterMusicianName.TextChanged += new System.EventHandler(this.textBox_FilterMusicianName_TextChanged);
            // 
            // groupBox_InsertProduct
            // 
            this.groupBox_InsertProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox_InsertProduct.Controls.Add(this.btn_InsertMusician);
            this.groupBox_InsertProduct.Controls.Add(this.textBox_MusicianName);
            this.groupBox_InsertProduct.Controls.Add(this.label3);
            this.groupBox_InsertProduct.Controls.Add(this.textBox_MusicianAge);
            this.groupBox_InsertProduct.Controls.Add(this.label2);
            this.groupBox_InsertProduct.Controls.Add(this.textBox_MusicianIns);
            this.groupBox_InsertProduct.Controls.Add(this.label1);
            this.groupBox_InsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_InsertProduct.Location = new System.Drawing.Point(7, 388);
            this.groupBox_InsertProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_InsertProduct.Name = "groupBox_InsertProduct";
            this.groupBox_InsertProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_InsertProduct.Size = new System.Drawing.Size(647, 340);
            this.groupBox_InsertProduct.TabIndex = 30;
            this.groupBox_InsertProduct.TabStop = false;
            this.groupBox_InsertProduct.Text = "Insert Musician";
            // 
            // btn_InsertMusician
            // 
            this.btn_InsertMusician.Location = new System.Drawing.Point(404, 272);
            this.btn_InsertMusician.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InsertMusician.Name = "btn_InsertMusician";
            this.btn_InsertMusician.Size = new System.Drawing.Size(228, 48);
            this.btn_InsertMusician.TabIndex = 6;
            this.btn_InsertMusician.Text = "Insert Musician";
            this.btn_InsertMusician.UseVisualStyleBackColor = true;
            this.btn_InsertMusician.Click += new System.EventHandler(this.btn_InsertMusician_Click);
            // 
            // textBox_MusicianName
            // 
            this.textBox_MusicianName.Location = new System.Drawing.Point(234, 59);
            this.textBox_MusicianName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MusicianName.Name = "textBox_MusicianName";
            this.textBox_MusicianName.Size = new System.Drawing.Size(304, 35);
            this.textBox_MusicianName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Musician Name";
            // 
            // textBox_MusicianAge
            // 
            this.textBox_MusicianAge.Location = new System.Drawing.Point(234, 202);
            this.textBox_MusicianAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MusicianAge.Name = "textBox_MusicianAge";
            this.textBox_MusicianAge.Size = new System.Drawing.Size(304, 35);
            this.textBox_MusicianAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // textBox_MusicianIns
            // 
            this.textBox_MusicianIns.Location = new System.Drawing.Point(234, 128);
            this.textBox_MusicianIns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MusicianIns.Name = "textBox_MusicianIns";
            this.textBox_MusicianIns.Size = new System.Drawing.Size(304, 35);
            this.textBox_MusicianIns.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrument:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RefreshEvents);
            this.groupBox1.Controls.Add(this.dataGridView_Events);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(669, 1060);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events:";
            // 
            // btn_RefreshEvents
            // 
            this.btn_RefreshEvents.Location = new System.Drawing.Point(171, 310);
            this.btn_RefreshEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RefreshEvents.Name = "btn_RefreshEvents";
            this.btn_RefreshEvents.Size = new System.Drawing.Size(289, 42);
            this.btn_RefreshEvents.TabIndex = 7;
            this.btn_RefreshEvents.Text = "Refresh Events";
            this.btn_RefreshEvents.UseVisualStyleBackColor = true;
            this.btn_RefreshEvents.Click += new System.EventHandler(this.btn_RefreshEvents_Click);
            // 
            // dataGridView_Events
            // 
            this.dataGridView_Events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Events.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Events.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Events.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_Events.EnableHeadersVisualStyles = false;
            this.dataGridView_Events.Location = new System.Drawing.Point(10, 36);
            this.dataGridView_Events.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Events.Name = "dataGridView_Events";
            this.dataGridView_Events.ReadOnly = true;
            this.dataGridView_Events.RowHeadersWidth = 51;
            this.dataGridView_Events.RowTemplate.Height = 30;
            this.dataGridView_Events.Size = new System.Drawing.Size(650, 256);
            this.dataGridView_Events.TabIndex = 0;
            this.dataGridView_Events.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Events_CellDoubleClick);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.dateTimePicker_FilterByTime);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.textBox_filterEventName);
            this.groupBox9.Controls.Add(this.textBox_FilterMusicalStyle);
            this.groupBox9.Controls.Add(this.dateTimePicker_filterDate);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox9.Location = new System.Drawing.Point(10, 742);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(650, 298);
            this.groupBox9.TabIndex = 32;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Event Filter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "Filter ONLY By Time:";
            // 
            // dateTimePicker_FilterByTime
            // 
            this.dateTimePicker_FilterByTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_FilterByTime.Location = new System.Drawing.Point(335, 115);
            this.dateTimePicker_FilterByTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_FilterByTime.Name = "dateTimePicker_FilterByTime";
            this.dateTimePicker_FilterByTime.Size = new System.Drawing.Size(308, 35);
            this.dateTimePicker_FilterByTime.TabIndex = 33;
            this.dateTimePicker_FilterByTime.Value = new System.DateTime(2023, 5, 31, 20, 0, 0, 0);
            this.dateTimePicker_FilterByTime.ValueChanged += new System.EventHandler(this.dateTimePicker_FilterByTime_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(316, 29);
            this.label16.TabIndex = 32;
            this.label16.Text = "Filter ONLY By Event Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(326, 29);
            this.label15.TabIndex = 31;
            this.label15.Text = "Filter ONLY By Musical Style:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 29);
            this.label14.TabIndex = 30;
            this.label14.Text = "Filter ONLY By Date:";
            // 
            // textBox_filterEventName
            // 
            this.textBox_filterEventName.Location = new System.Drawing.Point(335, 230);
            this.textBox_filterEventName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_filterEventName.Name = "textBox_filterEventName";
            this.textBox_filterEventName.Size = new System.Drawing.Size(306, 35);
            this.textBox_filterEventName.TabIndex = 29;
            this.textBox_filterEventName.TextChanged += new System.EventHandler(this.textBox_filterEventName_TextChanged);
            // 
            // textBox_FilterMusicalStyle
            // 
            this.textBox_FilterMusicalStyle.Location = new System.Drawing.Point(338, 172);
            this.textBox_FilterMusicalStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FilterMusicalStyle.Name = "textBox_FilterMusicalStyle";
            this.textBox_FilterMusicalStyle.Size = new System.Drawing.Size(306, 35);
            this.textBox_FilterMusicalStyle.TabIndex = 27;
            this.textBox_FilterMusicalStyle.TextChanged += new System.EventHandler(this.textBox_FilterMusicalStyle_TextChanged);
            // 
            // dateTimePicker_filterDate
            // 
            this.dateTimePicker_filterDate.Location = new System.Drawing.Point(305, 58);
            this.dateTimePicker_filterDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_filterDate.Name = "dateTimePicker_filterDate";
            this.dateTimePicker_filterDate.Size = new System.Drawing.Size(336, 35);
            this.dateTimePicker_filterDate.TabIndex = 24;
            this.dateTimePicker_filterDate.ValueChanged += new System.EventHandler(this.dateTimePicker_filterDate_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.dateTimePicker_EventTime);
            this.groupBox5.Controls.Add(this.dateTimePicker_EventDate);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btn_insertEvent);
            this.groupBox5.Controls.Add(this.textBox_EventName);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox_MusicalType);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 388);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(650, 340);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Insert new Event";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 29);
            this.label13.TabIndex = 11;
            this.label13.Text = "Time:";
            // 
            // dateTimePicker_EventTime
            // 
            this.dateTimePicker_EventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_EventTime.Location = new System.Drawing.Point(208, 111);
            this.dateTimePicker_EventTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_EventTime.Name = "dateTimePicker_EventTime";
            this.dateTimePicker_EventTime.Size = new System.Drawing.Size(329, 35);
            this.dateTimePicker_EventTime.TabIndex = 10;
            this.dateTimePicker_EventTime.Value = new System.DateTime(2023, 5, 31, 20, 0, 0, 0);
            // 
            // dateTimePicker_EventDate
            // 
            this.dateTimePicker_EventDate.Location = new System.Drawing.Point(208, 49);
            this.dateTimePicker_EventDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_EventDate.Name = "dateTimePicker_EventDate";
            this.dateTimePicker_EventDate.Size = new System.Drawing.Size(329, 35);
            this.dateTimePicker_EventDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pick Event Date:";
            // 
            // btn_insertEvent
            // 
            this.btn_insertEvent.Location = new System.Drawing.Point(397, 272);
            this.btn_insertEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insertEvent.Name = "btn_insertEvent";
            this.btn_insertEvent.Size = new System.Drawing.Size(234, 48);
            this.btn_insertEvent.TabIndex = 6;
            this.btn_insertEvent.Text = "Insert New Event";
            this.btn_insertEvent.UseVisualStyleBackColor = true;
            this.btn_insertEvent.Click += new System.EventHandler(this.btn_insertEvent_Click);
            // 
            // textBox_EventName
            // 
            this.textBox_EventName.Location = new System.Drawing.Point(208, 215);
            this.textBox_EventName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_EventName.Name = "textBox_EventName";
            this.textBox_EventName.Size = new System.Drawing.Size(329, 35);
            this.textBox_EventName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Event Name:";
            // 
            // textBox_MusicalType
            // 
            this.textBox_MusicalType.Location = new System.Drawing.Point(208, 156);
            this.textBox_MusicalType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_MusicalType.Name = "textBox_MusicalType";
            this.textBox_MusicalType.Size = new System.Drawing.Size(329, 35);
            this.textBox_MusicalType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Musical Type:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2144, 1174);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(2136, 1132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore And Backup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_BackupDB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_BackupDBFilePath);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1133, 275);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backup Database";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_RestoreDB);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_RestoreDBFilePath);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(28, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1133, 275);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Restore Database";
            // 
            // textBox_BackupDBFilePath
            // 
            this.textBox_BackupDBFilePath.Location = new System.Drawing.Point(231, 73);
            this.textBox_BackupDBFilePath.Name = "textBox_BackupDBFilePath";
            this.textBox_BackupDBFilePath.Size = new System.Drawing.Size(858, 39);
            this.textBox_BackupDBFilePath.TabIndex = 0;
            // 
            // textBox_RestoreDBFilePath
            // 
            this.textBox_RestoreDBFilePath.Location = new System.Drawing.Point(231, 128);
            this.textBox_RestoreDBFilePath.Name = "textBox_RestoreDBFilePath";
            this.textBox_RestoreDBFilePath.Size = new System.Drawing.Size(858, 39);
            this.textBox_RestoreDBFilePath.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "File Path:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "File Path:";
            // 
            // btn_BackupDB
            // 
            this.btn_BackupDB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_BackupDB.Location = new System.Drawing.Point(416, 184);
            this.btn_BackupDB.Name = "btn_BackupDB";
            this.btn_BackupDB.Size = new System.Drawing.Size(263, 58);
            this.btn_BackupDB.TabIndex = 2;
            this.btn_BackupDB.Text = "Backup Database";
            this.btn_BackupDB.UseVisualStyleBackColor = false;
            this.btn_BackupDB.Click += new System.EventHandler(this.btn_BackupDB_Click);
            // 
            // btn_RestoreDB
            // 
            this.btn_RestoreDB.BackColor = System.Drawing.Color.Violet;
            this.btn_RestoreDB.Location = new System.Drawing.Point(416, 194);
            this.btn_RestoreDB.Name = "btn_RestoreDB";
            this.btn_RestoreDB.Size = new System.Drawing.Size(263, 58);
            this.btn_RestoreDB.TabIndex = 3;
            this.btn_RestoreDB.Text = "Restore Database";
            this.btn_RestoreDB.UseVisualStyleBackColor = false;
            this.btn_RestoreDB.Click += new System.EventHandler(this.btn_RestoreDB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(706, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(516, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "You can only restore from valid .json file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2157, 1195);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllAssignEvents)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Musician)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox_InsertProduct.ResumeLayout(false);
            this.groupBox_InsertProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_AssignMusicanToEvent;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_FilterMusicianInstrument;
        private System.Windows.Forms.TextBox textBox_FilterMusicianAge;
        private System.Windows.Forms.TextBox textBox_FilterMusicianName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_RefreshMusician;
        private System.Windows.Forms.DataGridView dataGridView_Musician;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_filterEventName;
        private System.Windows.Forms.TextBox textBox_FilterMusicalStyle;
        private System.Windows.Forms.DateTimePicker dateTimePicker_filterDate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EventTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EventDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_insertEvent;
        private System.Windows.Forms.TextBox textBox_EventName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MusicalType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_InsertProduct;
        private System.Windows.Forms.Button btn_InsertMusician;
        private System.Windows.Forms.TextBox textBox_MusicianName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MusicianAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MusicianIns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_RefreshEvents;
        private System.Windows.Forms.DataGridView dataGridView_Events;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_refreshAllAssignEvents;
        private System.Windows.Forms.DataGridView dataGridView_AllAssignEvents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FilterByTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_BackupDBFilePath;
        private System.Windows.Forms.Button btn_RestoreDB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_RestoreDBFilePath;
        private System.Windows.Forms.Button btn_BackupDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

