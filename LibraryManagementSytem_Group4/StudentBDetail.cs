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
    public partial class StudentBDetail : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public static User loggedUser = null;
        public StudentBDetail()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var form1 = new StudentMain();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvBookHistory.SelectedRows.Count != 0)
                {
                    string historyId = Convert.ToString(gvBookHistory.CurrentRow.Cells["BookHistoryId"].Value);
                    string bookid = Convert.ToString(gvBookHistory.CurrentRow.Cells["BookId"].Value);
                    string studentid = loggedUser.StudentId;
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
                            
                            if (checkIssue.Status.Equals("Issued"))
                            {
                                BookHistory bkh = new BookHistory(checkIssue.HistoryId, Convert.ToDateTime(returndate), checkIssue.Balance, "Returned");

                                if (db.ReturnBook(bkh))
                                {
                                    MessageBox.Show("Book returned successfully!");
                                    populate();
                                }
                            }
                            else
                            {
                                MessageBox.Show("This book wsa already returned previously. Thanks for your patience");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Issued Book doesnot exists");
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void StudentBDetail_Load(object sender, EventArgs e)
        {
            loggedUser = LoginForm.loggedUser;

            populate();
        }
        private void populate()
        {
            var bookBindingList = new BindingList<BookHistory>(db.GetAllBookHistoryByStudent(loggedUser.StudentId));
            var bookSource = new BindingSource(bookBindingList, null);

            gvBookHistory.AutoGenerateColumns = false;
            gvBookHistory.Columns.Add("BookHistoryId", "History Id");
            gvBookHistory.Columns.Add("BookId", "Book Id");
            gvBookHistory.Columns.Add("StudentId", "Student Id");
            gvBookHistory.Columns.Add("Title", "Book Title");
            gvBookHistory.Columns.Add("Author", "Book Author");
            gvBookHistory.Columns.Add("Publisher", "Publisher");
            gvBookHistory.Columns.Add("IssueDate", "Issue Date");
            gvBookHistory.Columns.Add("DueDate", "Due Date");
            gvBookHistory.Columns.Add("ReturnDate", "Return Date");
            gvBookHistory.Columns.Add("Status", "Status");

            gvBookHistory.Columns["BookHistoryId"].DataPropertyName = "HistoryId";
            gvBookHistory.Columns["BookId"].DataPropertyName = "BookId";
            gvBookHistory.Columns["StudentId"].DataPropertyName = "StudentId";
            gvBookHistory.Columns["Title"].DataPropertyName = "Title";
            gvBookHistory.Columns["Author"].DataPropertyName = "Author";
            gvBookHistory.Columns["Publisher"].DataPropertyName = "Publisher";
            gvBookHistory.Columns["IssueDate"].DataPropertyName = "IssueDate";
            gvBookHistory.Columns["DueDate"].DataPropertyName = "DueDate";
            gvBookHistory.Columns["ReturnDate"].DataPropertyName = "ReturnDate";
            gvBookHistory.Columns["Status"].DataPropertyName = "Status";

            gvBookHistory.DataSource = bookSource;
        }
    }
}
