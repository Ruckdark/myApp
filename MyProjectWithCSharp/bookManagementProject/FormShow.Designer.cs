namespace bookManagementProject
{
    partial class FormShow
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
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnVN = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 62;
            this.dataGridViewMain.RowTemplate.Height = 28;
            this.dataGridViewMain.Size = new System.Drawing.Size(560, 464);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMain_CellFormatting);
            this.dataGridViewMain.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewMain_CellValidating);
            this.dataGridViewMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewMain_DataError);
            this.dataGridViewMain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_RowEnter);
            this.dataGridViewMain.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewMain_RowsAdded);
            this.dataGridViewMain.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_RowValidated);
            this.dataGridViewMain.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewMain_RowValidating);
            // 
            // btnEN
            // 
            this.btnEN.AutoEllipsis = true;
            this.btnEN.BackColor = System.Drawing.SystemColors.Control;
            this.btnEN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEN.Location = new System.Drawing.Point(404, 12);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(81, 50);
            this.btnEN.TabIndex = 11;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = false;
            // 
            // btnVN
            // 
            this.btnVN.AutoEllipsis = true;
            this.btnVN.BackColor = System.Drawing.Color.Orange;
            this.btnVN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVN.ForeColor = System.Drawing.Color.Red;
            this.btnVN.Location = new System.Drawing.Point(491, 12);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(81, 50);
            this.btnVN.TabIndex = 12;
            this.btnVN.Text = "VN";
            this.btnVN.UseVisualStyleBackColor = false;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(12, 75);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(66, 25);
            this.lblTittle.TabIndex = 13;
            this.lblTittle.Text = "LIST:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(414, 593);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(106, 35);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(238, 593);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(65, 593);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Save edits";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 654);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.btnVN);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "FormShow";
            this.Text = "FormShow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnVN;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}