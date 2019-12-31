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
    public partial class CreateRecord : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;

        public CreateRecord()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        //Image Upload
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog ofd = new OpenFileDialog() {Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
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

        //Generating QR
        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != "" && txtDOB.Text != "" && ComboxGender.Text != "" && txtSurname.Text != "")
            {
                labelQRCode.Text = txtFullName.Text + txtDOB.Text + ComboxGender.Text + txtSurname.Text;
            }
            else
            {
                MessageBox.Show("Please Fill Form First.");
            }
        }

        //FormLoad
        private void CreateRecord_Load(object sender, EventArgs e)
        {
            connection.Open();
            checkConnection.Text = "Connected to Database...";
            connection.Close();
        }

        //Add Data to DataBase
        private void btn_AddRecord_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != "" && txtDOB.Text != "" && (ComboxGender.Text == "Male" || ComboxGender.Text == "Female") && txtSurname.Text != "" && txtPhone.Text != "" && txtAddress.Text !="" && txtEmail.Text != "")
            {
                if (MessageBox.Show("Sure?", "ARE YOU CONFIRM?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    labelQRCode.Text = txtFullName.Text + txtDOB.Text + ComboxGender.Text + txtSurname.Text;
                    try
                    {
                        long phone = long.Parse(txtPhone.Text);
                        command = new OleDbCommand("insert into Records_Table (ID, Full_Name, Surname, Email, Gender, DateOfBirth, Phone_No, Address, PictureBox) values ('" + labelQRCode.Text + "', '" + txtFullName.Text + "', '" + txtSurname.Text + "', '" + txtEmail.Text + "', '" + ComboxGender.Text + "', '" + txtDOB.Text + "', '" + phone + "', '" + txtAddress.Text + "', @PictureBox)", connection);
                        conv_photo();

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted");
                        connection.Close();

                        //Refresh
                        labelQRCode.Text = "...";
                        txtFullName.Text = "";
                        txtSurname.Text = "";
                        txtEmail.Text = "";
                        txtPhone.Text = "";
                        txtAddress.Text = "";
                        ComboxGender.Text = "";
                        Image myImage = Resources.noPhotoAvailable;
                        pictureBox.Image = myImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Message: " + ex);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill Form First.");
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
                command.Parameters.AddWithValue("@PictureBox", photo_aray);
            }
        }

        //Mobile Constraint
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
            }
            if (txtPhone.TextLength > 11)
            {
                MessageBox.Show("Length error");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
            }
        }

        


    }
}
