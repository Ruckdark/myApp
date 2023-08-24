namespace WindowShutdown
{
    partial class formNeatMode
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNeatMode));
            numericUpDownHour = new NumericUpDown();
            btnChangeMode = new Button();
            numericUpDownMinute = new NumericUpDown();
            numericUpDownSecond = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRestart = new Button();
            btnShutDown = new Button();
            btnCancel = new Button();
            labelMain = new Label();
            toolTip = new ToolTip(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.Location = new Point(12, 73);
            numericUpDownHour.Name = "numericUpDownHour";
            numericUpDownHour.Size = new Size(67, 31);
            numericUpDownHour.TabIndex = 0;
            // 
            // btnChangeMode
            // 
            btnChangeMode.Location = new Point(383, 12);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(125, 34);
            btnChangeMode.TabIndex = 6;
            btnChangeMode.Text = "Full mode";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Location = new Point(151, 73);
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(67, 31);
            numericUpDownMinute.TabIndex = 1;
            // 
            // numericUpDownSecond
            // 
            numericUpDownSecond.Location = new Point(305, 73);
            numericUpDownSecond.Name = "numericUpDownSecond";
            numericUpDownSecond.Size = new Size(67, 31);
            numericUpDownSecond.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 79);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 21;
            label1.Text = "hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 79);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 22;
            label2.Text = "minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 79);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 23;
            label3.Text = "seconds";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(151, 136);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 34);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnShutDown
            // 
            btnShutDown.Location = new Point(12, 136);
            btnShutDown.Name = "btnShutDown";
            btnShutDown.Size = new Size(112, 34);
            btnShutDown.TabIndex = 3;
            btnShutDown.Text = "Shut down";
            btnShutDown.UseVisualStyleBackColor = true;
            btnShutDown.Click += btnShutDown_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(288, 136);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMain.Location = new Point(33, 15);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(308, 29);
            labelMain.TabIndex = 28;
            labelMain.Text = "Computer ShutDown Timer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capture;
            pictureBox1.Location = new Point(417, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // formNeatMode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 211);
            Controls.Add(pictureBox1);
            Controls.Add(labelMain);
            Controls.Add(btnCancel);
            Controls.Add(btnShutDown);
            Controls.Add(btnRestart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownSecond);
            Controls.Add(numericUpDownMinute);
            Controls.Add(btnChangeMode);
            Controls.Add(numericUpDownHour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formNeatMode";
            Text = "Neat mode";
            FormClosing += FormNeatMode_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownHour;
        private Button btnChangeMode;
        private NumericUpDown numericUpDownMinute;
        private NumericUpDown numericUpDownSecond;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRestart;
        private Button btnShutDown;
        private Button btnCancel;
        private Label labelMain;
        private ToolTip toolTip;
        private PictureBox pictureBox1;
    }
}