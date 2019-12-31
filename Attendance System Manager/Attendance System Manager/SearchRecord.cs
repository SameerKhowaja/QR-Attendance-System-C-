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

namespace Attendance_System_Manager
{
    public partial class SearchRecord : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();

        public SearchRecord()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        //Form Loads
        private void SearchRecord_Load(object sender, EventArgs e)
        {
            Update_Combox();
        }

        //Update Combox
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
                MessageBox.Show("Error: " + ex);
            }
        }

        //ComboBox
        private void IDCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                OleDbCommand command1 = new OleDbCommand("Select count(*) from Attendance_Table where ID = '"+IDCollections.Text+"'", connection);
                connection.Open();
                int count = (int)command1.ExecuteScalar();
                DaysCount.Text = count.ToString();
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

        //Filter
        private void FilterSearch_Click(object sender, EventArgs e)
        {
            int Day1 = int.Parse(txtDay1.Text);
            int Day2 = int.Parse(txtDay2.Text);
            string Month = txtMonth.Text;
            int Year = int.Parse(txtYear.Text);

            //Conditions
            if (Day1 > Day2 || (Day1<1 || Day1>31) || (Day2<1 || Day2>31))
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                //IDCollections.Text
            }
        }


        //Number Constraint-----------------------------------------------------------
        private void txtDay1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDay1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtDay1.Text = txtDay1.Text.Remove(txtDay1.Text.Length - 1);
            }
            if (txtDay1.TextLength > 2)
            {
                MessageBox.Show("Length error");
                txtDay1.Text = txtDay1.Text.Remove(txtDay1.Text.Length - 1);
            }
        }

        private void txtDay2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDay2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtDay2.Text = txtDay2.Text.Remove(txtDay2.Text.Length - 1);
            }
            if (txtDay2.TextLength > 2)
            {
                MessageBox.Show("Length error");
                txtDay2.Text = txtDay2.Text.Remove(txtDay2.Text.Length - 1);
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtYear.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtYear.Text = txtYear.Text.Remove(txtYear.Text.Length - 1);
            }
            if (txtYear.TextLength > 4)
            {
                MessageBox.Show("Length error");
                txtYear.Text = txtYear.Text.Remove(txtYear.Text.Length - 1);
            }
        }
        //------------------------------------------------------------------------------

    }
}
