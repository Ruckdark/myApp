namespace WindowShutdown
{
    partial class formFullMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFullMode));
            btn5minutes = new Button();
            btn10minutes = new Button();
            btn20minutes = new Button();
            btn30minutes = new Button();
            btn1Hours = new Button();
            btn2Hours = new Button();
            btn3Hours = new Button();
            btn5Hours = new Button();
            btnSelfSetup = new Button();
            textBoxHour = new TextBox();
            textBoxMinute = new TextBox();
            textBoxSecond = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            labelMain = new Label();
            btnReset = new Button();
            btnChangeMode = new Button();
            toolTip = new ToolTip(components);
            pictureBox1 = new PictureBox();
            btnSleep = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn5minutes
            // 
            btn5minutes.Location = new Point(12, 115);
            btn5minutes.Name = "btn5minutes";
            btn5minutes.Size = new Size(112, 34);
            btn5minutes.TabIndex = 0;
            btn5minutes.Text = "5 minutes";
            btn5minutes.UseVisualStyleBackColor = true;
            btn5minutes.Click += btn5minutes_Click;
            // 
            // btn10minutes
            // 
            btn10minutes.Location = new Point(188, 115);
            btn10minutes.Name = "btn10minutes";
            btn10minutes.Size = new Size(112, 34);
            btn10minutes.TabIndex = 1;
            btn10minutes.Text = "10 minutes";
            btn10minutes.UseVisualStyleBackColor = true;
            btn10minutes.Click += btn10minutes_Click;
            // 
            // btn20minutes
            // 
            btn20minutes.Location = new Point(366, 115);
            btn20minutes.Name = "btn20minutes";
            btn20minutes.Size = new Size(112, 34);
            btn20minutes.TabIndex = 2;
            btn20minutes.Text = "20 minutes";
            btn20minutes.UseVisualStyleBackColor = true;
            btn20minutes.Click += btn20minutes_Click;
            // 
            // btn30minutes
            // 
            btn30minutes.Location = new Point(540, 115);
            btn30minutes.Name = "btn30minutes";
            btn30minutes.Size = new Size(112, 34);
            btn30minutes.TabIndex = 3;
            btn30minutes.Text = "30 minutes";
            btn30minutes.UseVisualStyleBackColor = true;
            btn30minutes.Click += btn30minutes_Click;
            // 
            // btn1Hours
            // 
            btn1Hours.Location = new Point(12, 206);
            btn1Hours.Name = "btn1Hours";
            btn1Hours.Size = new Size(112, 34);
            btn1Hours.TabIndex = 4;
            btn1Hours.Text = "1 hours";
            btn1Hours.UseVisualStyleBackColor = true;
            btn1Hours.Click += btn1Hours_Click;
            // 
            // btn2Hours
            // 
            btn2Hours.Location = new Point(188, 206);
            btn2Hours.Name = "btn2Hours";
            btn2Hours.Size = new Size(112, 34);
            btn2Hours.TabIndex = 5;
            btn2Hours.Text = "2 hours";
            btn2Hours.UseVisualStyleBackColor = true;
            btn2Hours.Click += btn2Hours_Click;
            // 
            // btn3Hours
            // 
            btn3Hours.Location = new Point(366, 206);
            btn3Hours.Name = "btn3Hours";
            btn3Hours.Size = new Size(112, 34);
            btn3Hours.TabIndex = 6;
            btn3Hours.Text = "3 hours";
            btn3Hours.UseVisualStyleBackColor = true;
            btn3Hours.Click += btn3Hours_Click;
            // 
            // btn5Hours
            // 
            btn5Hours.Location = new Point(540, 206);
            btn5Hours.Name = "btn5Hours";
            btn5Hours.Size = new Size(112, 34);
            btn5Hours.TabIndex = 7;
            btn5Hours.Text = "5 hours";
            btn5Hours.UseVisualStyleBackColor = true;
            btn5Hours.Click += btn5Hours_Click;
            // 
            // btnSelfSetup
            // 
            btnSelfSetup.Location = new Point(12, 326);
            btnSelfSetup.Name = "btnSelfSetup";
            btnSelfSetup.Size = new Size(112, 34);
            btnSelfSetup.TabIndex = 11;
            btnSelfSetup.Text = "Self-Setup";
            btnSelfSetup.UseVisualStyleBackColor = true;
            btnSelfSetup.Click += btnSelfSetup_Click;
            // 
            // textBoxHour
            // 
            textBoxHour.Location = new Point(160, 328);
            textBoxHour.Name = "textBoxHour";
            textBoxHour.Size = new Size(50, 31);
            textBoxHour.TabIndex = 8;
            textBoxHour.Text = "hour";
            textBoxHour.MouseClick += textBoxHour_MouseClick;
            // 
            // textBoxMinute
            // 
            textBoxMinute.Location = new Point(238, 328);
            textBoxMinute.Name = "textBoxMinute";
            textBoxMinute.Size = new Size(62, 31);
            textBoxMinute.TabIndex = 9;
            textBoxMinute.Text = "minute";
            textBoxMinute.MouseClick += textBoxMinute_MouseClick;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(328, 328);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(63, 31);
            textBoxSecond.TabIndex = 10;
            textBoxSecond.Text = "second";
            textBoxSecond.MouseClick += textBoxSecond_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 334);
            label1.Name = "label1";
            label1.Size = new Size(16, 25);
            label1.TabIndex = 12;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 334);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 13;
            label2.Text = ":";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(474, 326);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 93);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMain.Location = new Point(98, 21);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(308, 29);
            labelMain.TabIndex = 15;
            labelMain.Text = "Computer ShutDown Timer";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(98, 385);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnChangeMode
            // 
            btnChangeMode.Location = new Point(483, 21);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(125, 34);
            btnChangeMode.TabIndex = 15;
            btnChangeMode.Text = "Neat mode";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capture;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnSleep
            // 
            btnSleep.Location = new Point(279, 385);
            btnSleep.Name = "btnSleep";
            btnSleep.Size = new Size(112, 34);
            btnSleep.TabIndex = 13;
            btnSleep.Text = "Sleep";
            btnSleep.UseVisualStyleBackColor = true;
            btnSleep.Click += btnSleep_Click;
            // 
            // formFullMode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 445);
            Controls.Add(btnSleep);
            Controls.Add(pictureBox1);
            Controls.Add(btnChangeMode);
            Controls.Add(btnReset);
            Controls.Add(labelMain);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxMinute);
            Controls.Add(textBoxHour);
            Controls.Add(btnSelfSetup);
            Controls.Add(btn5Hours);
            Controls.Add(btn3Hours);
            Controls.Add(btn2Hours);
            Controls.Add(btn1Hours);
            Controls.Add(btn30minutes);
            Controls.Add(btn20minutes);
            Controls.Add(btn10minutes);
            Controls.Add(btn5minutes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formFullMode";
            Text = "Full mode";
            FormClosing += FormFullMode_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn5minutes;
        private Button btn10minutes;
        private Button btn20minutes;
        private Button btn30minutes;
        private Button btn1Hours;
        private Button btn2Hours;
        private Button btn3Hours;
        private Button btn5Hours;
        private Button btnSelfSetup;
        private TextBox textBoxHour;
        private TextBox textBoxMinute;
        private TextBox textBoxSecond;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private Label labelMain;
        private Button btnReset;
        private Button btnChangeMode;
        private ToolTip toolTip;
        private PictureBox pictureBox1;
        private Button btnSleep;
    }
}