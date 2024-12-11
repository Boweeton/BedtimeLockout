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
    public partial class UserMessageForm : Form
    {
        // == 🔽 💲CLASS DATA AND PROPERTIES 🔽 ==================================================

        int bufferAmount = 10;
        private Form parentForm;
        int buttonCount;
        int boarderPadding = 90;
        string passPhrase = "ALL YOUR BASE ARE BELONG TO US! YEET YEET";
        bool usesBothButtons;
        bool usesPassPhrase = false;



        // == 🔽 🛠️ CONSTRUCTORS 🔽 ==================================================
        public UserMessageForm(Form ParentForm, string DisplayMessage, bool UsesBothButtons, string OptionOneText, string OptionTwoText, string PassPhrase, Color BackgroundColor) // WITH PassPhrase
        {
            InitializeComponent();
            parentForm = ParentForm;
            button_Option1.Text = OptionOneText;
            button_Option2.Text = OptionTwoText;
            usesBothButtons = UsesBothButtons;
            this.BackColor = BackgroundColor;

            // Handle Passphrase integration
            passPhrase = PassPhrase;
            usesPassPhrase = true;
            label_UserMessage.Text = $"{DisplayMessage}\r\n\r\nTo Continue, type:\r\n\"{passPhrase}\"";


            // Make form box, rather than normal form
            this.TopMost = true;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.Text = null;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // Optional: Disable the maximize button as well
        }
        public UserMessageForm(Form ParentForm, string DisplayMessage, bool UsesBothButtons, string OptionOneText, string OptionTwoText, Color BackgroundColor) // WITHOUT PassPhrase
        {
            InitializeComponent();
            parentForm = ParentForm;
            label_UserMessage.Text = DisplayMessage;
            button_Option1.Text = OptionOneText;
            button_Option2.Text = OptionTwoText;
            usesBothButtons = UsesBothButtons;
            this.BackColor = BackgroundColor;
            usesPassPhrase = false;


            // Make form box, rather than normal form
            this.TopMost = true;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.Text = null;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // Optional: Disable the maximize button as well
        }



        private void AdjustAndCenterElements()
        {
            // Use a single Graphics object to measure both buttons, label, and text box
            using (Graphics g = this.CreateGraphics())
            {
                // Measure the text width of the buttons
                SizeF sizeOption1 = g.MeasureString(button_Option1.Text, button_Option1.Font);
                SizeF sizeOption2 = g.MeasureString(button_Option2.Text, button_Option2.Font);
                // Measure the label's text width
                SizeF sizeLabel = g.MeasureString(label_UserMessage.Text, label_UserMessage.Font);
                // Measure the text box's placeholder or sample text width (assuming it's enabled and visible)
                SizeF sizeTextBox = SizeF.Empty;
                if (textBox_passPhraseInput.Enabled && textBox_passPhraseInput.Visible)
                {
                    sizeTextBox = g.MeasureString(textBox_passPhraseInput.Text, textBox_passPhraseInput.Font);
                }

                // Determine the maximum width needed for the buttons, label, and text box (plus padding)
                int maxButtonWidth = (int)Math.Max(sizeOption1.Width, sizeOption2.Width) + 20;
                int labelWidth = (int)sizeLabel.Width + 20; // Add padding for the label
                int textBoxWidth = textBox_passPhraseInput.Enabled && textBox_passPhraseInput.Visible
                    ? (int)sizeTextBox.Width + 20 // Add padding for the text box
                    : 0;

                // Determine the maximum width for all elements
                int newFormWidth = Math.Max(Math.Max(maxButtonWidth, labelWidth), textBoxWidth) + boarderPadding;

                // Set button widths to the largest needed size
                button_Option1.Width = maxButtonWidth;
                button_Option2.Width = maxButtonWidth;

                // Adjust text box width if it is enabled and visible
                if (textBox_passPhraseInput.Enabled && textBox_passPhraseInput.Visible)
                {
                    textBox_passPhraseInput.Width = textBoxWidth;
                }

                // Adjust the form width
                this.Width = newFormWidth;
            }

            // Calculate the center of the form
            int formCenter = this.ClientSize.Width / 2;

            // Center the label
            label_UserMessage.Left = formCenter - (label_UserMessage.Width / 2);
            label_UserMessage.Top = bufferAmount;

            // Center the text box below the label only if it is enabled and visible
            int currentTop = label_UserMessage.Bottom + (2 * bufferAmount); // Start below the label
            if (textBox_passPhraseInput.Enabled && textBox_passPhraseInput.Visible)
            {
                textBox_passPhraseInput.Left = formCenter - (textBox_passPhraseInput.Width / 2);
                textBox_passPhraseInput.Top = currentTop;
                currentTop = textBox_passPhraseInput.Bottom + (2 * bufferAmount); // Adjust top for the next element
            }

            // Center the buttons below the text box or label, depending on visibility of the text box
            button_Option1.Left = formCenter - (button_Option1.Width / 2);
            button_Option1.Top = currentTop;
            button_Option2.Left = formCenter - (button_Option2.Width / 2);
            button_Option2.Top = button_Option1.Bottom + bufferAmount;

            // Adjust form height based on the positions of the buttons
            int newFormHeight = (button_Option2.Enabled)
                ? button_Option2.Bottom + bufferAmount
                : button_Option1.Bottom + bufferAmount;

            // Clear out the passphrase box only if it is enabled
            if (textBox_passPhraseInput.Enabled && textBox_passPhraseInput.Visible)
            {
                textBox_passPhraseInput.Text = string.Empty;
            }

            this.ClientSize = new Size(this.ClientSize.Width, newFormHeight);
        }






        private void UserMessageForm_Load(object sender, EventArgs e)
        {

            parentForm.TopMost = true;

            // Check for Button status and adjust
            if (!usesBothButtons)
            {
                button_Option2.Enabled = false;
                button_Option2.Visible = false;
            }

            if (!usesPassPhrase)
            {
                textBox_passPhraseInput.Enabled = false;
                textBox_passPhraseInput.Visible = false;
            }

            // Calculate the position to center this form on the parent form
            AdjustAndCenterElements();
            int x = parentForm.Location.X + ((parentForm.Width - this.Width) / 2);
            int y = parentForm.Location.Y + ((parentForm.Height - this.Height) / 2);
            this.Location = new Point(x, y);
        }

        private void button_Option1_Click(object sender, EventArgs e)
        {
            if (textBox_passPhraseInput.Text.ToUpper() == passPhrase.ToUpper())
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                textBox_passPhraseInput.Text = string.Empty;
                //textBox_passPhraseInput.BackColor = Color.LightSalmon;
            }
        }

        private void button_Option2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void UserMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.TopMost = false;
        }

        private void button_Option1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button_Option1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button_Option1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void textBox_passPhraseInput_TextChanged(object sender, EventArgs e)
        {
            textBox_passPhraseInput.BackColor = Color.White;
        }
    }
}
