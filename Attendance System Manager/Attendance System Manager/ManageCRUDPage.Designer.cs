namespace Attendance_System_Manager
{
    partial class ManageCRUDPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRUDsidePanel = new System.Windows.Forms.Panel();
            this.CRUDscreenPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteRecordbtn = new System.Windows.Forms.Button();
            this.updateRecordbtn = new System.Windows.Forms.Button();
            this.addRecordbtn = new System.Windows.Forms.Button();
            this.CRUDscreenPanel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.CRUDsidePanel);
            this.panel1.Controls.Add(this.CRUDscreenPanel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deleteRecordbtn);
            this.panel1.Controls.Add(this.updateRecordbtn);
            this.panel1.Controls.Add(this.addRecordbtn);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 555);
            this.panel1.TabIndex = 0;
            // 
            // CRUDsidePanel
            // 
            this.CRUDsidePanel.BackColor = System.Drawing.Color.Crimson;
            this.CRUDsidePanel.Location = new System.Drawing.Point(0, 127);
            this.CRUDsidePanel.Name = "CRUDsidePanel";
            this.CRUDsidePanel.Size = new System.Drawing.Size(11, 73);
            this.CRUDsidePanel.TabIndex = 7;
            // 
            // CRUDscreenPanel
            // 
            this.CRUDscreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRUDscreenPanel.Location = new System.Drawing.Point(252, 4);
            this.CRUDscreenPanel.Margin = new System.Windows.Forms.Padding(1);
            this.CRUDscreenPanel.Name = "CRUDscreenPanel";
            this.CRUDscreenPanel.Size = new System.Drawing.Size(668, 510);
            this.CRUDscreenPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU BAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "MANAGE RECORD";
            // 
            // deleteRecordbtn
            // 
            this.deleteRecordbtn.FlatAppearance.BorderSize = 0;
            this.deleteRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecordbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRecordbtn.Image = global::Attendance_System_Manager.Properties.Resources.delete_40px;
            this.deleteRecordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteRecordbtn.Location = new System.Drawing.Point(9, 285);
            this.deleteRecordbtn.Name = "deleteRecordbtn";
            this.deleteRecordbtn.Size = new System.Drawing.Size(241, 73);
            this.deleteRecordbtn.TabIndex = 2;
            this.deleteRecordbtn.Text = "  DELETE RECORD";
            this.deleteRecordbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteRecordbtn.UseVisualStyleBackColor = true;
            this.deleteRecordbtn.Click += new System.EventHandler(this.deleteRecordbtn_Click);
            // 
            // updateRecordbtn
            // 
            this.updateRecordbtn.FlatAppearance.BorderSize = 0;
            this.updateRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRecordbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateRecordbtn.Image = global::Attendance_System_Manager.Properties.Resources.renew_subscription_40px;
            this.updateRecordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateRecordbtn.Location = new System.Drawing.Point(9, 206);
            this.updateRecordbtn.Name = "updateRecordbtn";
            this.updateRecordbtn.Size = new System.Drawing.Size(241, 73);
            this.updateRecordbtn.TabIndex = 1;
            this.updateRecordbtn.Text = "  UPDATE RECORD";
            this.updateRecordbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateRecordbtn.UseVisualStyleBackColor = true;
            this.updateRecordbtn.Click += new System.EventHandler(this.updateRecordbtn_Click);
            // 
            // addRecordbtn
            // 
            this.addRecordbtn.FlatAppearance.BorderSize = 0;
            this.addRecordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecordbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecordbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRecordbtn.Image = global::Attendance_System_Manager.Properties.Resources.add_file_40px;
            this.addRecordbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRecordbtn.Location = new System.Drawing.Point(9, 127);
            this.addRecordbtn.Name = "addRecordbtn";
            this.addRecordbtn.Size = new System.Drawing.Size(241, 73);
            this.addRecordbtn.TabIndex = 0;
            this.addRecordbtn.Text = "  ADD RECORD";
            this.addRecordbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addRecordbtn.UseVisualStyleBackColor = true;
            this.addRecordbtn.Click += new System.EventHandler(this.addRecordbtn_Click);
            // 
            // CRUDscreenPanel1
            // 
            this.CRUDscreenPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRUDscreenPanel1.Location = new System.Drawing.Point(252, 0);
            this.CRUDscreenPanel1.Name = "CRUDscreenPanel1";
            this.CRUDscreenPanel1.Size = new System.Drawing.Size(669, 548);
            this.CRUDscreenPanel1.TabIndex = 1;
            // 
            // ManageCRUDPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.CRUDscreenPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCRUDPage";
            this.Size = new System.Drawing.Size(921, 542);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addRecordbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteRecordbtn;
        private System.Windows.Forms.Button updateRecordbtn;
        private System.Windows.Forms.Panel CRUDsidePanel;
        private System.Windows.Forms.Panel CRUDscreenPanel;
        private System.Windows.Forms.Panel CRUDscreenPanel1;
    }
}
