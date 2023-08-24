using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bookManagementProject
{
    public partial class FormMain : Form
    {
        bookManagementEntities db = new bookManagementEntities();
        static int idKey;
        FormShow formShow;
        public FormMain()
        {
            InitializeComponent();
        }

        #region methods
        void LoadData()
        {

        }

        void SaveData(int key)
        {
            try
            {

                db.books.Add(new book() { id = key++, name = txbName.Text, price = float.Parse(txbPrice.Text), author = txbAuthor.Text });
                db.SaveChanges();

                MessageBox.Show("Data saved successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UpdateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region events
        private void btnVN_Click(object sender, EventArgs e)
        {
            this.Text = "Quản Lý sách";
            lblName.Text = "Tên:";
            lblPrice.Text = "Giá tiền:";
            lblTittle.Text = "NHẬP VÀO THÔNG TIN SÁCH";
            lblAuthor.Text = "Tác giả:";
            btnSave.Text = "Lưu";
            btnDelete.Text = "Xoá";
            btnShow.Text = "Hiển thị d/s";
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            this.Text = "Book Management";
            lblName.Text = "Name:";
            lblPrice.Text = "Price:";
            lblTittle.Text = "ENTER BOOK INFORMATION";
            lblAuthor.Text = "Author:";
            btnSave.Text = "Save";
            btnDelete.Text = "Delete";
            btnShow.Text = "Show";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idKey = db.books.Count();
            SaveData(idKey);       
        }
        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbPrice_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị của TextBox
            string text = txbPrice.Text;

            // Loại bỏ các ký tự không phải là số
            text = new string(text.Where(c => char.IsDigit(c)).ToArray());

            // Cập nhật giá trị của TextBox
            txbPrice.Text = text;

            // Di chuyển con trỏ về cuối TextBox
            txbPrice.SelectionStart = txbPrice.Text.Length;
        }


        #endregion

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (formShow == null)
            {
                formShow = new FormShow();
            }
            formShow.Show();
        }
    }
}
