using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowShutdown
{
    public partial class formSleepMode : Form
    {
        public formSleepMode()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to enable the laptop sleep mode?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Suspend, false, false); 
            }
        }


        private void btnHibernate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to enable hibernation of your laptop?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Hibernate, false, false);
            }
        }
    }
}
