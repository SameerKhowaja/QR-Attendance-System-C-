namespace Attendance_System_Manager
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.ViewRecordbtn = new System.Windows.Forms.Button();
            this.QRCodeGeneratorbtn = new System.Windows.Forms.Button();
            this.SearchRecordbtn = new System.Windows.Forms.Button();
            this.ManageRecordbtn = new System.Windows.Forms.Button();
            this.AttendancePagebtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimeTimer = new System.Windows.Forms.Timer(this.components);
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.Question);
            this.panel1.Controls.Add(this.ViewRecordbtn);
            this.panel1.Controls.Add(this.QRCodeGeneratorbtn);
            this.panel1.Controls.Add(this.SearchRecordbtn);
            this.panel1.Controls.Add(this.ManageRecordbtn);
            this.panel1.Controls.Add(this.AttendancePagebtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 623);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Crimson;
            this.sidePanel.Location = new System.Drawing.Point(1, 41);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(11, 73);
            this.sidePanel.TabIndex = 3;
            // 
            // About
            // 
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.About.Image = global::Attendance_System_Manager.Properties.Resources.about_26px;
            this.About.Location = new System.Drawing.Point(57, 574);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(42, 43);
            this.About.TabIndex = 6;
            this.About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.About.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.Question.FlatAppearance.BorderSize = 0;
            this.Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Question.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Question.Image = global::Attendance_System_Manager.Properties.Resources.help_26px;
            this.Question.Location = new System.Drawing.Point(9, 574);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(42, 43);
            this.Question.TabIndex = 5;
            this.Question.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Question.UseVisualStyleBackColor = true;
            // 
            // ViewRecordbtn
            // 
            this.ViewRecordbtn.FlatAppearance.BorderSize = 0;
            this.ViewRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewRecordbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewRecordbtn.Image = global::Attendance_System_Manager.Properties.Resources.view_file_50px1;
            this.ViewRecordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRecordbtn.Location = new System.Drawing.Point(12, 288);
            this.ViewRecordbtn.Name = "ViewRecordbtn";
            this.ViewRecordbtn.Size = new System.Drawing.Size(249, 73);
            this.ViewRecordbtn.TabIndex = 2;
            this.ViewRecordbtn.Text = "  VIEW ALL RECORDS";
            this.ViewRecordbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewRecordbtn.UseVisualStyleBackColor = true;
            this.ViewRecordbtn.Click += new System.EventHandler(this.ViewRecordbtn_Click);
            // 
            // QRCodeGeneratorbtn
            // 
            this.QRCodeGeneratorbtn.FlatAppearance.BorderSize = 0;
            this.QRCodeGeneratorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QRCodeGeneratorbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRCodeGeneratorbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QRCodeGeneratorbtn.Image = global::Attendance_System_Manager.Properties.Resources.qr_code_64px;
            this.QRCodeGeneratorbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QRCodeGeneratorbtn.Location = new System.Drawing.Point(5, 446);
            this.QRCodeGeneratorbtn.Name = "QRCodeGeneratorbtn";
            this.QRCodeGeneratorbtn.Size = new System.Drawing.Size(256, 73);
            this.QRCodeGeneratorbtn.TabIndex = 4;
            this.QRCodeGeneratorbtn.Text = "QRCode GENERATOR";
            this.QRCodeGeneratorbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QRCodeGeneratorbtn.UseVisualStyleBackColor = true;
            this.QRCodeGeneratorbtn.Click += new System.EventHandler(this.QRCodeGenerator_Click);
            // 
            // SearchRecordbtn
            // 
            this.SearchRecordbtn.FlatAppearance.BorderSize = 0;
            this.SearchRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchRecordbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchRecordbtn.Image = global::Attendance_System_Manager.Properties.Resources.search_filled_50px;
            this.SearchRecordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchRecordbtn.Location = new System.Drawing.Point(12, 367);
            this.SearchRecordbtn.Name = "SearchRecordbtn";
            this.SearchRecordbtn.Size = new System.Drawing.Size(249, 73);
            this.SearchRecordbtn.TabIndex = 3;
            this.SearchRecordbtn.Text = "  SEARCH RECORD";
            this.SearchRecordbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchRecordbtn.UseVisualStyleBackColor = true;
            this.SearchRecordbtn.Click += new System.EventHandler(this.SearchRecord_Click);
            // 
            // ManageRecordbtn
            // 
            this.ManageRecordbtn.FlatAppearance.BorderSize = 0;
            this.ManageRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageRecordbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageRecordbtn.Image = global::Attendance_System_Manager.Properties.Resources.maintenance_50px;
            this.ManageRecordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageRecordbtn.Location = new System.Drawing.Point(12, 209);
            this.ManageRecordbtn.Name = "ManageRecordbtn";
            this.ManageRecordbtn.Size = new System.Drawing.Size(249, 73);
            this.ManageRecordbtn.TabIndex = 1;
            this.ManageRecordbtn.Text = "  MANAGE RECORD";
            this.ManageRecordbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageRecordbtn.UseVisualStyleBackColor = true;
            this.ManageRecordbtn.Click += new System.EventHandler(this.ManageRecord_Click);
            // 
            // AttendancePagebtn
            // 
            this.AttendancePagebtn.FlatAppearance.BorderSize = 0;
            this.AttendancePagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendancePagebtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendancePagebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AttendancePagebtn.Image = global::Attendance_System_Manager.Properties.Resources.overtime_50px;
            this.AttendancePagebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendancePagebtn.Location = new System.Drawing.Point(12, 130);
            this.AttendancePagebtn.Name = "AttendancePagebtn";
            this.AttendancePagebtn.Size = new System.Drawing.Size(249, 73);
            this.AttendancePagebtn.TabIndex = 0;
            this.AttendancePagebtn.Text = "  ATTENDANCE PAGE";
            this.AttendancePagebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AttendancePagebtn.UseVisualStyleBackColor = true;
            this.AttendancePagebtn.Click += new System.EventHandler(this.AttendancePage_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Attendance_System_Manager.Properties.Resources.attendancesystem;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(1, -6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 128);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 11);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Controls.Add(this.time);
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(261, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 97);
            this.panel3.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Image = global::Attendance_System_Manager.Properties.Resources.exit_100px1;
            this.Exit.Location = new System.Drawing.Point(865, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(49, 39);
            this.Exit.TabIndex = 0;
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button9_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time.Location = new System.Drawing.Point(821, 74);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(40, 20);
            this.time.TabIndex = 24;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.date.Location = new System.Drawing.Point(696, 54);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(45, 20);
            this.date.TabIndex = 3;
            this.date.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(237, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 79);
            this.label4.TabIndex = 23;
            this.label4.Text = "MANAGER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(206, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "ATTENDANCE SYSTEM";
            // 
            // datetimeTimer
            // 
            this.datetimeTimer.Enabled = true;
            this.datetimeTimer.Tick += new System.EventHandler(this.datetimeTimer_Tick);
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ScreenPanel.Controls.Add(this.panel5);
            this.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenPanel.Location = new System.Drawing.Point(261, 108);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(921, 515);
            this.ScreenPanel.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 11);
            this.panel5.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.ScreenPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ScreenPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AttendancePagebtn;
        private System.Windows.Forms.Button ViewRecordbtn;
        private System.Windows.Forms.Button QRCodeGeneratorbtn;
        private System.Windows.Forms.Button SearchRecordbtn;
        private System.Windows.Forms.Button ManageRecordbtn;
        private System.Windows.Forms.Button Question;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer datetimeTimer;
        private System.Windows.Forms.Panel ScreenPanel;
        private System.Windows.Forms.Panel panel5;
    }
}