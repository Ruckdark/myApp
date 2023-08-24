using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowShutdown
{
    public partial class formNeatMode : Form
    {
        formFullMode formFullMode;
        int hourValue, minuteValue, secondValue;
        public formNeatMode()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public formNeatMode(ref formFullMode formFullMode)
        {
            this.formFullMode = formFullMode;
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormNeatMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            hourValue = ((int)numericUpDownHour.Value);
            minuteValue = ((int)numericUpDownMinute.Value);
            secondValue = ((int)numericUpDownSecond.Value);
            if (hourValue == 0 && minuteValue == 0 && secondValue == 0)
            {
                MessageBox.Show("Hours, minutes, and seconds cannot be left blank", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int totalSeconds = (hourValue * 3600) + (minuteValue * 60) + secondValue;
                try
                {
                    Process.Start("shutdown", "-s -t " + Convert.ToString(totalSeconds));
                }
                catch (Exception)
                {

                    throw;
                }
            }


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            hourValue = ((int)numericUpDownHour.Value);
            minuteValue = ((int)numericUpDownMinute.Value);
            secondValue = ((int)numericUpDownSecond.Value);
            if (hourValue == 0 && minuteValue == 0 && secondValue == 0)
            {
                MessageBox.Show("Hours, minutes, and seconds cannot be left blank", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int totalSeconds = (hourValue * 3600) + (minuteValue * 60) + secondValue;
                try
                {
                    Process.Start("shutdown", "-r -t " + Convert.ToString(totalSeconds));
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            MessageBox.Show("Command canceled!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (formFullMode == null)
                formFullMode = new formFullMode();
            formFullMode.Show();
            this.Dispose();

        }
    }
}
