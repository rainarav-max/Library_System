using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem_Group4
{
    public partial class BookInfo : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public BookInfo()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // cancel
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // delete
            try
            {
                string bookid = txtBookId.Text.Trim();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation Dialog", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (db.DeleteBook(bookid))
                    {
                        MessageBox.Show("Book deleted from library system!");
                        txtIsbn.Text = ""; txtBookId.Text = "";
                        txtTitle.Text = ""; txtAuthor.Text = "";
                        txtPublisher.Text = ""; txtCategory.Text = "";
                        txtDescription.Text = ""; txtLanguage.Text = "";
                        txtPrice.Text = ""; txtPages.Text = "";
                        txtEdition.Text = ""; txtYear.Text = ""; txtShelf.Text = "";
                        var bookBindingList = new BindingList<Book>(db.GetAllBooks());
                        var bookSource = new BindingSource(bookBindingList, null);
                        gvBooks.DataSource = bookSource;

                    }
                    else
                        MessageBox.Show("Unable to delete Book. Please try again!");
                }
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // update
            try
            {
                string message = "";
                string bookid = txtBookId.Text.Trim();
                string isbn = txtIsbn.Text.Trim();
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                string publisher = txtPublisher.Text.Trim();
                string category = txtCategory.Text.Trim();
                string description = txtDescription.Text.Trim();
                string language = txtLanguage.Text.Trim();
                string price = txtPrice.Text.Trim();
                string pages = txtPages.Text.Trim();
                string edition = txtEdition.Text.Trim();
                string shelf = txtShelf.Text.Trim();
                string year = txtYear.Text.Trim();
                string date = txtDate.Value.ToString("yyyy-MM-dd");

                message += String.IsNullOrEmpty(isbn) ? "Isbn number is required!\n" : "";
                message += String.IsNullOrEmpty(title) ? "Book Title is required!\n" : "";
                message += String.IsNullOrEmpty(price) ? "Price is required!\n" : "";

                if (message != string.Empty)
                    MessageBox.Show(message);
                else
                {
                    Book obj = new Book(Convert.ToInt32(bookid),isbn, title, author, publisher, category, language, edition, shelf, pages, Convert.ToDouble(price), year, description, Convert.ToDateTime(date));

                    if (db.UpdateBook(obj))
                    {
                        MessageBox.Show("Book update in library system!");
                        var bookBindingList = new BindingList<Book>(db.GetAllBooks());
                        var bookSource = new BindingSource(bookBindingList, null);
                        gvBooks.DataSource = bookSource;
                    }
                    else
                        MessageBox.Show("Unable to update Boo. Please try again!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            var bookBindingList = new BindingList<Book>(db.GetAllBooks());
            var bookSource = new BindingSource(bookBindingList, null);
            gvBooks.DataSource = bookSource;
        }

        private void GvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (gvBooks.SelectedRows.Count != 0)
            {
                string bookid = Convert.ToString(gvBooks.CurrentRow.Cells["BookId"].Value);
                Book book = db.GetBookById(bookid);

                txtBookId.Text = ""+book.BookId;
                txtIsbn.Text = book.ISBN;
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtPublisher.Text = book.Publisher;
                txtCategory.Text = book.Category;
                txtDescription.Text = book.Description;
                txtLanguage.Text = book.Language;
                txtPrice.Text = ""+book.Price;
                txtEdition.Text = book.Edition;
                txtYear.Text = book.Year;
                txtPages.Text = book.Pages;
                txtDate.Value = book.AddedDate;
                
            }
        }
    }
}
