using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;

namespace Attendance_System_Manager
{
    public partial class attendancePage : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();

        public attendancePage()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public string QRcodeString;


        private void attendancePage_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                comboBox1.Items.Add(Device.Name);
            comboBox1.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            button2.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            button2.Visible = true;
            button3.Visible = true;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        string temp = "...";
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
            {
                txtdecodedCODE.Text = result.ToString();
                QRcodeString = txtdecodedCODE.Text;
                if (temp != txtdecodedCODE.Text)
                {
                    Console.Beep(5000, 1000);
                    Display_PersonData();
                }
                temp = txtdecodedCODE.Text;
            }
        }

        private void attendancePage_FormClosing(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
            timer1.Stop();
            txtdecodedCODE.Text = "...";
            button2.Visible = false;
            button3.Visible = false;
            pictureBox1.Image = null;
        }

        //Database via QRCode is access function
        void Display_PersonData()
        {
            flag.Text = "false";
            try
            {
                //Date and Time
                string date = DateTime.Now.ToLongDateString();  //full date
                string time = DateTime.Now.ToLongTimeString();  //time
                DateTime dt = DateTime.Now;
                string mm = dt.ToString("MMMM");         //month i.e. November
                string yyyy = DateTime.Now.Year.ToString(); //year  i.e. 2019
                string dd = DateTime.Now.ToString("dd");    //Date  i.e. 18
                
                //Display Data
                OleDbCommand command = new OleDbCommand("Select * From Records_Table Where ID = '" + txtdecodedCODE.Text + "'", connection);
                connection.Open();
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
                    Labeldatetime.Text = date + "  " + time;
                }
                connection.Close();

                OleDbCommand command2 = new OleDbCommand("Select count(*) from Records_Table where id = '"+ txtdecodedCODE.Text + "'", connection);
                connection.Open();
                int count = (int)command2.ExecuteScalar();
                if (count > 0)
                {
                    flag.Text = "true";
                }
                connection.Close();


                //Write to Attendance Table
                if (flag.Text == "true")
                {
                    string attendance_ID = txtdecodedCODE.Text + " CurrentDate:" + date;
                    OleDbCommand command1 = new OleDbCommand("insert into Attendance_Table (KeyID, ID, Time_A, Date_A, Date_dd, Date_mm, Date_yyyy) values ('" + attendance_ID + "', '" + txtdecodedCODE.Text + "', '" + time + "', '" + date + "', '" + dd + "', '" + mm + "', '" + yyyy + "' )", connection);
                    connection.Open();
                    command1.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("RECORD NOT FOUND");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ALREADY MARKED ATTENDANCE OF TODAY");
                connection.Close();
            }
        }

        //Convert byte to picture
        private Image LoadPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }


        private void Manual_Attendance_Click(object sender, EventArgs e)
        {
            Manual_Attendance obj = new Manual_Attendance();
            obj.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
