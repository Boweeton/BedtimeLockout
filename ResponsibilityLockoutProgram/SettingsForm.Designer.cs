namespace ResponsibilityLockoutProgram
{
    partial class SettingsForm
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
            label_Settings = new Label();
            button_SaveClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox_LockoutHour = new TextBox();
            label5 = new Label();
            textBox_LockoutMinute = new TextBox();
            textBox_UnlockHour = new TextBox();
            label3 = new Label();
            textBox_UnlockMinute = new TextBox();
            label6 = new Label();
            textBox_LockoutTimeCode = new TextBox();
            textBox_UnlockTimeCode = new TextBox();
            groupBox_DaySettings = new GroupBox();
            button_SaveSundaySettings = new Button();
            button_SaveSaturdaySettings = new Button();
            button_SaveFridaySettings = new Button();
            button_SaveThursdaySettings = new Button();
            button_SaveWednesdaySettings = new Button();
            button_SaveTuesdaySettings = new Button();
            button_SaveEverydaySettings = new Button();
            button_SaveMondaySettings = new Button();
            label_ComingSoon = new Label();
            groupBox_DaySettings.SuspendLayout();
            SuspendLayout();
            // 
            // label_Settings
            // 
            label_Settings.AutoSize = true;
            label_Settings.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Settings.Location = new Point(12, 9);
            label_Settings.Name = "label_Settings";
            label_Settings.Size = new Size(81, 21);
            label_Settings.TabIndex = 0;
            label_Settings.Text = "Settings";
            // 
            // button_SaveClose
            // 
            button_SaveClose.Location = new Point(12, 33);
            button_SaveClose.Name = "button_SaveClose";
            button_SaveClose.Size = new Size(155, 23);
            button_SaveClose.TabIndex = 2;
            button_SaveClose.Text = "Save and Close";
            button_SaveClose.UseVisualStyleBackColor = true;
            button_SaveClose.Click += button_SaveClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(13, 21);
            label2.TabIndex = 0;
            label2.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 74);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 0;
            label4.Text = "Monday";
            // 
            // textBox_LockoutHour
            // 
            textBox_LockoutHour.Location = new Point(6, 96);
            textBox_LockoutHour.Name = "textBox_LockoutHour";
            textBox_LockoutHour.Size = new Size(20, 23);
            textBox_LockoutHour.TabIndex = 0;
            textBox_LockoutHour.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(152, 95);
            label5.Name = "label5";
            label5.Size = new Size(13, 21);
            label5.TabIndex = 0;
            label5.Text = ":";
            // 
            // textBox_LockoutMinute
            // 
            textBox_LockoutMinute.Location = new Point(32, 96);
            textBox_LockoutMinute.Name = "textBox_LockoutMinute";
            textBox_LockoutMinute.Size = new Size(20, 23);
            textBox_LockoutMinute.TabIndex = 1;
            textBox_LockoutMinute.Text = "15";
            // 
            // textBox_UnlockHour
            // 
            textBox_UnlockHour.Location = new Point(135, 96);
            textBox_UnlockHour.Name = "textBox_UnlockHour";
            textBox_UnlockHour.Size = new Size(20, 23);
            textBox_UnlockHour.TabIndex = 3;
            textBox_UnlockHour.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(86, 46);
            label3.TabIndex = 0;
            label3.Text = "Lockout\r\nTimes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_UnlockMinute
            // 
            textBox_UnlockMinute.Location = new Point(161, 96);
            textBox_UnlockMinute.Name = "textBox_UnlockMinute";
            textBox_UnlockMinute.Size = new Size(20, 23);
            textBox_UnlockMinute.TabIndex = 4;
            textBox_UnlockMinute.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(135, 19);
            label6.Name = "label6";
            label6.Size = new Size(77, 46);
            label6.TabIndex = 0;
            label6.Text = "Unlock\r\nTimes";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_LockoutTimeCode
            // 
            textBox_LockoutTimeCode.Location = new Point(57, 96);
            textBox_LockoutTimeCode.Name = "textBox_LockoutTimeCode";
            textBox_LockoutTimeCode.ReadOnly = true;
            textBox_LockoutTimeCode.Size = new Size(27, 23);
            textBox_LockoutTimeCode.TabIndex = 2;
            textBox_LockoutTimeCode.Text = "PM";
            textBox_LockoutTimeCode.Click += textBox3_Click;
            textBox_LockoutTimeCode.TextChanged += textBox3_TextChanged;
            // 
            // textBox_UnlockTimeCode
            // 
            textBox_UnlockTimeCode.Location = new Point(186, 96);
            textBox_UnlockTimeCode.Name = "textBox_UnlockTimeCode";
            textBox_UnlockTimeCode.Size = new Size(27, 23);
            textBox_UnlockTimeCode.TabIndex = 5;
            textBox_UnlockTimeCode.Text = "AM";
            // 
            // groupBox_DaySettings
            // 
            groupBox_DaySettings.Controls.Add(button_SaveSundaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveSaturdaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveFridaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveThursdaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveWednesdaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveTuesdaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveEverydaySettings);
            groupBox_DaySettings.Controls.Add(button_SaveMondaySettings);
            groupBox_DaySettings.Controls.Add(textBox_UnlockTimeCode);
            groupBox_DaySettings.Controls.Add(textBox_LockoutTimeCode);
            groupBox_DaySettings.Controls.Add(label_ComingSoon);
            groupBox_DaySettings.Controls.Add(label6);
            groupBox_DaySettings.Controls.Add(textBox_UnlockMinute);
            groupBox_DaySettings.Controls.Add(label3);
            groupBox_DaySettings.Controls.Add(textBox_UnlockHour);
            groupBox_DaySettings.Controls.Add(textBox_LockoutMinute);
            groupBox_DaySettings.Controls.Add(label5);
            groupBox_DaySettings.Controls.Add(textBox_LockoutHour);
            groupBox_DaySettings.Controls.Add(label4);
            groupBox_DaySettings.Controls.Add(label2);
            groupBox_DaySettings.Controls.Add(label1);
            groupBox_DaySettings.Location = new Point(12, 71);
            groupBox_DaySettings.Name = "groupBox_DaySettings";
            groupBox_DaySettings.Size = new Size(220, 442);
            groupBox_DaySettings.TabIndex = 1;
            groupBox_DaySettings.TabStop = false;
            groupBox_DaySettings.Text = "Day Settings";
            groupBox_DaySettings.Enter += groupBox_DaySettings_Enter;
            // 
            // button_SaveSundaySettings
            // 
            button_SaveSundaySettings.Enabled = false;
            button_SaveSundaySettings.Location = new Point(6, 403);
            button_SaveSundaySettings.Name = "button_SaveSundaySettings";
            button_SaveSundaySettings.Size = new Size(159, 23);
            button_SaveSundaySettings.TabIndex = 6;
            button_SaveSundaySettings.Text = "Save Sunday Settings";
            button_SaveSundaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveSundaySettings.UseVisualStyleBackColor = true;
            // 
            // button_SaveSaturdaySettings
            // 
            button_SaveSaturdaySettings.Enabled = false;
            button_SaveSaturdaySettings.Location = new Point(6, 374);
            button_SaveSaturdaySettings.Name = "button_SaveSaturdaySettings";
            button_SaveSaturdaySettings.Size = new Size(159, 23);
            button_SaveSaturdaySettings.TabIndex = 6;
            button_SaveSaturdaySettings.Text = "Save Saturday Settings";
            button_SaveSaturdaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveSaturdaySettings.UseVisualStyleBackColor = true;
            // 
            // button_SaveFridaySettings
            // 
            button_SaveFridaySettings.Enabled = false;
            button_SaveFridaySettings.Location = new Point(6, 345);
            button_SaveFridaySettings.Name = "button_SaveFridaySettings";
            button_SaveFridaySettings.Size = new Size(159, 23);
            button_SaveFridaySettings.TabIndex = 6;
            button_SaveFridaySettings.Text = "Save Friday Settings";
            button_SaveFridaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveFridaySettings.UseVisualStyleBackColor = true;
            // 
            // button_SaveThursdaySettings
            // 
            button_SaveThursdaySettings.Enabled = false;
            button_SaveThursdaySettings.Location = new Point(6, 316);
            button_SaveThursdaySettings.Name = "button_SaveThursdaySettings";
            button_SaveThursdaySettings.Size = new Size(159, 23);
            button_SaveThursdaySettings.TabIndex = 6;
            button_SaveThursdaySettings.Text = "Save Thursday Settings";
            button_SaveThursdaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveThursdaySettings.UseVisualStyleBackColor = true;
            // 
            // button_SaveWednesdaySettings
            // 
            button_SaveWednesdaySettings.Enabled = false;
            button_SaveWednesdaySettings.Location = new Point(6, 287);
            button_SaveWednesdaySettings.Name = "button_SaveWednesdaySettings";
            button_SaveWednesdaySettings.Size = new Size(159, 23);
            button_SaveWednesdaySettings.TabIndex = 6;
            button_SaveWednesdaySettings.Text = "Save Wednesday Settings";
            button_SaveWednesdaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveWednesdaySettings.UseVisualStyleBackColor = true;
            // 
            // button_SaveTuesdaySettings
            // 
            button_SaveTuesdaySettings.Enabled = false;
            button_SaveTuesdaySettings.Location = new Point(6, 258);
            button_SaveTuesdaySettings.Name = "button_SaveTuesdaySettings";
            button_SaveTuesdaySettings.Size = new Size(159, 23);
            button_SaveTuesdaySettings.TabIndex = 6;
            button_SaveTuesdaySettings.Text = "Save Tuesday Settings";
            button_SaveTuesdaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveTuesdaySettings.UseVisualStyleBackColor = true;
            // 
            // button_SaveEverydaySettings
            // 
            button_SaveEverydaySettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_SaveEverydaySettings.Location = new Point(6, 136);
            button_SaveEverydaySettings.Name = "button_SaveEverydaySettings";
            button_SaveEverydaySettings.Size = new Size(159, 23);
            button_SaveEverydaySettings.TabIndex = 6;
            button_SaveEverydaySettings.Text = "Save For Every Day";
            button_SaveEverydaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveEverydaySettings.UseVisualStyleBackColor = true;
            button_SaveEverydaySettings.Click += button_SaveEverydaySettings_Click;
            // 
            // button_SaveMondaySettings
            // 
            button_SaveMondaySettings.Enabled = false;
            button_SaveMondaySettings.Location = new Point(6, 229);
            button_SaveMondaySettings.Name = "button_SaveMondaySettings";
            button_SaveMondaySettings.Size = new Size(159, 23);
            button_SaveMondaySettings.TabIndex = 6;
            button_SaveMondaySettings.Text = "Save Monday Settings";
            button_SaveMondaySettings.TextAlign = ContentAlignment.MiddleLeft;
            button_SaveMondaySettings.UseVisualStyleBackColor = true;
            // 
            // label_ComingSoon
            // 
            label_ComingSoon.AutoSize = true;
            label_ComingSoon.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ComingSoon.Location = new Point(23, 206);
            label_ComingSoon.Name = "label_ComingSoon";
            label_ComingSoon.Size = new Size(165, 23);
            label_ComingSoon.TabIndex = 0;
            label_ComingSoon.Text = "COMING SOON";
            label_ComingSoon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(250, 527);
            Controls.Add(button_SaveClose);
            Controls.Add(groupBox_DaySettings);
            Controls.Add(label_Settings);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            groupBox_DaySettings.ResumeLayout(false);
            groupBox_DaySettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Settings;
        private Button button_SaveClose;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox_LockoutHour;
        private Label label5;
        private TextBox textBox_LockoutMinute;
        private TextBox textBox_UnlockHour;
        private Label label3;
        private TextBox textBox_UnlockMinute;
        private Label label6;
        private TextBox textBox_LockoutTimeCode;
        private TextBox textBox_UnlockTimeCode;
        private GroupBox groupBox_DaySettings;
        private Button button_SaveSaturdaySettings;
        private Button button_SaveFridaySettings;
        private Button button_SaveThursdaySettings;
        private Button button_SaveWednesdaySettings;
        private Button button_SaveTuesdaySettings;
        private Button button_SaveMondaySettings;
        private Button button_SaveSundaySettings;
        private Button button_SaveEverydaySettings;
        private Label label_ComingSoon;
    }
}