using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System_Manager
{
    public partial class ManageCRUDPage : UserControl
    {
        CreateRecord cr = new CreateRecord();
        UpdateRecord ur = new UpdateRecord();
        DeleteRecord dr = new DeleteRecord();

        public ManageCRUDPage()
        {
            InitializeComponent();

            CRUDsidePanel.Height = addRecordbtn.Height;
            CRUDsidePanel.Top = addRecordbtn.Top;

            ur.Hide();
            dr.Hide();
            cr.Show();
            cr.Dock = DockStyle.Fill;
            CRUDscreenPanel1.Controls.Add(cr);
        }

        private void addRecordbtn_Click(object sender, EventArgs e)
        {
            CRUDsidePanel.Height = addRecordbtn.Height;
            CRUDsidePanel.Top = addRecordbtn.Top;

            ur.Hide();
            dr.Hide();
            cr.Show();
            cr.Dock = DockStyle.Fill;
            CRUDscreenPanel1.Controls.Add(cr);
        }

        private void updateRecordbtn_Click(object sender, EventArgs e)
        {
            CRUDsidePanel.Height = updateRecordbtn.Height;
            CRUDsidePanel.Top = updateRecordbtn.Top;

            cr.Hide();
            dr.Hide();
            ur.Show();
            ur.Dock = DockStyle.Fill;
            CRUDscreenPanel1.Controls.Add(ur);
        }

        private void deleteRecordbtn_Click(object sender, EventArgs e)
        {
            CRUDsidePanel.Height = deleteRecordbtn.Height;
            CRUDsidePanel.Top = deleteRecordbtn.Top;

            ur.Hide();
            cr.Hide();
            dr.Show();
            dr.Dock = DockStyle.Fill;
            CRUDscreenPanel1.Controls.Add(dr);
        }
    }
}
