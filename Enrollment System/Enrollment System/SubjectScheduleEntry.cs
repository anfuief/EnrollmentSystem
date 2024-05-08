using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class SubjectScheduleEntry : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Server2\second semester 2023-2024\LAB802\79286_CC_APPSDEV22_1030_1230_PM_MW\79286-23215130\Desktop\FINALS\Alvarado.accdb";
        public SubjectScheduleEntry()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "Select * From SubjectScheduleFile";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            
            thisAdapter.Fill(thisDataSet, "SubjectScheduleFile");
            DataRow thisRow = thisDataSet.Tables["SubjectScheduleFile"].NewRow();
            thisRow["SSFSUBJCODE"] = EDPCodeTextBox.Text;
            thisRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SSFSTARTTIME"] = StartTimeDateTimePicker.Text;
            thisRow["SSFENDTIME"] = EndTimeDateTimePicker.Text;
            thisRow["SSFXM"] = AMComboBox.Text;
            thisRow["SSFDAYS"] = DaysTextBox.Text;
            thisRow["SSFSECTION"] = SectionTextBox.Text;
            thisRow["SSFROOM"] = RoomTextBox.Text;
            thisRow["SSFSCHOOLYEAR"] = SchoolYearTextBox.Text;

            thisDataSet.Tables["SubjectScheduleFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectScheduleFile");

            MessageBox.Show("Recorded");

        }


        private void SubjectCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM SubjectFile";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();
                bool found = false;
                string description = "";

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == SubjectCodeTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        description = thisDataReader["SFSUBJDESC"].ToString();
                    }
                    if (found)
                        DescriptionLabel.Text = description;
                }

                if (!found)
                    MessageBox.Show("Not Found");
                
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            SubjectEntry form = new SubjectEntry();
            form.Show();
            this.Hide();
        }
    }
}
