namespace WindowShutdown
{
    partial class FormWindowShutdown
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindowShutdown));
            btnFullMode = new Button();
            btnNeatMode = new Button();
            toolTip = new ToolTip(components);
            contextMenuStrip = new ContextMenuStrip(components);
            btnHide = new ToolStripMenuItem();
            btnExit = new ToolStripMenuItem();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnFullMode
            // 
            btnFullMode.Location = new Point(12, 12);
            btnFullMode.Name = "btnFullMode";
            btnFullMode.Size = new Size(155, 80);
            btnFullMode.TabIndex = 0;
            btnFullMode.Text = "Full Mode";
            toolTip.SetToolTip(btnFullMode, "Enter the interface with full functionality");
            btnFullMode.UseVisualStyleBackColor = true;
            btnFullMode.Click += btnFullMode_Click;
            // 
            // btnNeatMode
            // 
            btnNeatMode.Location = new Point(184, 12);
            btnNeatMode.Name = "btnNeatMode";
            btnNeatMode.Size = new Size(155, 80);
            btnNeatMode.TabIndex = 1;
            btnNeatMode.Text = "Neat Mode";
            toolTip.SetToolTip(btnNeatMode, "Enter the neat interface");
            btnNeatMode.UseVisualStyleBackColor = true;
            btnNeatMode.Click += btnNeatMode_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(24, 24);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { btnHide, btnExit });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(122, 68);
            // 
            // btnHide
            // 
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(121, 32);
            btnHide.Text = "Hide";
            btnHide.Click += Hide_Click;
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 32);
            btnExit.Text = "Exit";
            btnExit.Click += Exit_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = ".";
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // FormWindowShutdown
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(351, 104);
            Controls.Add(btnNeatMode);
            Controls.Add(btnFullMode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormWindowShutdown";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Window Shutdown";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Button btnFullMode;
        private Button btnNeatMode;
        private ToolTip toolTip;
        private ContextMenuStrip contextMenuStrip;
        private NotifyIcon notifyIcon;
        private ToolStripMenuItem btnHide;
        private ToolStripMenuItem btnExit;
    }
}