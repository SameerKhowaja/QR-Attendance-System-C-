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

namespace Attendance_System_Manager
{
    public partial class ViewAllRecords : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();

        public ViewAllRecords()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PROJECTS\C# Work\Attendance System using QRcode\Attendance-System\Database\Database1.accdb;
Persist Security Info=False;";
        }

        private void ViewAllRecords_Load(object sender, EventArgs e)
        {
            UpdateDBGrid();

            //Count Records
            int Count = 0;
            Count = dataGridView.Rows.Count;
            recordCount.Text = Count.ToString();
        }

        private void UpdateDBGrid()
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string Query = "SELECT ID, Full_Name, Surname, Email, Gender, DateOfBirth, Phone_No, Address FROM Records_Table";
                command.CommandText = Query;
                command.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                connection.Close();
            }
        }

        //Refresh List
        private void RefreshList_Click(object sender, EventArgs e)
        {
            UpdateDBGrid();
            textBox1.Text = "";
            //Count Records
            int Count = 0;
            Count = dataGridView.Rows.Count;
            recordCount.Text = Count.ToString();
        }

        //Search
        private void textBox1_TextChanged(object sender, EventArgs e){
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string Query = "SELECT ID, Full_Name, Surname, Email, Gender, DateOfBirth, Phone_No, Address FROM Records_Table WHERE (Full_Name Like @name + '%')";
                command.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                command.CommandText = Query;
                command.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                connection.Close();
            }
        }
        

    }
}
