using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System_Manager
{
    public partial class Form1 : Form
    {
        welcomePage welcome = new welcomePage();
        public Form1()
        {
            InitializeComponent();
            
            welcome.Dock = DockStyle.Fill;
            ScreenPanel.Controls.Add(welcome);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datetimeTimer.Start();
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void datetimeTimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            datetimeTimer.Start();
        }

        
        attendancePage attendance = new attendancePage();
        qrCodeGenerator qrCode = new qrCodeGenerator();
        ManageCRUDPage crud = new ManageCRUDPage();
        ViewAllRecords viewRec = new ViewAllRecords();
        SearchRecord search = new SearchRecord();

        private void AttendancePage_Click(object sender, EventArgs e)
        {
            sidePanel.Height = AttendancePagebtn.Height;
            sidePanel.Top = AttendancePagebtn.Top;

            welcome.Hide();
            qrCode.Hide();
            crud.Hide();
            viewRec.Hide();
            search.Hide();
            attendance.Show();
            attendance.Dock = DockStyle.Fill;
            ScreenPanel.Controls.Add(attendance);
        }

        private void ManageRecord_Click(object sender, EventArgs e)
        {
            sidePanel.Height = ManageRecordbtn.Height;
            sidePanel.Top = ManageRecordbtn.Top;

            welcome.Hide();
            qrCode.Hide();
            attendance.Hide();
            search.Hide();
            viewRec.Hide();
            crud.Show();
            crud.Dock = DockStyle.Fill;
            ScreenPanel.Controls.Add(crud);
        }

        private void SearchRecord_Click(object sender, EventArgs e)
        {
            sidePanel.Height = SearchRecordbtn.Height;
            sidePanel.Top = SearchRecordbtn.Top;

            welcome.Hide();
            qrCode.Hide();
            attendance.Hide();
            viewRec.Hide();
            crud.Hide();
            search.Show();
            search.Dock = DockStyle.Fill;
            ScreenPanel.Controls.Add(search);
        }

        private void QRCodeGenerator_Click(object sender, EventArgs e)
        {
            sidePanel.Height = QRCodeGeneratorbtn.Height;
            sidePanel.Top = QRCodeGeneratorbtn.Top;

            welcome.Hide();
            attendance.Hide();
            crud.Hide();
            viewRec.Hide();
            search.Hide();
            qrCode.Show();
            qrCode.Dock = DockStyle.Fill;
            ScreenPanel.Controls.Add(qrCode);
        }

        private void ViewRecordbtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = ViewRecordbtn.Height;
            sidePanel.Top = ViewRecordbtn.Top;

            welcome.Hide();
            attendance.Hide();
            crud.Hide();
            search.Hide();
            qrCode.Hide();
            viewRec.Show();
            viewRec.Dock = DockStyle.Fill;
            ScreenPanel.Controls.Add(viewRec);
        }



    }
}
