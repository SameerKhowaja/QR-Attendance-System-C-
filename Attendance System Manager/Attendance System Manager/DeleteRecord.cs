using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;

namespace Attendance_System_Manager
{
    public partial class DeleteRecord : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public DeleteRecord()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        //Fetch Data
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("Select * From Records_Table Where ID = '" + txtQR.Text + "'", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String Name = reader["Full_Name"].ToString();
                    String Surname = reader["Surname"].ToString();

                    txtName.Text = Name + " " + Surname;
                    //reading picture from byte in db
                    pictureBox.Image = LoadPhoto((byte[])reader["PictureBox"]);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
                connection.Close();
            }
        }

        //Convert byte to picture
        private Image LoadPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        //Form Load
        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            connection.Open();
            checkConnection.Text = "Connected to Database...";
            connection.Close();
        }

        //Clear btn
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = txtQR.Text = "";
            pictureBox.Image = null;
        }

        //Delete btn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string Query = "DELETE FROM Records_Table WHERE ID = '" + txtQR.Text + "' ";
                    command.CommandText = Query;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    connection.Close();

                    //Refresh
                    txtName.Text = txtQR.Text = "";
                    pictureBox.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter ID first");
            } 
        }


    }
}
