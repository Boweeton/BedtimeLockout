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

            CenterControlHorizontally(groupBox_DaySettings,this);
            CenterControlHorizontally(button_SaveClose,this);
            CenterControlHorizontally(button_CancelClose,this);

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
            textBox3.Text = textBox3.Text=="AM" ? "PM" : "AM";
        }
    }
}
