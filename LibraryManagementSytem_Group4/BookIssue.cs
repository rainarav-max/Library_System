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
    public partial class BookIssue : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public BookIssue()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = txtBookId.Text.Trim();
                string studentid = txtStudentId.Text.Trim();
                if(String.IsNullOrEmpty(bookid) || String.IsNullOrEmpty(studentid))
                {
                    MessageBox.Show("Book id and Student Id fields are required");
                }
                else
                {
                    Book book = db.GetBookById(bookid);
                    Student student = db.GetStudentById(studentid);

                    if (book != null)
                    {
                        txt1.Text = ""+ book.BookId;
                        txt5.Text = book.Title;
                        txt2.Text = book.Author;
                    }
                    else
                    {
                        txt1.Text = "";
                        txt5.Text = "";
                        txt2.Text = "";
                        MessageBox.Show("Book doesnot exists with given id");

                    }
                       

                    if (student != null)
                    {
                        txt3.Text =  student.StudentId;
                        txt4.Text = student.Name;
                    }
                    else
                    {
                        txt3.Text = "";
                        txt4.Text = "";
                        MessageBox.Show("Student doesnot exists with given id");
                    }
                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = txt1.Text.Trim();
                string studentid = txt3.Text.Trim();
                string issuedate = txtIssue.Value.ToString("yyyy-MM-dd");
                string duedate = txtDue.Value.ToString("yyyy-MM-dd");
                string amount = txtAmount.Text.Trim();

                if (String.IsNullOrEmpty(bookid) || String.IsNullOrEmpty(studentid) || String.IsNullOrEmpty(amount))
                {
                    MessageBox.Show("Book id and Student Id and Amount fields are required");
                }
                else
                {
                    BookHistory bkh = new BookHistory(studentid, Convert.ToDateTime(issuedate), Convert.ToDateTime(duedate), Convert.ToDouble(amount), "Issued",  Convert.ToInt32(bookid));
                    BookHistory checkIssue = db.CheckBookIssueToStudent(studentid, bookid);
                 
                    if (checkIssue != null){
                        if (checkIssue.Status.Equals("Returned"))
                        {
                           if (db.IssueBook(bkh))
                            {
                                MessageBox.Show("Book issued successfully!");
                                txt1.Text = ""; txt2.Text = "";
                                txt3.Text = ""; txt5.Text = "";
                                txt4.Text = ""; txtAmount.Text = "";
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
                            txt1.Text = ""; txt2.Text = "";
                            txt3.Text = ""; txt5.Text = "";
                            txt4.Text = ""; txtAmount.Text = "";
                        }
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
