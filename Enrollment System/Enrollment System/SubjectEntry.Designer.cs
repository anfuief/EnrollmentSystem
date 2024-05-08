namespace Enrollment_System
{
    partial class SubjectEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.OfferingComboBox = new System.Windows.Forms.ComboBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequisiteTextBox = new System.Windows.Forms.TextBox();
            this.CoRadioButton = new System.Windows.Forms.RadioButton();
            this.PreRadioButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CourseCodeComboBox);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.OfferingComboBox);
            this.groupBox1.Controls.Add(this.CurriculumYearTextBox);
            this.groupBox1.Controls.Add(this.UnitsTextBox);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.SubjectCodeTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSN",
            "BSIT",
            "BSIS"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(115, 158);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourseCodeComboBox.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "LEC",
            "LAB"});
            this.CategoryComboBox.Location = new System.Drawing.Point(115, 130);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 12;
            // 
            // OfferingComboBox
            // 
            this.OfferingComboBox.FormattingEnabled = true;
            this.OfferingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.OfferingComboBox.Location = new System.Drawing.Point(115, 101);
            this.OfferingComboBox.Name = "OfferingComboBox";
            this.OfferingComboBox.Size = new System.Drawing.Size(121, 21);
            this.OfferingComboBox.TabIndex = 11;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(115, 185);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurriculumYearTextBox.TabIndex = 10;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.Location = new System.Drawing.Point(115, 75);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.UnitsTextBox.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(115, 49);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(115, 26);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubjectCodeTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Curriculum Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Course Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Offering";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SubjectDataGridView);
            this.groupBox2.Controls.Add(this.RequisiteTextBox);
            this.groupBox2.Controls.Add(this.CoRadioButton);
            this.groupBox2.Controls.Add(this.PreRadioButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(343, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prerequisite Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.SubjectDataGridView.Location = new System.Drawing.Point(24, 130);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.Size = new System.Drawing.Size(389, 96);
            this.SubjectDataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subject Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Co/Pre";
            this.Column4.Name = "Column4";
            // 
            // RequisiteTextBox
            // 
            this.RequisiteTextBox.Location = new System.Drawing.Point(24, 76);
            this.RequisiteTextBox.Name = "RequisiteTextBox";
            this.RequisiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.RequisiteTextBox.TabIndex = 3;
            this.RequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RequisiteTextBox_KeyPress);
            // 
            // CoRadioButton
            // 
            this.CoRadioButton.AutoSize = true;
            this.CoRadioButton.Location = new System.Drawing.Point(169, 80);
            this.CoRadioButton.Name = "CoRadioButton";
            this.CoRadioButton.Size = new System.Drawing.Size(80, 17);
            this.CoRadioButton.TabIndex = 2;
            this.CoRadioButton.TabStop = true;
            this.CoRadioButton.Text = "Co-requisite";
            this.CoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PreRadioButton
            // 
            this.PreRadioButton.AutoSize = true;
            this.PreRadioButton.Location = new System.Drawing.Point(169, 50);
            this.PreRadioButton.Name = "PreRadioButton";
            this.PreRadioButton.Size = new System.Drawing.Size(83, 17);
            this.PreRadioButton.TabIndex = 1;
            this.PreRadioButton.TabStop = true;
            this.PreRadioButton.Text = "Pre-requisite";
            this.PreRadioButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Subject Code";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(279, 365);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(382, 365);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(681, 21);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "button1";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SubjectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubjectEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox OfferingComboBox;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.TextBox RequisiteTextBox;
        private System.Windows.Forms.RadioButton CoRadioButton;
        private System.Windows.Forms.RadioButton PreRadioButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button SaveButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.Button NextButton;
    }
}

