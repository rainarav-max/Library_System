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
    public partial class StudentMain : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public static User loggedUser = null;
        public StudentMain()
        {
            InitializeComponent();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new LoginForm();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            loggedUser = LoginForm.loggedUser;
            userLbl.Text = "Welcome: " + loggedUser.FullName;
            var bookBindingList = new BindingList<Book>(db.GetAllBooks());
            var bookSource = new BindingSource(bookBindingList, null);
            gvBooks.DataSource = bookSource;
        }

        private void BookBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new StudentBBorrow();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new StudentBDetail();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void MyBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new MyBooks();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
