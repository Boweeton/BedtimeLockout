using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ResponsibilityLockoutProgram
{
    public partial class SettingsForm : Form
    {
        private LockoutProgram_MainForm parentForm;

        public SettingsForm(LockoutProgram_MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Calculate the position to center this form on the parent form
            int x = parentForm.Location.X + (parentForm.Width - Width) / 2;
            int y = parentForm.Location.Y + (parentForm.Height - Height) / 2;
            Location = new Point(x, y);

            CenterControlHorizontally(groupBox_DaySettings, this);
            CenterControlHorizontally(button_SaveClose, this);
            CenterControlHorizontally(label_ComingSoon, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveEverydaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveMondaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveTuesdaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveWednesdaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveThursdaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveFridaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveSaturdaySettings, groupBox_DaySettings);
            CenterControlHorizontally(button_SaveSundaySettings, groupBox_DaySettings);


        }


        private void CenterControlHorizontally(Control controlToCenter, Control parentControl)
        {
            // Ensure the control has a parent (to center in)
            if (parentControl != null)
            {
                // Calculate the new X position to center the control
                int parentWidth = parentControl.ClientSize.Width;
                int controlWidth = controlToCenter.Width;

                // Set the control's Left property to horizontally center it within the parent control
                controlToCenter.Left = (parentWidth - controlWidth) / 2;
            }
        }

        private void SaveSettings()
        {
            TimeOnly newLockoutTime = parentForm.GetTimeFromString($"{textBox_LockoutHour.Text}:{textBox_LockoutMinute.Text} {textBox_LockoutTimeCode.Text}");
            TimeOnly newUnlockTime = parentForm.GetTimeFromString($"{textBox_UnlockHour.Text}:{textBox_UnlockMinute.Text} {textBox_UnlockTimeCode.Text}");

            TimeOnly userLockoutInputTime = new TimeOnly(newLockoutTime.Hour, newLockoutTime.Minute, newLockoutTime.Second);
            TimeOnly userUnlockInputTime = new TimeOnly(newUnlockTime.Hour, newUnlockTime.Minute, newUnlockTime.Second);

            parentForm.CurrentSettings.LockoutTime = userLockoutInputTime;
            parentForm.CurrentSettings.UnlockTime = userUnlockInputTime;
            parentForm.TargetLockingTime = userLockoutInputTime;

            parentForm.SaveSettings(parentForm.CurrentSettings);
        }


        private void button_SaveClose_Click(object sender, EventArgs e)
        {
            Close(); // PUT IN REAL BEHAVIOR LATER
        }
        private void button_CancelClose_Click(object sender, EventArgs e)
        {
            Close(); // PUT IN REAL BEHAVIOR LATER
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox_LockoutTimeCode.Text = textBox_LockoutTimeCode.Text == "AM" ? "PM" : "AM";
        }

        private void groupBox_DaySettings_Enter(object sender, EventArgs e)
        {

        }

        private void button_SaveEverydaySettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
    }
}
