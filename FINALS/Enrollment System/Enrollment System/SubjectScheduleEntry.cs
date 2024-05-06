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
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\Server2\\second semester 2023-2024\\LAB802\\79286_CC_APPSDEV22_1030_1230_PM_MW\\79286-23215130\\Desktop\\FINALS\\Alvarado.accdb\"";
        public SubjectScheduleEntry()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "Select * From SubjectSchedFile";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            
            thisAdapter.Fill(thisDataSet, "SubjectSchedFile");
            DataRow thisRow = thisDataSet.Tables["SubjectSchedFile"].NewRow();
            thisRow["SFSUBJCODE"] = Convert.ToInt16(EDPCodeTextBox.Text);
            thisRow["SSFSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SSFSTARTTIME"] = StartTimeDateTimePicker.Text;
            thisRow["SSFENDTIME"] = EndTimeDateTimePicker;
            thisRow["SSFDAYS"] = DaysTextBox;
            thisRow["SSFROOM"] = SectionTextBox;
            thisRow["SSFMAXSIZE"] = RoomTextBox;
            thisRow["SSFCLASSSIZE"] = SectionTextBox;
            thisRow["SFSUBJREGOFRNG"] = AMComboBox.Text.Substring(0, 1); 

            thisDataSet.Tables["SubjectSchedFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectSchedFile");

            MessageBox.Show("Recorded");

            







        }

        private void SubjectCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
