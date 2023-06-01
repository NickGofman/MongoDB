
namespace MongoDB
{
    partial class UpdateOrDeleteMusician
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
            this.btn_UpdateMusician = new System.Windows.Forms.Button();
            this.btn_DeleteMusician = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MusicianNameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MusicianAgeUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MusicianID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MusicianInstrumentUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_UpdateMusician
            // 
            this.btn_UpdateMusician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_UpdateMusician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateMusician.Location = new System.Drawing.Point(290, 362);
            this.btn_UpdateMusician.Name = "btn_UpdateMusician";
            this.btn_UpdateMusician.Size = new System.Drawing.Size(189, 31);
            this.btn_UpdateMusician.TabIndex = 21;
            this.btn_UpdateMusician.Text = "Update";
            this.btn_UpdateMusician.UseVisualStyleBackColor = false;
            this.btn_UpdateMusician.Click += new System.EventHandler(this.btn_UpdateMusician_Click);
            // 
            // btn_DeleteMusician
            // 
            this.btn_DeleteMusician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DeleteMusician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteMusician.ForeColor = System.Drawing.Color.Black;
            this.btn_DeleteMusician.Location = new System.Drawing.Point(62, 362);
            this.btn_DeleteMusician.Name = "btn_DeleteMusician";
            this.btn_DeleteMusician.Size = new System.Drawing.Size(189, 31);
            this.btn_DeleteMusician.TabIndex = 20;
            this.btn_DeleteMusician.Text = "DELETE";
            this.btn_DeleteMusician.UseVisualStyleBackColor = false;
            this.btn_DeleteMusician.Click += new System.EventHandler(this.btn_DeleteMusician_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Musician Instrument";
            // 
            // textBox_MusicianNameUpdate
            // 
            this.textBox_MusicianNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MusicianNameUpdate.Location = new System.Drawing.Point(203, 114);
            this.textBox_MusicianNameUpdate.Name = "textBox_MusicianNameUpdate";
            this.textBox_MusicianNameUpdate.Size = new System.Drawing.Size(319, 34);
            this.textBox_MusicianNameUpdate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Musician Name:";
            // 
            // textBox_MusicianAgeUpdate
            // 
            this.textBox_MusicianAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MusicianAgeUpdate.Location = new System.Drawing.Point(203, 186);
            this.textBox_MusicianAgeUpdate.Name = "textBox_MusicianAgeUpdate";
            this.textBox_MusicianAgeUpdate.Size = new System.Drawing.Size(319, 34);
            this.textBox_MusicianAgeUpdate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Musician Age:";
            // 
            // textBox_MusicianID
            // 
            this.textBox_MusicianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MusicianID.Location = new System.Drawing.Point(203, 41);
            this.textBox_MusicianID.Name = "textBox_MusicianID";
            this.textBox_MusicianID.ReadOnly = true;
            this.textBox_MusicianID.Size = new System.Drawing.Size(319, 34);
            this.textBox_MusicianID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Musician ID:";
            // 
            // textBox_MusicianInstrumentUpdate
            // 
            this.textBox_MusicianInstrumentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MusicianInstrumentUpdate.Location = new System.Drawing.Point(241, 260);
            this.textBox_MusicianInstrumentUpdate.Name = "textBox_MusicianInstrumentUpdate";
            this.textBox_MusicianInstrumentUpdate.Size = new System.Drawing.Size(281, 34);
            this.textBox_MusicianInstrumentUpdate.TabIndex = 22;
            // 
            // UpdateOrDeleteMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.textBox_MusicianInstrumentUpdate);
            this.Controls.Add(this.btn_UpdateMusician);
            this.Controls.Add(this.btn_DeleteMusician);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MusicianNameUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MusicianAgeUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MusicianID);
            this.Controls.Add(this.label1);
            this.Name = "UpdateOrDeleteMusician";
            this.Text = "UpdateOrDeleteMusician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_UpdateMusician;
        private System.Windows.Forms.Button btn_DeleteMusician;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_MusicianNameUpdate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_MusicianAgeUpdate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_MusicianID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_MusicianInstrumentUpdate;
    }
}