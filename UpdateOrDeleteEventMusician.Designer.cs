
namespace MongoDB
{
    partial class UpdateOrDeleteEventMusician
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AllAssignMusicianToEvent = new System.Windows.Forms.DataGridView();
            this.btn_DeleteMusicianFromList = new System.Windows.Forms.Button();
            this.btn_UpdateMusicianList = new System.Windows.Forms.Button();
            this.textBox_UpdateEventMusicianEventDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UpdateDeleteEventMusicianEventId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AddMusciansToEvent = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllAssignMusicianToEvent)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddMusciansToEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_AllAssignMusicianToEvent);
            this.groupBox1.Location = new System.Drawing.Point(26, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(374, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assigned to the event";
            // 
            // dataGridView_AllAssignMusicianToEvent
            // 
            this.dataGridView_AllAssignMusicianToEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_AllAssignMusicianToEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllAssignMusicianToEvent.Location = new System.Drawing.Point(3, 21);
            this.dataGridView_AllAssignMusicianToEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_AllAssignMusicianToEvent.Name = "dataGridView_AllAssignMusicianToEvent";
            this.dataGridView_AllAssignMusicianToEvent.RowHeadersWidth = 51;
            this.dataGridView_AllAssignMusicianToEvent.RowTemplate.Height = 24;
            this.dataGridView_AllAssignMusicianToEvent.Size = new System.Drawing.Size(367, 400);
            this.dataGridView_AllAssignMusicianToEvent.TabIndex = 0;
            // 
            // btn_DeleteMusicianFromList
            // 
            this.btn_DeleteMusicianFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_DeleteMusicianFromList.Location = new System.Drawing.Point(104, 627);
            this.btn_DeleteMusicianFromList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteMusicianFromList.Name = "btn_DeleteMusicianFromList";
            this.btn_DeleteMusicianFromList.Size = new System.Drawing.Size(199, 71);
            this.btn_DeleteMusicianFromList.TabIndex = 1;
            this.btn_DeleteMusicianFromList.Text = "Delete Musician(s) from event";
            this.btn_DeleteMusicianFromList.UseVisualStyleBackColor = false;
            this.btn_DeleteMusicianFromList.Click += new System.EventHandler(this.btn_DeleteMusicianFromList_Click);
            // 
            // btn_UpdateMusicianList
            // 
            this.btn_UpdateMusicianList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_UpdateMusicianList.Location = new System.Drawing.Point(506, 627);
            this.btn_UpdateMusicianList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateMusicianList.Name = "btn_UpdateMusicianList";
            this.btn_UpdateMusicianList.Size = new System.Drawing.Size(192, 71);
            this.btn_UpdateMusicianList.TabIndex = 2;
            this.btn_UpdateMusicianList.Text = "Add musician(s) to event";
            this.btn_UpdateMusicianList.UseVisualStyleBackColor = false;
            this.btn_UpdateMusicianList.Click += new System.EventHandler(this.btn_UpdateMusicianList_Click);
            // 
            // textBox_UpdateEventMusicianEventDate
            // 
            this.textBox_UpdateEventMusicianEventDate.Location = new System.Drawing.Point(238, 49);
            this.textBox_UpdateEventMusicianEventDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UpdateEventMusicianEventDate.Name = "textBox_UpdateEventMusicianEventDate";
            this.textBox_UpdateEventMusicianEventDate.ReadOnly = true;
            this.textBox_UpdateEventMusicianEventDate.Size = new System.Drawing.Size(379, 26);
            this.textBox_UpdateEventMusicianEventDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(55, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(40, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Date:";
            // 
            // textBox_UpdateDeleteEventMusicianEventId
            // 
            this.textBox_UpdateDeleteEventMusicianEventId.Location = new System.Drawing.Point(238, 121);
            this.textBox_UpdateDeleteEventMusicianEventId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_UpdateDeleteEventMusicianEventId.Name = "textBox_UpdateDeleteEventMusicianEventId";
            this.textBox_UpdateDeleteEventMusicianEventId.ReadOnly = true;
            this.textBox_UpdateDeleteEventMusicianEventId.Size = new System.Drawing.Size(379, 26);
            this.textBox_UpdateDeleteEventMusicianEventId.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_AddMusciansToEvent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(424, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(374, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Musician to add to the event";
            // 
            // dataGridView_AddMusciansToEvent
            // 
            this.dataGridView_AddMusciansToEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_AddMusciansToEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddMusciansToEvent.Location = new System.Drawing.Point(3, 21);
            this.dataGridView_AddMusciansToEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_AddMusciansToEvent.Name = "dataGridView_AddMusciansToEvent";
            this.dataGridView_AddMusciansToEvent.RowHeadersWidth = 51;
            this.dataGridView_AddMusciansToEvent.RowTemplate.Height = 24;
            this.dataGridView_AddMusciansToEvent.Size = new System.Drawing.Size(367, 400);
            this.dataGridView_AddMusciansToEvent.TabIndex = 0;
            // 
            // UpdateOrDeleteEventMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 844);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_UpdateDeleteEventMusicianEventId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UpdateEventMusicianEventDate);
            this.Controls.Add(this.btn_UpdateMusicianList);
            this.Controls.Add(this.btn_DeleteMusicianFromList);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateOrDeleteEventMusician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateOrDeleteEventMusician";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllAssignMusicianToEvent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddMusciansToEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DeleteMusicianFromList;
        private System.Windows.Forms.Button btn_UpdateMusicianList;
        public System.Windows.Forms.TextBox textBox_UpdateEventMusicianEventDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_UpdateDeleteEventMusicianEventId;
        private System.Windows.Forms.DataGridView dataGridView_AllAssignMusicianToEvent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_AddMusciansToEvent;
    }
}