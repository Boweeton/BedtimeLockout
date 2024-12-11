namespace ResponsibilityLockoutProgram
{
    partial class LockoutScreenForm
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
            button_Snooze = new Button();
            groupBox_LockoutControls = new GroupBox();
            label_ShutoffTokensCounter = new Label();
            label_PushTimeTokenCounter = new Label();
            button_BumpTime = new Button();
            label_SnoozeTokensCounter = new Label();
            button_debugShutoff = new Button();
            button_AdminOverride = new Button();
            button_Shutoff = new Button();
            label_Title = new Label();
            groupBox_LockoutControls.SuspendLayout();
            SuspendLayout();
            // 
            // button_Snooze
            // 
            button_Snooze.Cursor = Cursors.Hand;
            button_Snooze.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_Snooze.Location = new Point(6, 88);
            button_Snooze.Name = "button_Snooze";
            button_Snooze.Size = new Size(363, 60);
            button_Snooze.TabIndex = 1;
            button_Snooze.Text = "Snooze [30 min]";
            button_Snooze.TextAlign = ContentAlignment.MiddleLeft;
            button_Snooze.UseVisualStyleBackColor = true;
            button_Snooze.Click += button_Snooze_Click;
            // 
            // groupBox_LockoutControls
            // 
            groupBox_LockoutControls.Controls.Add(label_ShutoffTokensCounter);
            groupBox_LockoutControls.Controls.Add(label_PushTimeTokenCounter);
            groupBox_LockoutControls.Controls.Add(button_BumpTime);
            groupBox_LockoutControls.Controls.Add(label_SnoozeTokensCounter);
            groupBox_LockoutControls.Controls.Add(button_debugShutoff);
            groupBox_LockoutControls.Controls.Add(button_AdminOverride);
            groupBox_LockoutControls.Controls.Add(button_Shutoff);
            groupBox_LockoutControls.Controls.Add(button_Snooze);
            groupBox_LockoutControls.Location = new Point(134, 268);
            groupBox_LockoutControls.Name = "groupBox_LockoutControls";
            groupBox_LockoutControls.Size = new Size(492, 366);
            groupBox_LockoutControls.TabIndex = 1;
            groupBox_LockoutControls.TabStop = false;
            // 
            // label_ShutoffTokensCounter
            // 
            label_ShutoffTokensCounter.AutoSize = true;
            label_ShutoffTokensCounter.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ShutoffTokensCounter.ForeColor = SystemColors.ButtonFace;
            label_ShutoffTokensCounter.Location = new Point(373, 158);
            label_ShutoffTokensCounter.Name = "label_ShutoffTokensCounter";
            label_ShutoffTokensCounter.Size = new Size(71, 50);
            label_ShutoffTokensCounter.TabIndex = 2;
            label_ShutoffTokensCounter.Text = "(2)";
            label_ShutoffTokensCounter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_PushTimeTokenCounter
            // 
            label_PushTimeTokenCounter.AutoSize = true;
            label_PushTimeTokenCounter.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_PushTimeTokenCounter.ForeColor = SystemColors.ButtonFace;
            label_PushTimeTokenCounter.Location = new Point(373, 26);
            label_PushTimeTokenCounter.Name = "label_PushTimeTokenCounter";
            label_PushTimeTokenCounter.Size = new Size(71, 50);
            label_PushTimeTokenCounter.TabIndex = 5;
            label_PushTimeTokenCounter.Text = "(9)";
            label_PushTimeTokenCounter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_BumpTime
            // 
            button_BumpTime.Cursor = Cursors.Hand;
            button_BumpTime.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_BumpTime.Location = new Point(6, 22);
            button_BumpTime.Name = "button_BumpTime";
            button_BumpTime.Size = new Size(363, 60);
            button_BumpTime.TabIndex = 0;
            button_BumpTime.Text = "Push Time [3 min]";
            button_BumpTime.TextAlign = ContentAlignment.MiddleLeft;
            button_BumpTime.UseVisualStyleBackColor = true;
            button_BumpTime.Click += button_PushTime_Click;
            // 
            // label_SnoozeTokensCounter
            // 
            label_SnoozeTokensCounter.AutoSize = true;
            label_SnoozeTokensCounter.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_SnoozeTokensCounter.ForeColor = SystemColors.ButtonFace;
            label_SnoozeTokensCounter.Location = new Point(373, 92);
            label_SnoozeTokensCounter.Name = "label_SnoozeTokensCounter";
            label_SnoozeTokensCounter.Size = new Size(71, 50);
            label_SnoozeTokensCounter.TabIndex = 2;
            label_SnoozeTokensCounter.Text = "(5)";
            label_SnoozeTokensCounter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_debugShutoff
            // 
            button_debugShutoff.BackColor = Color.IndianRed;
            button_debugShutoff.Cursor = Cursors.Hand;
            button_debugShutoff.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_debugShutoff.Location = new Point(6, 286);
            button_debugShutoff.Name = "button_debugShutoff";
            button_debugShutoff.Size = new Size(363, 60);
            button_debugShutoff.TabIndex = 4;
            button_debugShutoff.Text = "Debug - Shutoff";
            button_debugShutoff.UseVisualStyleBackColor = false;
            button_debugShutoff.Click += button_debugShutoff_Click;
            // 
            // button_AdminOverride
            // 
            button_AdminOverride.Cursor = Cursors.Hand;
            button_AdminOverride.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_AdminOverride.Location = new Point(6, 220);
            button_AdminOverride.Name = "button_AdminOverride";
            button_AdminOverride.Size = new Size(363, 60);
            button_AdminOverride.TabIndex = 3;
            button_AdminOverride.Text = "Admin Override";
            button_AdminOverride.TextAlign = ContentAlignment.MiddleLeft;
            button_AdminOverride.UseVisualStyleBackColor = true;
            button_AdminOverride.Click += button_AdminOverride_Click;
            // 
            // button_Shutoff
            // 
            button_Shutoff.Cursor = Cursors.Hand;
            button_Shutoff.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button_Shutoff.Location = new Point(6, 154);
            button_Shutoff.Name = "button_Shutoff";
            button_Shutoff.Size = new Size(363, 60);
            button_Shutoff.TabIndex = 2;
            button_Shutoff.Text = "Shutoff [skip today]";
            button_Shutoff.TextAlign = ContentAlignment.MiddleLeft;
            button_Shutoff.UseVisualStyleBackColor = true;
            button_Shutoff.Click += button_Shutoff_Click;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.ForeColor = SystemColors.ButtonFace;
            label_Title.Location = new Point(84, 49);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(557, 172);
            label_Title.TabIndex = 2;
            label_Title.Text = "Responsibility\r\nLockout Program";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LockoutScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1584, 861);
            Controls.Add(label_Title);
            Controls.Add(groupBox_LockoutControls);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(3000, 3000);
            MinimizeBox = false;
            Name = "LockoutScreenForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Responsibility Lockout Program";
            FormClosed += LockoutScreenForm_FormClosed;
            Load += LockoutScreenForm_Load;
            Move += LockoutScreenForm_Move;
            groupBox_LockoutControls.ResumeLayout(false);
            groupBox_LockoutControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Snooze;
        private GroupBox groupBox_LockoutControls;
        private Button button_Shutoff;
        private Button button_AdminOverride;
        private Button button_debugShutoff;
        private Label label_Title;
        private Label label_ShutoffTokensCounter;
        private Label label_SnoozeTokensCounter;
        private Label label_PushTimeTokenCounter;
        private Button button_BumpTime;
    }
}