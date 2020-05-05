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
    public partial class Form1 : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public static User loggedUser = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loggedUser = LoginForm.loggedUser;
            userLbl.Text = "Welcome: "+ loggedUser.FullName;
            var studentBindingList = new BindingList<Student>(db.GetAllStudents());
            var studentSource = new BindingSource(studentBindingList, null);
            var bookBindingList = new BindingList<Book>(db.GetAllBooks());
            var bookSource = new BindingSource(bookBindingList, null);
            gvStudents.DataSource = studentSource;
            gvBooks.DataSource = bookSource;
        }

        private void BookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void RegisterANewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new RegisterStudent();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new LoginForm();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void RegisterANewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new RegisterBook();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new BookIssue();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new BookReturn();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void IssuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new BookHistoryForm();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void ReturnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new BookInfo();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new StudentInfo();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void RegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
