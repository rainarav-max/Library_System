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
    public partial class StudentBBorrow : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public static User loggedUser = null;
        public StudentBBorrow()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form1 = new StudentMain();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void StudentBBorrow_Load(object sender, EventArgs e)
        {
            var bookBindingList = new BindingList<Book>(db.GetAllBooks());
            var bookSource = new BindingSource(bookBindingList, null);
            gvBooks.DataSource = bookSource;
            loggedUser = LoginForm.loggedUser;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (gvBooks.SelectedRows.Count != 0)
            {
                string bookid = Convert.ToString(gvBooks.CurrentRow.Cells["BookId"].Value);
                string amount = txtAmount.Text;
                string issuedate = txtIssue.Value.ToString("yyyy-MM-dd");
                string duedate = txtDue.Value.ToString("yyyy-MM-dd");

                BookHistory checkIssue = db.CheckBookIssueToStudent(loggedUser.StudentId, bookid);

                BookHistory bkh = new BookHistory(loggedUser.StudentId, Convert.ToDateTime(issuedate), Convert.ToDateTime(duedate), Convert.ToDouble(amount), "Issued", Convert.ToInt32(bookid));

                if (String.IsNullOrEmpty(bookid) || String.IsNullOrEmpty(amount))
                {
                    MessageBox.Show("Book id and Amount fields are required");
                }
                else
                {
                    if (checkIssue != null)
                    {
                       
                        if (checkIssue.Status.Equals("Returned"))
                        {

                            if (db.IssueBook(bkh))
                            {
                                MessageBox.Show("Book issued successfully!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("This book was issued previously and not yet returned to library. Please return previous book before issueing");
                        }
                    }
                    else
                    {
                        if (db.IssueBook(bkh))
                        {
                            MessageBox.Show("Book issued successfully!");

                        }
                    }
                }
            }
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
