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
    public partial class RegisterBook : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public RegisterBook()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "";
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
                    Book obj = new Book(isbn, title, author, publisher, category, language, edition, shelf, pages, Convert.ToDouble(price), year, description, Convert.ToDateTime(date));

                    if (db.AddBook(obj))
                    {
                        MessageBox.Show("Book added to library system!");
                        txtIsbn.Text = "";
                        txtTitle.Text = ""; txtAuthor.Text = "";
                        txtPublisher.Text = ""; txtCategory.Text = "";
                        txtDescription.Text = ""; txtLanguage.Text = "";
                        txtPrice.Text = ""; txtPages.Text = "";
                        txtEdition.Text = ""; txtYear.Text = ""; txtShelf.Text = "";

                    }
                    else
                        MessageBox.Show("Unable to add Book. Please try again!");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
