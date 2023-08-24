namespace WindowShutdown
{
    public partial class FormWindowShutdown : Form
    {
        public formFullMode formFullMode;
        public formNeatMode formNeatMode;

        public FormWindowShutdown()
        {
            InitializeComponent();
            //notifyIcon1.ShowBalloonTip(5000);
        }
        public FormWindowShutdown(ref formFullMode formFullMode, ref formNeatMode formNeatMode)
        {
            InitializeComponent();
            this.formFullMode = formFullMode;
            this.formNeatMode = formNeatMode;
        }

        private void btnFullMode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (formFullMode == null)
                formFullMode = new formFullMode();
            formFullMode.Show();
        }

        private void btnNeatMode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (formNeatMode == null)
                formNeatMode = new formNeatMode();
            formNeatMode.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (formFullMode != null)
            {
                formFullMode.Hide();
                formFullMode.Visible = false;
            }
            if (formNeatMode != null)
            {
                formNeatMode.Hide();
                formNeatMode.Visible = false;
            }
            this.Visible = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (formFullMode != null)
            {
                formFullMode.Hide();
            }
            if (formNeatMode != null)
            {
                formNeatMode.Hide();
            }
            this.Visible = !this.Visible;

        }
    }
}