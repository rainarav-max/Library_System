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
    public partial class BookReturn : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public BookReturn()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = txtBook.Text.Trim();
                string studentid = txtStudent.Text.Trim();
                string returndate = txtDate.Value.ToString("yyyy-MM-dd");
              

                if (String.IsNullOrEmpty(bookid) || String.IsNullOrEmpty(studentid))
                {
                    MessageBox.Show("Book id and Student Id fields are required");
                }
                else
                {
                    BookHistory checkIssue = db.CheckBookIssueToStudent(studentid, bookid);

                    if (checkIssue != null)
                    {
                        txtStatus.Text = checkIssue.Status;
                        if (checkIssue.Status.Equals("Issued"))
                        {
                            BookHistory bkh = new BookHistory(checkIssue.HistoryId, Convert.ToDateTime(returndate),checkIssue.Balance, "Returned");

                            if (db.ReturnBook(bkh))
                            {
                                MessageBox.Show("Book returned successfully!");
                                txtBook.Text = ""; txtStudent.Text = "";
                                txtStatus.Text = ""; 
                            }
                        }
                        else
                        {
                            MessageBox.Show("This book wsa already returned previously. Thanks for your patience");
                        }
                    }
                    else
                    {
                        txtStatus.Text = "Issued Book doesnot exists";
                       MessageBox.Show("Issued Book doesnot exists");
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
