
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;
using System.Data.Entity;

namespace bookManagementProject
{
    public partial class FormShow : Form
    {
        bookManagementEntities db = new bookManagementEntities();
        int idCheck = 0;
        //BindingSource bindingSource = new BindingSource();

        public FormShow()
        {
            InitializeComponent();
            LoadData();
            
        }

        #region methods
        void LoadData()
        {
            dataGridViewMain.ReadOnly = false;
            dataGridViewMain.AllowUserToAddRows = true;
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindingData();
            dataGridViewMain.Columns["id"].ReadOnly = true;
            
        }

        void BindingData()
        {
            var books = db.books.ToList();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = books;
            dataGridViewMain.DataSource = bindingSource;
            idCheck = ((List<book>)bindingSource.DataSource).Max(x => x.id);
            
        }
        
        

        #endregion

        #region events
        private void FormShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //db.books.AddOrUpdate();
            //var bookList = (List<book>)bindingSource.DataSource;
            var bindingSource = (BindingSource)dataGridViewMain.DataSource;
            var bookList = (List<book>)bindingSource.DataSource;
            //db.books.AddOrUpdate(bookList.ToArray());
            foreach (var item in bookList)
            {
                var existingBook = db.books.Find(item.id);
                if (existingBook != null)
                {
                    db.Entry(existingBook).CurrentValues.SetValues(item);
                }
                else
                {
                    db.books.Add(item);

                }
            }
            db.SaveChanges();
        }
        private void dataGridViewMain_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewMain.Columns[e.ColumnIndex].Name == "price")
            {
                if (!((string)e.FormattedValue).Equals(null) || !((string)e.FormattedValue).Equals("")) //TODO
                {
                    string priceText = e.FormattedValue.ToString();
                    if (!double.TryParse(priceText, out double price))
                    {
                        MessageBox.Show("Price must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                
            }
        }
        #region TODO
        private void dataGridViewMain_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            
            //if (dataGridViewMain.Rows[e.RowIndex].IsNewRow)
            //{                             
            //    string name = (string)dataGridViewMain.Rows[e.RowIndex].Cells["name"].Value;
            //    string price = (string)dataGridViewMain.Rows[e.RowIndex].Cells["price"].Value;
            //    string author = (string)dataGridViewMain.Rows[e.RowIndex].Cells["author"].Value;
            //    if (string.IsNullOrEmpty(name))
            //    {
            //        MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Cancel = true;
            //    }
            //    if (string.IsNullOrEmpty(price))
            //    {
            //        MessageBox.Show("Price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Cancel = true;
            //    }
            //    if (string.IsNullOrEmpty(author))
            //    {
            //        MessageBox.Show("Author is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Cancel = true;
            //    }
            //}
        }
        #endregion

        private void dataGridViewMain_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridViewMain.Rows[e.RowIndex].IsNewRow)
            {
                
                string idStr = (string)dataGridViewMain.Rows[e.RowIndex].Cells["id"].Value;
                string nameStr = (string)dataGridViewMain.Rows[e.RowIndex].Cells["name"].Value;
                string priceStr = (string)dataGridViewMain.Rows[e.RowIndex].Cells["price"].Value;
                string authorStr = (string)dataGridViewMain.Rows[e.RowIndex].Cells["author"].Value;
                //db.books.Add(new book() { id = Convert.ToInt32(idStr), name = nameStr, price = float.Parse(priceStr), author = authorStr });
            }
            
        }

        private void dataGridViewMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //// Lấy danh sách các đối tượng book từ DataSource của DataGridView

            //var bindingSource = (BindingSource)dataGridViewMain.DataSource;
            //var bookList = (List<book>)bindingSource.DataSource;

            //// Tìm giá trị id lớn nhất hiện tại
            //int maxId = bookList.Max(b => b.id);

            //// Cập nhật giá trị id cho các hàng mới được thêm vào
            //for (int i = 0; i < e.RowCount; i++)
            //{
            //    int rowIndex = e.RowIndex + i;

            //    // Kiểm tra xem người dùng đã nhập đủ dữ liệu cho hàng mới hay chưa
            //    if (rowIndex < bookList.Count)
            //    {
            //        var book = bookList[rowIndex];

            //        // Kiểm tra xem đối tượng book có được theo dõi bởi DbContext hay không
            //        if (db.Entry(book).State == EntityState.Detached)
            //        {
            //            book.id = ++maxId;
            //        }
            //    }
            //}

            
        }
        #endregion

        private void dataGridViewMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void dataGridViewMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //// Kiểm tra xem có phải là cột Id hay không
            //if (dataGridViewMain.Columns[e.ColumnIndex].Name == "id")
            //{
            //    // Định dạng giá trị hiển thị
            //    e.Value = e.RowIndex;
            //} //TODO
        }

        private void dataGridViewMain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy danh sách các đối tượng book từ DataSource của DataGridView
            //bindingSource = (BindingSource)dataGridViewMain.DataSource;
            //var bookList = (List<book>)bindingSource.DataSource;

            // Tìm giá trị id lớn nhất hiện tại
            //int maxId = bookList.Max(b => b.id);

            // Cập nhật giá trị id cho hàng hiện tại
            //bookList[e.RowIndex].id = idCheck++;
            
        }
    }
}