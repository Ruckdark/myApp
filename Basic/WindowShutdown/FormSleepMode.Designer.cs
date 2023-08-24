namespace WindowShutdown
{
    partial class formSleepMode
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
            btnSuspend = new Button();
            btnHibernate = new Button();
            SuspendLayout();
            // 
            // btnSuspend
            // 
            btnSuspend.Location = new Point(12, 12);
            btnSuspend.Name = "btnSuspend";
            btnSuspend.Size = new Size(135, 67);
            btnSuspend.TabIndex = 0;
            btnSuspend.Text = "Suspend";
            btnSuspend.UseVisualStyleBackColor = true;
            btnSuspend.Click += btnSuspend_Click;
            // 
            // btnHibernate
            // 
            btnHibernate.Location = new Point(153, 12);
            btnHibernate.Name = "btnHibernate";
            btnHibernate.Size = new Size(135, 67);
            btnHibernate.TabIndex = 1;
            btnHibernate.Text = "Hibernate";
            btnHibernate.UseVisualStyleBackColor = true;
            btnHibernate.Click += btnHibernate_Click;
            // 
            // formSleepMode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 90);
            Controls.Add(btnHibernate);
            Controls.Add(btnSuspend);
            Name = "formSleepMode";
            Text = "Sleep Mode";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSuspend;
        private Button btnHibernate;
    }
}