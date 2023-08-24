namespace bookManagementProject
{
    partial class FormMain
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnVN = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(15, 128);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(345, 29);
            this.lblTittle.TabIndex = 12;
            this.lblTittle.Text = "ENTER BOOK INFORMATION";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.txbAuthor);
            this.pnlMain.Controls.Add(this.txbName);
            this.pnlMain.Controls.Add(this.txbPrice);
            this.pnlMain.Controls.Add(this.lblAuthor);
            this.pnlMain.Controls.Add(this.lblPrice);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Location = new System.Drawing.Point(20, 160);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(752, 261);
            this.pnlMain.TabIndex = 11;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(521, 193);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 35);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show list";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(327, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(152, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(187, 130);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(511, 26);
            this.txbAuthor.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(187, 21);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(511, 26);
            this.txbName.TabIndex = 1;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(187, 76);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(511, 26);
            this.txbPrice.TabIndex = 2;
            this.txbPrice.TextChanged += new System.EventHandler(this.txbPrice_TextChanged);
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(29, 133);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(73, 23);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(29, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnEN
            // 
            this.btnEN.AutoEllipsis = true;
            this.btnEN.BackColor = System.Drawing.SystemColors.Control;
            this.btnEN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEN.Location = new System.Drawing.Point(617, 30);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(81, 50);
            this.btnEN.TabIndex = 7;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = false;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnVN
            // 
            this.btnVN.AutoEllipsis = true;
            this.btnVN.BackColor = System.Drawing.Color.Orange;
            this.btnVN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVN.ForeColor = System.Drawing.Color.Red;
            this.btnVN.Location = new System.Drawing.Point(704, 30);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(81, 50);
            this.btnVN.TabIndex = 8;
            this.btnVN.Text = "VN";
            this.btnVN.UseVisualStyleBackColor = false;
            this.btnVN.Click += new System.EventHandler(this.btnVN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.btnVN);
            this.Name = "FormMain";
            this.Text = "Book Management";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnVN;
    }
}

