
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AllAssignMusicianToEvent = new System.Windows.Forms.DataGridView();
            this.btn_DeleteMusicianFromList = new System.Windows.Forms.Button();
            this.btn_UpdateMusicianList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AddMusciansToEvent = new System.Windows.Forms.DataGridView();
            this.label_UpdateEventMusicianEventDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllAssignMusicianToEvent)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddMusciansToEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_AllAssignMusicianToEvent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(579, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assigned to the event";
            // 
            // dataGridView_AllAssignMusicianToEvent
            // 
            this.dataGridView_AllAssignMusicianToEvent.AllowUserToAddRows = false;
            this.dataGridView_AllAssignMusicianToEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllAssignMusicianToEvent.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AllAssignMusicianToEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_AllAssignMusicianToEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllAssignMusicianToEvent.EnableHeadersVisualStyles = false;
            this.dataGridView_AllAssignMusicianToEvent.Location = new System.Drawing.Point(0, 35);
            this.dataGridView_AllAssignMusicianToEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_AllAssignMusicianToEvent.Name = "dataGridView_AllAssignMusicianToEvent";
            this.dataGridView_AllAssignMusicianToEvent.RowHeadersWidth = 51;
            this.dataGridView_AllAssignMusicianToEvent.RowTemplate.Height = 24;
            this.dataGridView_AllAssignMusicianToEvent.Size = new System.Drawing.Size(579, 389);
            this.dataGridView_AllAssignMusicianToEvent.TabIndex = 0;
            // 
            // btn_DeleteMusicianFromList
            // 
            this.btn_DeleteMusicianFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_DeleteMusicianFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteMusicianFromList.Location = new System.Drawing.Point(151, 576);
            this.btn_DeleteMusicianFromList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteMusicianFromList.Name = "btn_DeleteMusicianFromList";
            this.btn_DeleteMusicianFromList.Size = new System.Drawing.Size(340, 71);
            this.btn_DeleteMusicianFromList.TabIndex = 1;
            this.btn_DeleteMusicianFromList.Text = "Delete Musician(s) from event";
            this.btn_DeleteMusicianFromList.UseVisualStyleBackColor = false;
            this.btn_DeleteMusicianFromList.Click += new System.EventHandler(this.btn_DeleteMusicianFromList_Click);
            // 
            // btn_UpdateMusicianList
            // 
            this.btn_UpdateMusicianList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_UpdateMusicianList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateMusicianList.Location = new System.Drawing.Point(811, 576);
            this.btn_UpdateMusicianList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UpdateMusicianList.Name = "btn_UpdateMusicianList";
            this.btn_UpdateMusicianList.Size = new System.Drawing.Size(303, 71);
            this.btn_UpdateMusicianList.TabIndex = 2;
            this.btn_UpdateMusicianList.Text = "Add musician(s) to event";
            this.btn_UpdateMusicianList.UseVisualStyleBackColor = false;
            this.btn_UpdateMusicianList.Click += new System.EventHandler(this.btn_UpdateMusicianList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_AddMusciansToEvent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(638, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(626, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Musician to add to the event";
            // 
            // dataGridView_AddMusciansToEvent
            // 
            this.dataGridView_AddMusciansToEvent.AllowUserToAddRows = false;
            this.dataGridView_AddMusciansToEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AddMusciansToEvent.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AddMusciansToEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_AddMusciansToEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddMusciansToEvent.EnableHeadersVisualStyles = false;
            this.dataGridView_AddMusciansToEvent.Location = new System.Drawing.Point(0, 35);
            this.dataGridView_AddMusciansToEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_AddMusciansToEvent.Name = "dataGridView_AddMusciansToEvent";
            this.dataGridView_AddMusciansToEvent.RowHeadersWidth = 51;
            this.dataGridView_AddMusciansToEvent.RowTemplate.Height = 24;
            this.dataGridView_AddMusciansToEvent.Size = new System.Drawing.Size(626, 389);
            this.dataGridView_AddMusciansToEvent.TabIndex = 0;
            // 
            // label_UpdateEventMusicianEventDate
            // 
            this.label_UpdateEventMusicianEventDate.AutoSize = true;
            this.label_UpdateEventMusicianEventDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_UpdateEventMusicianEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UpdateEventMusicianEventDate.Location = new System.Drawing.Point(474, 48);
            this.label_UpdateEventMusicianEventDate.Name = "label_UpdateEventMusicianEventDate";
            this.label_UpdateEventMusicianEventDate.Size = new System.Drawing.Size(104, 46);
            this.label_UpdateEventMusicianEventDate.TabIndex = 7;
            this.label_UpdateEventMusicianEventDate.Text = "Date";
            this.label_UpdateEventMusicianEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateOrDeleteEventMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 674);
            this.Controls.Add(this.label_UpdateEventMusicianEventDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_UpdateMusicianList);
            this.Controls.Add(this.btn_DeleteMusicianFromList);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateOrDeleteEventMusician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Delete Musicians From event";
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
        private System.Windows.Forms.DataGridView dataGridView_AllAssignMusicianToEvent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_AddMusciansToEvent;
        private System.Windows.Forms.Label label_UpdateEventMusicianEventDate;
    }
}