
namespace MongoDB
{
    partial class UpdateOrDeleteEvent
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
            this.label5 = new System.Windows.Forms.Label();
            this.TimePicker_EventTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EventDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.btn_UpdateEvent = new System.Windows.Forms.Button();
            this.btn_DeleteEvent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_EventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_EventMusicialtype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Time:";
            // 
            // TimePicker_EventTimeUpdate
            // 
            this.TimePicker_EventTimeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker_EventTimeUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_EventTimeUpdate.Location = new System.Drawing.Point(207, 294);
            this.TimePicker_EventTimeUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimePicker_EventTimeUpdate.Name = "TimePicker_EventTimeUpdate";
            this.TimePicker_EventTimeUpdate.ShowUpDown = true;
            this.TimePicker_EventTimeUpdate.Size = new System.Drawing.Size(144, 35);
            this.TimePicker_EventTimeUpdate.TabIndex = 23;
            // 
            // dateTimePicker_EventDateUpdate
            // 
            this.dateTimePicker_EventDateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_EventDateUpdate.Location = new System.Drawing.Point(207, 222);
            this.dateTimePicker_EventDateUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_EventDateUpdate.Name = "dateTimePicker_EventDateUpdate";
            this.dateTimePicker_EventDateUpdate.Size = new System.Drawing.Size(456, 35);
            this.dateTimePicker_EventDateUpdate.TabIndex = 22;
            // 
            // btn_UpdateEvent
            // 
            this.btn_UpdateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_UpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateEvent.Location = new System.Drawing.Point(366, 462);
            this.btn_UpdateEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_UpdateEvent.Name = "btn_UpdateEvent";
            this.btn_UpdateEvent.Size = new System.Drawing.Size(213, 39);
            this.btn_UpdateEvent.TabIndex = 21;
            this.btn_UpdateEvent.Text = "Update";
            this.btn_UpdateEvent.UseVisualStyleBackColor = false;
            this.btn_UpdateEvent.Click += new System.EventHandler(this.btn_UpdateEvent_Click);
            // 
            // btn_DeleteEvent
            // 
            this.btn_DeleteEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteEvent.Location = new System.Drawing.Point(109, 462);
            this.btn_DeleteEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteEvent.Name = "btn_DeleteEvent";
            this.btn_DeleteEvent.Size = new System.Drawing.Size(213, 39);
            this.btn_DeleteEvent.TabIndex = 20;
            this.btn_DeleteEvent.Text = "DELETE";
            this.btn_DeleteEvent.UseVisualStyleBackColor = false;
            this.btn_DeleteEvent.Click += new System.EventHandler(this.btn_DeleteEvent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date:";
            // 
            // textBox_EventName
            // 
            this.textBox_EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EventName.Location = new System.Drawing.Point(207, 99);
            this.textBox_EventName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_EventName.Name = "textBox_EventName";
            this.textBox_EventName.Size = new System.Drawing.Size(456, 39);
            this.textBox_EventName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Event Name:";
            // 
            // textBox_EventMusicialtype
            // 
            this.textBox_EventMusicialtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EventMusicialtype.Location = new System.Drawing.Point(207, 154);
            this.textBox_EventMusicialtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_EventMusicialtype.Name = "textBox_EventMusicialtype";
            this.textBox_EventMusicialtype.Size = new System.Drawing.Size(456, 39);
            this.textBox_EventMusicialtype.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Musical Type:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(207, 26);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(456, 39);
            this.textBox_ID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Event ID:";
            // 
            // UpdateOrDeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimePicker_EventTimeUpdate);
            this.Controls.Add(this.dateTimePicker_EventDateUpdate);
            this.Controls.Add(this.btn_UpdateEvent);
            this.Controls.Add(this.btn_DeleteEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_EventName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_EventMusicialtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateOrDeleteEvent";
            this.Text = "UpdateOrDeleteEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateEvent;
        private System.Windows.Forms.Button btn_DeleteEvent;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_EventName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_EventMusicialtype;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker_EventDateUpdate;
        public System.Windows.Forms.DateTimePicker TimePicker_EventTimeUpdate;
    }
}