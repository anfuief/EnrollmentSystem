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
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Server2\second semester 2023-2024\LAB802\79286_CC_APPSDEV22_1030_1230_PM_MW\79286-23215130\Desktop\FINALS\Alvarado.accdb";

        public SubjectEntry()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Txt(SubjectCodeTextBox.Text))
            {
                MessageBox.Show("Subject Code Text Only");
            }

            if (!Txt(DescriptionTextBox.Text))
            {
                MessageBox.Show("Desciption Text Only");
            }

            if (!Num(UnitsTextBox.Text))
            {
                MessageBox.Show("Units Number Only");
            }

            if (!Num(CurriculumYearTextBox.Text))
            {
                MessageBox.Show("Curriculum Year Number Only ");
            }

            if (!Txt(RequisiteTextBox.Text))
            {
                MessageBox.Show("Requisite Code Text Onlyy");
            }
            
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

            if(PreRadioButton.Checked || CoRadioButton.Checked && RequisiteTextBox.Text != string.Empty)
            {
                Requisite();
            }

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
                    if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())
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

                OleDbConnection reqConnection = new OleDbConnection(connectionString);
                reqConnection.Open();
                OleDbCommand reqCommand = thisConnection.CreateCommand();

                string sqlreq = "Select * From SubjectPreqFile";
                reqCommand.CommandText = sqlreq;

                OleDbDataReader reqDataRead = reqCommand.ExecuteReader();
                while (reqDataRead.Read())
                {
                    if (reqDataRead["SUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())
                    {
                        SubjectDataGridView.Rows[0].Cells[3].Value = reqDataRead["SUBJPRECODE"].ToString().Trim().ToUpper();
                        break;
                    }
                    else
                        SubjectDataGridView.Rows[0].Cells[3].Value = string.Empty;
                }

            }
        }

        public void Requisite()
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "Select * From SubjectPreqFile";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();

            thisAdapter.Fill(thisDataSet, "SubjectPreqFile");

            DataRow thisRow = thisDataSet.Tables["SubjectPreqFile"].NewRow();
            thisRow["SUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SUBJPRECODE"] = RequisiteTextBox.Text;

            if (PreRadioButton.Checked)
            {
                thisRow["SUBJCATEGORY"] = "PR";
            }
            else
            {
                thisRow["SUBJCATEGORY"] = "CR";
            }

            thisDataSet.Tables["SubjectPreqFile"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SubjectPreqFile");

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SubjectScheduleEntry form = new SubjectScheduleEntry();
            form.Show();
            this.Hide();
        }

        private bool Txt(string text)
        {
            return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
        }

        private bool Num(string text)
        {
            return !string.IsNullOrEmpty(text) && text.All(char.IsDigit);
        }
    }
}
