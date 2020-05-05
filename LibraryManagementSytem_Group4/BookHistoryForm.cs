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
    public partial class BookHistoryForm : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public BookHistoryForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BookHistoryForm_Load(object sender, EventArgs e)
        {
            var bookBindingList = new BindingList<BookHistory>(db.GetAllBookHistory());
            var bookSource = new BindingSource(bookBindingList, null);
            
            gvBookHistory.AutoGenerateColumns = false;
            gvBookHistory.Columns.Add("BookHistoryId", "History Id");
            gvBookHistory.Columns.Add("StudentId", "Student Id");
            gvBookHistory.Columns.Add("Title", "Book Title");
            gvBookHistory.Columns.Add("Author", "Book Author");
            gvBookHistory.Columns.Add("Publisher", "Publisher");
            gvBookHistory.Columns.Add("IssueDate", "Issue Date");
            gvBookHistory.Columns.Add("DueDate", "Due Date");
            gvBookHistory.Columns.Add("ReturnDate", "Return Date");
            gvBookHistory.Columns.Add("Status", "Status");

            gvBookHistory.Columns["BookHistoryId"].DataPropertyName = "HistoryId";
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
