namespace ResponsibilityLockoutProgram
{
    partial class LockoutProgram_MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testButton = new Button();
            button_Settings = new Button();
            label_CountdownTitle = new Label();
            label_Countdown = new Label();
            button_ArmedStatus = new Button();
            panel_Time = new Panel();
            label_CountdownLegend = new Label();
            panel_EasySettings = new Panel();
            button_SetEasySettings = new Button();
            textBox_EasySettingsInput = new TextBox();
            label_EasySettingsStatus = new Label();
            label_EasySettingsTitle = new Label();
            button_ResetUserSettings = new Button();
            label_TestDisplay = new Label();
            panel_Time.SuspendLayout();
            panel_EasySettings.SuspendLayout();
            SuspendLayout();
            // 
            // testButton
            // 
            testButton.BackColor = SystemColors.Window;
            testButton.Cursor = Cursors.Hand;
            testButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            testButton.Location = new Point(12, 12);
            testButton.Name = "testButton";
            testButton.Size = new Size(300, 60);
            testButton.TabIndex = 0;
            testButton.Text = "Test Lockout";
            testButton.UseVisualStyleBackColor = false;
            testButton.Click += testButton_Click;
            // 
            // button_Settings
            // 
            button_Settings.BackColor = SystemColors.Window;
            button_Settings.Cursor = Cursors.Hand;
            button_Settings.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_Settings.Location = new Point(17, 78);
            button_Settings.Name = "button_Settings";
            button_Settings.Size = new Size(300, 60);
            button_Settings.TabIndex = 1;
            button_Settings.Text = "Settings ⚙️";
            button_Settings.UseVisualStyleBackColor = false;
            button_Settings.Click += button_Settings_Click;
            // 
            // label_CountdownTitle
            // 
            label_CountdownTitle.AutoSize = true;
            label_CountdownTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_CountdownTitle.ForeColor = SystemColors.ControlText;
            label_CountdownTitle.Location = new Point(3, 3);
            label_CountdownTitle.Name = "label_CountdownTitle";
            label_CountdownTitle.Size = new Size(153, 111);
            label_CountdownTitle.TabIndex = 3;
            label_CountdownTitle.Text = "Time Until\r\nLockout at\r\n--:--";
            label_CountdownTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Countdown
            // 
            label_Countdown.AutoSize = true;
            label_Countdown.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Countdown.ForeColor = SystemColors.ControlText;
            label_Countdown.Location = new Point(3, 137);
            label_Countdown.Name = "label_Countdown";
            label_Countdown.Size = new Size(167, 36);
            label_Countdown.TabIndex = 3;
            label_Countdown.Text = "00:00:00";
            label_Countdown.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_ArmedStatus
            // 
            button_ArmedStatus.BackColor = SystemColors.Window;
            button_ArmedStatus.Cursor = Cursors.Hand;
            button_ArmedStatus.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_ArmedStatus.Location = new Point(12, 144);
            button_ArmedStatus.Name = "button_ArmedStatus";
            button_ArmedStatus.Size = new Size(300, 60);
            button_ArmedStatus.TabIndex = 2;
            button_ArmedStatus.Text = "disarmed";
            button_ArmedStatus.UseVisualStyleBackColor = false;
            button_ArmedStatus.Click += button_ArmedStatus_Click;
            // 
            // panel_Time
            // 
            panel_Time.BackColor = SystemColors.Window;
            panel_Time.Controls.Add(label_CountdownLegend);
            panel_Time.Controls.Add(label_Countdown);
            panel_Time.Controls.Add(label_CountdownTitle);
            panel_Time.Location = new Point(3, 379);
            panel_Time.Name = "panel_Time";
            panel_Time.Size = new Size(193, 215);
            panel_Time.TabIndex = 5;
            // 
            // label_CountdownLegend
            // 
            label_CountdownLegend.AutoSize = true;
            label_CountdownLegend.Font = new Font("Courier New", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_CountdownLegend.ForeColor = SystemColors.ControlText;
            label_CountdownLegend.Location = new Point(3, 165);
            label_CountdownLegend.Name = "label_CountdownLegend";
            label_CountdownLegend.Size = new Size(167, 36);
            label_CountdownLegend.TabIndex = 4;
            label_CountdownLegend.Text = " h: m: s";
            label_CountdownLegend.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_EasySettings
            // 
            panel_EasySettings.BackColor = SystemColors.Window;
            panel_EasySettings.Controls.Add(button_SetEasySettings);
            panel_EasySettings.Controls.Add(textBox_EasySettingsInput);
            panel_EasySettings.Controls.Add(label_EasySettingsStatus);
            panel_EasySettings.Controls.Add(label_EasySettingsTitle);
            panel_EasySettings.Location = new Point(30, 600);
            panel_EasySettings.Name = "panel_EasySettings";
            panel_EasySettings.Size = new Size(247, 170);
            panel_EasySettings.TabIndex = 6;
            // 
            // button_SetEasySettings
            // 
            button_SetEasySettings.Location = new Point(122, 64);
            button_SetEasySettings.Name = "button_SetEasySettings";
            button_SetEasySettings.Size = new Size(75, 23);
            button_SetEasySettings.TabIndex = 5;
            button_SetEasySettings.Text = "Save";
            button_SetEasySettings.UseVisualStyleBackColor = true;
            button_SetEasySettings.Click += button_SetEasySettings_Click;
            // 
            // textBox_EasySettingsInput
            // 
            textBox_EasySettingsInput.Location = new Point(84, 35);
            textBox_EasySettingsInput.Name = "textBox_EasySettingsInput";
            textBox_EasySettingsInput.Size = new Size(100, 23);
            textBox_EasySettingsInput.TabIndex = 4;
            textBox_EasySettingsInput.KeyDown += textBox_EasySettingsInput_KeyDown;
            // 
            // label_EasySettingsStatus
            // 
            label_EasySettingsStatus.AutoSize = true;
            label_EasySettingsStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_EasySettingsStatus.ForeColor = SystemColors.ControlText;
            label_EasySettingsStatus.Location = new Point(25, 93);
            label_EasySettingsStatus.Name = "label_EasySettingsStatus";
            label_EasySettingsStatus.Size = new Size(63, 25);
            label_EasySettingsStatus.TabIndex = 3;
            label_EasySettingsStatus.Text = "status";
            label_EasySettingsStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_EasySettingsTitle
            // 
            label_EasySettingsTitle.AutoSize = true;
            label_EasySettingsTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_EasySettingsTitle.ForeColor = SystemColors.ControlText;
            label_EasySettingsTitle.Location = new Point(25, 7);
            label_EasySettingsTitle.Name = "label_EasySettingsTitle";
            label_EasySettingsTitle.Size = new Size(159, 25);
            label_EasySettingsTitle.TabIndex = 3;
            label_EasySettingsTitle.Text = "Set Lockout Time";
            label_EasySettingsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_ResetUserSettings
            // 
            button_ResetUserSettings.BackColor = SystemColors.Window;
            button_ResetUserSettings.Cursor = Cursors.Hand;
            button_ResetUserSettings.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_ResetUserSettings.Location = new Point(12, 210);
            button_ResetUserSettings.Name = "button_ResetUserSettings";
            button_ResetUserSettings.Size = new Size(300, 60);
            button_ResetUserSettings.TabIndex = 2;
            button_ResetUserSettings.Text = "Admin: Reset";
            button_ResetUserSettings.UseVisualStyleBackColor = false;
            button_ResetUserSettings.Click += button_ResetUserSettings_Click;
            // 
            // label_TestDisplay
            // 
            label_TestDisplay.AutoSize = true;
            label_TestDisplay.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TestDisplay.ForeColor = SystemColors.ControlText;
            label_TestDisplay.Location = new Point(50, 292);
            label_TestDisplay.Name = "label_TestDisplay";
            label_TestDisplay.Size = new Size(262, 72);
            label_TestDisplay.TabIndex = 7;
            label_TestDisplay.Text = "Seconds Left:\r\n156685.32";
            label_TestDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LockoutProgram_MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(384, 815);
            Controls.Add(label_TestDisplay);
            Controls.Add(panel_EasySettings);
            Controls.Add(panel_Time);
            Controls.Add(button_ResetUserSettings);
            Controls.Add(button_ArmedStatus);
            Controls.Add(button_Settings);
            Controls.Add(testButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(346, 829);
            Name = "LockoutProgram_MainForm";
            Text = "Responsibility Lockout Program";
            FormClosing += LockoutProgram_MainForm_FormClosing;
            Load += Form1_Load;
            Resize += LockoutProgram_MainForm_Resize;
            panel_Time.ResumeLayout(false);
            panel_Time.PerformLayout();
            panel_EasySettings.ResumeLayout(false);
            panel_EasySettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button testButton;
        private Button button_Settings;
        private Label label_CountdownTitle;
        private Label label_Countdown;
        private Button button_ArmedStatus;
        private Panel panel_Time;
        private Label label_CountdownLegend;
        private Panel panel_EasySettings;
        private Label label_EasySettingsTitle;
        private Button button_SetEasySettings;
        private TextBox textBox_EasySettingsInput;
        private Label label_EasySettingsStatus;
        private Button button_ResetUserSettings;
        private Label label_TestDisplay;
    }
}
