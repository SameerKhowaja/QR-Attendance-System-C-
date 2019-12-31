using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using Attendance_System_Manager.Properties;

namespace Attendance_System_Manager
{
    public partial class Manual_Attendance : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Manual_Attendance()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        //Page Load
        private void Manual_Attendance_Load(object sender, EventArgs e)
        {
            Update_Combox();
        }

        //combox > IDCollection
        private void IDCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDCollections.DropDownStyle = ComboBoxStyle.DropDownList;
            Labeldatetime.Text ="...";
            ques.Text = "...";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string Query = "SELECT * FROM Records_Table WHERE ID = '" + IDCollections.Text + "'";
                command.CommandText = Query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nameLabel.Text = reader["Full_Name"].ToString();
                    surnameLabel.Text = reader["Surname"].ToString();
                    emailLabel.Text = reader["Email"].ToString();
                    phoneLabel.Text = reader["Phone_No"].ToString();
                    genderLabel.Text = reader["Gender"].ToString();
                    dobLabel.Text = reader["DateOfBirth"].ToString();
                    addressLabel.Text = reader["Address"].ToString();
                    //reading picture from byte in db
                    pictureBox.Image = LoadPhoto((byte[])reader["PictureBox"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                connection.Close();
            }
        }

        //Convert byte to picture
        private Image LoadPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }


        //Update Combobox
        private void Update_Combox()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string Query = "SELECT * FROM Records_Table";
                command.CommandText = Query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IDCollections.Items.Add(reader["ID"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
        }

        private void markAttendance_Click(object sender, EventArgs e)
        {
            if (IDCollections.Text != "" && nameLabel.Text != "...")
            {
                try
                {
                    //Date and Time
                    string date = DateTime.Now.ToLongDateString();  //full date
                    string time = DateTime.Now.ToLongTimeString();  //time
                    DateTime dt = DateTime.Now;
                    string mm = dt.ToString("MMMM");         //month i.e. November
                    string yyyy = DateTime.Now.Year.ToString(); //year  i.e. 2019
                    string dd = DateTime.Now.ToString("dd");    //Date  i.e. 18

                    //Write to Attendance Table
                    string attendance_ID = IDCollections.Text + " CurrentDate:" + date;
                    OleDbCommand command1 = new OleDbCommand("insert into Attendance_Table (KeyID, ID, Time_A, Date_A, Date_dd, Date_mm, Date_yyyy) values ('" + attendance_ID + "', '" + IDCollections.Text + "', '" + time + "', '" + date + "', '" + dd + "', '" + mm + "', '" + yyyy + "' )", connection);
                    connection.Open();
                    command1.ExecuteNonQuery();
                    Labeldatetime.Text = date + "  " + time;
                    ques.Text = "Attendance Has Been Marked";
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ALREADY MARKED ATTENDANCE OF TODAY");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Data...");
            }

        }
    }
}
