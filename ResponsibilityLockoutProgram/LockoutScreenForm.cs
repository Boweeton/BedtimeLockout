using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsibilityLockoutProgram
{
    public partial class LockoutScreenForm : Form
    {
        private LockoutProgram_MainForm parentForm;
        int topMargin = 32;
        int sidesMargin = 5;
        int bottomMargin = 5;
        int mainLabelBuffer = 60;

        public LockoutScreenForm(LockoutProgram_MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        private void LockoutScreenForm_Load(object sender, EventArgs e)
        {
            RecenterAndResizeForm();
            CenterGroupBoxAndLabel();
            this.TopMost = true;
            this.ControlBox = false;
            UpdateTokenDisplay();
        }

        // == 🔽 HELPER METHODS 🔽 ==============================================================================

        private void RecenterAndResizeForm()
        {
            // Get the screen where the form is located
            Screen screen = Screen.FromControl(this);

            // Get the working area of the screen (excluding taskbar)
            Rectangle workingArea = screen.WorkingArea;

            // Calculate the new size (width and height minus margins)
            int newWidth = workingArea.Width - (2 * sidesMargin); // Subtracting side margins
            int newHeight = workingArea.Height - topMargin - bottomMargin; // Subtracting top and bottom margins

            // Calculate the new position to center the form with the new size
            int x = workingArea.Left + sidesMargin; // Start with left margin for horizontal positioning
            int y = workingArea.Top + topMargin;     // Start with top margin for vertical positioning

            // Set the form's size and location
            this.Size = new Size(newWidth, newHeight);
            this.Location = new Point(x, y);
        }

        private void CenterGroupBoxAndLabel()
        {
            // Calculate the new location to center the GroupBox
            int groupBoxX = (this.ClientSize.Width - groupBox_LockoutControls.Width) / 2;
            int groupBoxY = (this.ClientSize.Height - groupBox_LockoutControls.Height) / 2;

            // Set the GroupBox's location to the calculated centered position
            groupBox_LockoutControls.Location = new Point(groupBoxX, groupBoxY);

            // Calculate the new location for the label to center it over the GroupBox with the buffer space
            int labelX = groupBoxX + (groupBox_LockoutControls.Width - label_Title.Width) / 2; // Center horizontally
            int labelY = groupBoxY - label_Title.Height - mainLabelBuffer; // Position above the GroupBox with buffer

            // Set the Label's location to the calculated position
            label_Title.Location = new Point(labelX, labelY);
        }

        private void UpdateTokenDisplay()
        {
            label_PushTimeTokenCounter.Text = $"({parentForm.CurrentSettings.PushTokenCount})";
            label_SnoozeTokensCounter.Text = $"({parentForm.CurrentSettings.SnoozeTokenCount})";
            label_ShutoffTokensCounter.Text = $"({parentForm.CurrentSettings.ShutoffTokenCount})";
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

        private void HandleTokenUsage(ref int counter, string counterName, int minutesToAdd)
        {

            if (counter > 0)
            {
                // Display message about using a push token
                UserMessageForm userMessageForm = new UserMessageForm(
                ParentForm: this,
                DisplayMessage: $"Are you sure?\r\nThis will leave you with {counter} {counterName}s until reset.\r\n ",
                UsesBothButtons: true,
                OptionOneText: $"Use {counterName}",
                OptionTwoText: "Cancel",
                BackgroundColor: Color.Ivory
                );
                DialogResult result = userMessageForm.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    counter--;
                    parentForm.SaveSettings(parentForm.CurrentSettings);
                    parentForm.Unlock();

                    if (!parentForm.isLocked)
                    {
                        parentForm.BuyTime(minutesToAdd);
                    }
                }
            }
            else
            {// Display message about being out of push tokens
                UserMessageForm userMessageForm = new UserMessageForm(
                ParentForm: this,
                DisplayMessage: $"NO! You have NO MORE {counterName}s",
                UsesBothButtons: false,
                OptionOneText: "Okay",
                OptionTwoText: String.Empty,
                BackgroundColor: Color.Brown
                );
                userMessageForm.Show();
            }
        }

        // == 🔽 FORM METHODS 🔽 ==============================================================================

        private void LockoutScreenForm_Move(object sender, EventArgs e)
        {
            RecenterAndResizeForm();
        }


        private void button_PushTime_Click(object sender, EventArgs e)
        {
            HandleTokenUsage(
                counter: ref parentForm.CurrentSettings.PushTokenCount,
                counterName: "Push Token",
                minutesToAdd: 3);
        }

        private void button_Snooze_Click(object sender, EventArgs e)
        {
            HandleTokenUsage(
                counter: ref parentForm.CurrentSettings.SnoozeTokenCount,
                counterName: "Snooze Token",
                minutesToAdd: 30);
        }

        private void button_Shutoff_Click(object sender, EventArgs e)
        {

            // Subtract the two TimeOnly values to get a TimeSpan
            TimeSpan difference = parentForm.defaultUnlockTime - parentForm.CurrentMoment();
            int totalMinutes = (int)(difference.TotalMinutes - 5);

            HandleTokenUsage(
                counter: ref parentForm.CurrentSettings.ShutoffTokenCount,
                counterName: "Shutoff Token",
                minutesToAdd: totalMinutes);
        }

        private void button_AdminOverride_Click(object sender, EventArgs e)
        {
            UserMessageForm userMessageForm = new UserMessageForm(
                ParentForm: this,
                DisplayMessage: "Are you sure?\r\nYou're evading responsibility!.\r\n ",
                UsesBothButtons: true,
                OptionOneText: "Disarm!",
                OptionTwoText: "Cancel",
                PassPhrase: "I KNOW I'M BEING IRRESPONSIBLE",
                BackgroundColor: Color.Coral
                );
            DialogResult result = userMessageForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                parentForm.Unlock(); // REPLACE WITH REAL BEHAVIOR
            }
        }

        private void button_debugShutoff_Click(object sender, EventArgs e)
        {
            parentForm.Unlock();
        }

        private void LockoutScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Focus();
        }
    }
}
