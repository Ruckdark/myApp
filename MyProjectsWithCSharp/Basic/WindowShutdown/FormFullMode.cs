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
    public partial class formFullMode : Form
    {
        formNeatMode formNeatMode;
        formSleepMode formSleepMode;
        int hourValue, minuteValue, secondValue;
        public formFullMode()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public formFullMode(ref formNeatMode formNeatMode)
        {
            this.formNeatMode = formNeatMode;
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (formNeatMode == null)
                formNeatMode = new formNeatMode();
            formNeatMode.Show();
            this.Dispose();
        }

        private void FormFullMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn5minutes_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 300");
        }

        private void btn10minutes_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 600");
        }

        private void btn20minutes_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 1200");
        }

        private void btn30minutes_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 1800");
        }

        private void btn1Hours_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 3600");
        }

        private void btn2Hours_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 7200");
        }

        private void btn3Hours_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 10800");
        }

        private void btn5Hours_Click(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "-a");
            Process.Start("shutdown", "/s /t 18000");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            MessageBox.Show("Command canceled!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelfSetup_Click(object sender, EventArgs e)
        {
            if (hourValueException() == false || minuteValueException() == false || secondValueException() == false)
            {

            }
            else
            {
                if (hourValue == 0 && minuteValue == 0 && secondValue == 0)
                {
                    MessageBox.Show("Total time = 0 -> Shut down\n<Hours = 0> <Minutes = 0> <Seconds = 0>", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int totalSecond = (hourValue * 3600) + (minuteValue * 60) + secondValue;
                    Process.Start("shutdown", "-s -t " + Convert.ToString(totalSecond));
                }
            }
        }

        private bool hourValueException()
        {
            try
            {
                if (!textBoxHour.Text.Equals(""))
                {
                    hourValue = Convert.ToInt32(textBoxHour.Text);
                }
                else if (textBoxHour.Text.Equals(""))
                {
                    hourValue = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Integer <hour> format error!", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
            }
            return true;
        }

        private bool minuteValueException()
        {
            try
            {
                if (!textBoxMinute.Text.Equals(""))
                {
                    minuteValue = Convert.ToInt32(textBoxMinute.Text);
                }
                else if (textBoxHour.Text.Equals(""))
                {
                    minuteValue = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Integer <minute> format error!", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
            }
            return true;
        }

        private bool secondValueException()
        {
            try
            {
                if (!textBoxSecond.Text.Equals(""))
                {
                    secondValue = Convert.ToInt32(textBoxSecond.Text);
                }
                else if (textBoxSecond.Text.Equals(""))
                {
                    secondValue = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Integer <second> format error!", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
            }
            return true;
        }
        private void textBoxHour_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxHour.Text = "";
        }

        private void textBoxMinute_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxMinute.Text = "";
        }

        private void textBoxSecond_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSecond.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxHour.Text = "hour";
            textBoxMinute.Text = "minute";
            textBoxSecond.Text = "second";
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (formSleepMode == null)
            {
                formSleepMode = new formSleepMode();
            }
            formSleepMode.ShowDialog();
        }
    }
}
