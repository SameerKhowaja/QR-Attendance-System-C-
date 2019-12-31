namespace Attendance_System_Manager
{
    partial class Manual_Attendance
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
            this.label11 = new System.Windows.Forms.Label();
            this.IDCollections = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.markAttendance = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Labeldatetime = new System.Windows.Forms.Label();
            this.ques = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(12, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Find ID";
            // 
            // IDCollections
            // 
            this.IDCollections.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IDCollections.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IDCollections.Font = new System.Drawing.Font("Bell MT", 15.75F);
            this.IDCollections.FormattingEnabled = true;
            this.IDCollections.ItemHeight = 25;
            this.IDCollections.Location = new System.Drawing.Point(109, 24);
            this.IDCollections.Name = "IDCollections";
            this.IDCollections.Size = new System.Drawing.Size(492, 33);
            this.IDCollections.Sorted = true;
            this.IDCollections.TabIndex = 0;
            this.IDCollections.SelectedIndexChanged += new System.EventHandler(this.IDCollections_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Login Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.phoneLabel);
            this.panel2.Controls.Add(this.dobLabel);
            this.panel2.Controls.Add(this.genderLabel);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.surnameLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(17, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 380);
            this.panel2.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(230, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 27);
            this.label15.TabIndex = 33;
            this.label15.Text = "Date of Birth:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(9, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 32;
            this.label13.Text = "Phone No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(9, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 29;
            this.label6.Text = "Gender: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.White;
            this.addressLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.addressLabel.ForeColor = System.Drawing.Color.Black;
            this.addressLabel.Location = new System.Drawing.Point(9, 327);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(27, 27);
            this.addressLabel.TabIndex = 28;
            this.addressLabel.Text = "...";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.White;
            this.emailLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(9, 160);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(27, 27);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "...";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.White;
            this.phoneLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(9, 217);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(27, 27);
            this.phoneLabel.TabIndex = 28;
            this.phoneLabel.Text = "...";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.White;
            this.dobLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.dobLabel.ForeColor = System.Drawing.Color.Black;
            this.dobLabel.Location = new System.Drawing.Point(230, 272);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(27, 27);
            this.dobLabel.TabIndex = 28;
            this.dobLabel.Text = "...";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.White;
            this.genderLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.genderLabel.ForeColor = System.Drawing.Color.Black;
            this.genderLabel.Location = new System.Drawing.Point(9, 272);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(27, 27);
            this.genderLabel.TabIndex = 28;
            this.genderLabel.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(9, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 27);
            this.label17.TabIndex = 27;
            this.label17.Text = "Surname:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.White;
            this.surnameLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.surnameLabel.ForeColor = System.Drawing.Color.Black;
            this.surnameLabel.Location = new System.Drawing.Point(9, 107);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(27, 27);
            this.surnameLabel.TabIndex = 22;
            this.surnameLabel.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Full Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("Bell MT", 18F);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(9, 52);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(27, 27);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "...";
            // 
            // markAttendance
            // 
            this.markAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.markAttendance.FlatAppearance.BorderSize = 0;
            this.markAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markAttendance.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markAttendance.Image = global::Attendance_System_Manager.Properties.Resources.ok_48px;
            this.markAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.markAttendance.Location = new System.Drawing.Point(349, 464);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(252, 56);
            this.markAttendance.TabIndex = 1;
            this.markAttendance.Text = "   Mark Attendance";
            this.markAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.markAttendance.UseVisualStyleBackColor = false;
            this.markAttendance.Click += new System.EventHandler(this.markAttendance_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(423, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(141, 169);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 26;
            this.pictureBox.TabStop = false;
            // 
            // Labeldatetime
            // 
            this.Labeldatetime.AutoSize = true;
            this.Labeldatetime.BackColor = System.Drawing.Color.White;
            this.Labeldatetime.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeldatetime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Labeldatetime.Location = new System.Drawing.Point(24, 467);
            this.Labeldatetime.Name = "Labeldatetime";
            this.Labeldatetime.Size = new System.Drawing.Size(21, 19);
            this.Labeldatetime.TabIndex = 39;
            this.Labeldatetime.Text = "...";
            // 
            // ques
            // 
            this.ques.AutoSize = true;
            this.ques.BackColor = System.Drawing.Color.White;
            this.ques.Font = new System.Drawing.Font("Bell MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ques.Location = new System.Drawing.Point(24, 491);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(21, 19);
            this.ques.TabIndex = 39;
            this.ques.Text = "...";
            // 
            // Manual_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 524);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.Labeldatetime);
            this.Controls.Add(this.markAttendance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.IDCollections);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Manual_Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manually Attendance";
            this.Load += new System.EventHandler(this.Manual_Attendance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox IDCollections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button markAttendance;
        private System.Windows.Forms.Label Labeldatetime;
        private System.Windows.Forms.Label ques;
    }
}