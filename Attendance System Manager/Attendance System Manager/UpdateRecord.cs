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
using Attendance_System_Manager.Properties;

namespace Attendance_System_Manager
{
    public partial class UpdateRecord : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command1;

        public UpdateRecord()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        //form load
        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            connection.Open();
            checkConnection.Text = "Connected to Database...";
            connection.Close();
        }

        //Update Record
        private void btn_UpdateRecord_Click(object sender, EventArgs e)
        {
            if (txtFullNameNEW.Text != "" && txtSurname.Text != "" && txtPhoneNEW.Text != "" && txtAddressNEW.Text != "" && txtEmailNEW.Text != "")
            {
                if (MessageBox.Show("Sure?", "ARE YOU CONFIRM?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        //Delete Old Record
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        string Query = "DELETE FROM Records_Table WHERE ID = '" + txtQR.Text + "' ";
                        command.CommandText = Query;
                        command.ExecuteNonQuery();
                        connection.Close();

                        //Insert Again
                        command1 = new OleDbCommand("insert into Records_Table (ID, Full_Name, Surname, Email, Gender, DateOfBirth, Phone_No, Address, PictureBox) values ('" + txtdupID.Text + "', '" + txtFullNameNEW.Text + "', '" + txtSurname.Text + "', '" + txtEmailNEW.Text + "', '" + txtGenderNEW.Text + "', '" + txtDOBNEW.Text + "', '" + txtPhoneNEW.Text + "', '" + txtAddressNEW.Text + "', @PictureBox)", connection);
                        conv_photo();
                        connection.Open();
                        command1.ExecuteNonQuery();
                        MessageBox.Show("Data Updated");
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message: " + ex);
                        connection.Close();
                    }
                }
            }
        }

        //Conversion to Byte
        void conv_photo()
        {
            //converting photo to binary data
            if (pictureBox.Image != null)
            {
                //using MemoryStream:
                MemoryStream ms = new MemoryStream();
                pictureBox.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                command1.Parameters.AddWithValue("@PictureBox", photo_aray);
            }
        }

        //Load Data
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand("Select * From Records_Table Where ID = '"+ txtQR.Text +"'", connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtFullNameNEW.Text = reader["Full_Name"].ToString();
                    txtSurname.Text = reader["Surname"].ToString();
                    txtEmailNEW.Text = reader["Email"].ToString();
                    txtPhoneNEW.Text = reader["Phone_No"].ToString();
                    txtAddressNEW.Text = reader["Address"].ToString();
                    txtGenderNEW.Text = reader["Gender"].ToString();
                    txtDOBNEW.Text = reader["DateOfBirth"].ToString();
                    txtdupID.Text = txtQR.Text;
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

        //img load
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
            }
        }

        //Clear btn
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmailNEW.Text=txtFullNameNEW.Text=txtPhoneNEW.Text=txtSurname.Text=txtQR.Text=txtAddressNEW.Text="";
            pictureBox.Image = null;
        }

        //Mobile Constraint
        private void txtPhoneNEW_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNEW.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhoneNEW.Text = txtPhoneNEW.Text.Remove(txtPhoneNEW.Text.Length - 1);
            }
            if (txtPhoneNEW.TextLength > 11)
            {
                MessageBox.Show("Length error");
                txtPhoneNEW.Text = txtPhoneNEW.Text.Remove(txtPhoneNEW.Text.Length - 1);
            }
        }
    }
}
