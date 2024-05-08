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
    public partial class SubjectEntry : Form
    {
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\Server2\second semester 2023-2024\LAB802\79286_CC_APPSDEV22_1030_1230_PM_MW\79286-23215130\Desktop\FINALS\Alvarado.accdb";
        public SubjectEntry()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "Select * From SubjectFile";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
            thisRow["SFSUBJCODE"] =SubjectCodeTextBox.Text;
            thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
            thisRow["SFSUBJUNITS"] = UnitsTextBox.Text;
            thisRow["SFSUBJREGOFRNG"] = OfferingComboBox.Text.Substring(0, 1);
            thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 1);
            thisRow["SFSUBJSTATUS"] = "AC";
            thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
            thisRow["SFSUBJCURRCODE"] = CurriculumYearTextBox.Text;
                           
            thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");

            MessageBox.Show("Recorded");
        }

        private void RequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();
                //
                bool found = false;
                string subjectcode = "";
                string description = "";
                string units = "";

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SFSSUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectcode = thisDataReader["SFSUBJCODE"].ToString();
                        description = thisDataReader["SFSUBJDESC"].ToString();
                        units = thisDataReader["SFSUBJUNITS"].ToString() ;
                        break;
                    }

                }
                if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                else
                {
                    SubjectDataGridView.Rows[0].Cells[0].Value = subjectcode;
                    SubjectDataGridView.Rows[0].Cells[1].Value = description;
                    SubjectDataGridView.Rows[0].Cells[2].Value = units;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntry form = new SubjectScheduleEntry();
            form.Show();
            this.Hide();
        }
    }
}
