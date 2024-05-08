namespace Enrollment_System
{
    partial class SubjectScheduleEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EDPCodeTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.StartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.SchoolYearTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AMComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDP Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "School Year";
            // 
            // EDPCodeTextBox
            // 
            this.EDPCodeTextBox.Location = new System.Drawing.Point(154, 100);
            this.EDPCodeTextBox.Name = "EDPCodeTextBox";
            this.EDPCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EDPCodeTextBox.TabIndex = 9;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(154, 126);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubjectCodeTextBox.TabIndex = 10;
            this.SubjectCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectCodeTextBox_KeyPress);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.MistyRose;
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Location = new System.Drawing.Point(154, 153);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(169, 23);
            this.DescriptionLabel.TabIndex = 11;
            // 
            // StartTimeDateTimePicker
            // 
            this.StartTimeDateTimePicker.CustomFormat = "HH:mm";
            this.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimeDateTimePicker.Location = new System.Drawing.Point(154, 180);
            this.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker";
            this.StartTimeDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.StartTimeDateTimePicker.TabIndex = 12;
            // 
            // EndTimeDateTimePicker
            // 
            this.EndTimeDateTimePicker.CustomFormat = "HH:mm";
            this.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimeDateTimePicker.Location = new System.Drawing.Point(154, 207);
            this.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker";
            this.EndTimeDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.EndTimeDateTimePicker.TabIndex = 13;
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(154, 234);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.DaysTextBox.TabIndex = 14;
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.Location = new System.Drawing.Point(154, 260);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.SectionTextBox.TabIndex = 15;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Location = new System.Drawing.Point(154, 286);
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoomTextBox.TabIndex = 16;
            // 
            // SchoolYearTextBox
            // 
            this.SchoolYearTextBox.Location = new System.Drawing.Point(154, 312);
            this.SchoolYearTextBox.Name = "SchoolYearTextBox";
            this.SchoolYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.SchoolYearTextBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "AM/PM";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(298, 382);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AMComboBox
            // 
            this.AMComboBox.FormattingEnabled = true;
            this.AMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMComboBox.Location = new System.Drawing.Point(482, 170);
            this.AMComboBox.Name = "AMComboBox";
            this.AMComboBox.Size = new System.Drawing.Size(121, 21);
            this.AMComboBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Subject Schedule  Entry";
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(50, 38);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 22;
            this.PrevButton.Text = "button1";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // SubjectScheduleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AMComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SchoolYearTextBox);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.SectionTextBox);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.EndTimeDateTimePicker);
            this.Controls.Add(this.StartTimeDateTimePicker);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.EDPCodeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubjectScheduleEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubjectScheduleEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EDPCodeTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.DateTimePicker StartTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimeDateTimePicker;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.TextBox SchoolYearTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox AMComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button PrevButton;
    }
}