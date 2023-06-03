
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
            this.AssignedMusicians = new System.Windows.Forms.ListBox();
            this.btn_DeleteMusicianFromList = new System.Windows.Forms.Button();
            this.btn_UpdateMusicianList = new System.Windows.Forms.Button();
            this.textBox_UpdateEventMusicianEventDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UpdateDeleteEventMusicianEventId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AssignedMusicians);
            this.groupBox1.Location = new System.Drawing.Point(29, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assigned Musician";
            // 
            // AssignedMusicians
            // 
            this.AssignedMusicians.FormattingEnabled = true;
            this.AssignedMusicians.ItemHeight = 20;
            this.AssignedMusicians.Location = new System.Drawing.Point(17, 34);
            this.AssignedMusicians.Name = "AssignedMusicians";
            this.AssignedMusicians.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AssignedMusicians.Size = new System.Drawing.Size(310, 344);
            this.AssignedMusicians.TabIndex = 0;
            // 
            // btn_DeleteMusicianFromList
            // 
            this.btn_DeleteMusicianFromList.Location = new System.Drawing.Point(69, 656);
            this.btn_DeleteMusicianFromList.Name = "btn_DeleteMusicianFromList";
            this.btn_DeleteMusicianFromList.Size = new System.Drawing.Size(153, 71);
            this.btn_DeleteMusicianFromList.TabIndex = 1;
            this.btn_DeleteMusicianFromList.Text = "DELETE";
            this.btn_DeleteMusicianFromList.UseVisualStyleBackColor = true;
            this.btn_DeleteMusicianFromList.Click += new System.EventHandler(this.btn_DeleteMusicianFromList_Click);
            // 
            // btn_UpdateMusicianList
            // 
            this.btn_UpdateMusicianList.Location = new System.Drawing.Point(336, 656);
            this.btn_UpdateMusicianList.Name = "btn_UpdateMusicianList";
            this.btn_UpdateMusicianList.Size = new System.Drawing.Size(153, 71);
            this.btn_UpdateMusicianList.TabIndex = 2;
            this.btn_UpdateMusicianList.Text = "UPDATE";
            this.btn_UpdateMusicianList.UseVisualStyleBackColor = true;
            // 
            // textBox_UpdateEventMusicianEventDate
            // 
            this.textBox_UpdateEventMusicianEventDate.Location = new System.Drawing.Point(239, 49);
            this.textBox_UpdateEventMusicianEventDate.Name = "textBox_UpdateEventMusicianEventDate";
            this.textBox_UpdateEventMusicianEventDate.Size = new System.Drawing.Size(379, 26);
            this.textBox_UpdateEventMusicianEventDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(55, 117);
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
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Date:";
            // 
            // textBox_UpdateDeleteEventMusicianEventId
            // 
            this.textBox_UpdateDeleteEventMusicianEventId.Location = new System.Drawing.Point(239, 121);
            this.textBox_UpdateDeleteEventMusicianEventId.Name = "textBox_UpdateDeleteEventMusicianEventId";
            this.textBox_UpdateDeleteEventMusicianEventId.Size = new System.Drawing.Size(379, 26);
            this.textBox_UpdateDeleteEventMusicianEventId.TabIndex = 5;
            // 
            // UpdateOrDeleteEventMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 842);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_UpdateDeleteEventMusicianEventId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UpdateEventMusicianEventDate);
            this.Controls.Add(this.btn_UpdateMusicianList);
            this.Controls.Add(this.btn_DeleteMusicianFromList);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateOrDeleteEventMusician";
            this.Text = "UpdateOrDeleteEventMusician";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox AssignedMusicians;
        private System.Windows.Forms.Button btn_DeleteMusicianFromList;
        private System.Windows.Forms.Button btn_UpdateMusicianList;
        public System.Windows.Forms.TextBox textBox_UpdateEventMusicianEventDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_UpdateDeleteEventMusicianEventId;
    }
}