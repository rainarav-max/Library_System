namespace LibraryManagementSytem_Group4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerANewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerANewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLbl = new System.Windows.Forms.Label();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.gvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.issuedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.bookDetailToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.bookIssueToolStripMenuItem,
            this.bookReturnToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerANewStudentToolStripMenuItem,
            this.registerANewBookToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.RegistrationToolStripMenuItem_Click);
            // 
            // registerANewStudentToolStripMenuItem
            // 
            this.registerANewStudentToolStripMenuItem.Name = "registerANewStudentToolStripMenuItem";
            this.registerANewStudentToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registerANewStudentToolStripMenuItem.Text = "Register a New Student ";
            this.registerANewStudentToolStripMenuItem.Click += new System.EventHandler(this.RegisterANewStudentToolStripMenuItem_Click);
            // 
            // registerANewBookToolStripMenuItem
            // 
            this.registerANewBookToolStripMenuItem.Name = "registerANewBookToolStripMenuItem";
            this.registerANewBookToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registerANewBookToolStripMenuItem.Text = "Register a New Book";
            this.registerANewBookToolStripMenuItem.Click += new System.EventHandler(this.RegisterANewBookToolStripMenuItem_Click);
            // 
            // bookDetailToolStripMenuItem
            // 
            this.bookDetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuedBooksToolStripMenuItem,
            this.returnedBooksToolStripMenuItem});
            this.bookDetailToolStripMenuItem.Name = "bookDetailToolStripMenuItem";
            this.bookDetailToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bookDetailToolStripMenuItem.Text = "Books";
            this.bookDetailToolStripMenuItem.Click += new System.EventHandler(this.BookDetailToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.StudentToolStripMenuItem_Click);
            // 
            // bookIssueToolStripMenuItem
            // 
            this.bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            this.bookIssueToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bookIssueToolStripMenuItem.Text = "Book Issue";
            this.bookIssueToolStripMenuItem.Click += new System.EventHandler(this.BookIssueToolStripMenuItem_Click);
            // 
            // bookReturnToolStripMenuItem
            // 
            this.bookReturnToolStripMenuItem.Name = "bookReturnToolStripMenuItem";
            this.bookReturnToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.bookReturnToolStripMenuItem.Text = "Book Return ";
            this.bookReturnToolStripMenuItem.Click += new System.EventHandler(this.BookReturnToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(13, 31);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(80, 13);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Welcome: User";
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.AllowUserToDeleteRows = false;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(16, 84);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.ReadOnly = true;
            this.gvStudents.Size = new System.Drawing.Size(1021, 190);
            this.gvStudents.TabIndex = 2;
            // 
            // gvBooks
            // 
            this.gvBooks.AllowUserToAddRows = false;
            this.gvBooks.AllowUserToDeleteRows = false;
            this.gvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBooks.Location = new System.Drawing.Point(16, 318);
            this.gvBooks.Name = "gvBooks";
            this.gvBooks.ReadOnly = true;
            this.gvBooks.Size = new System.Drawing.Size(1021, 198);
            this.gvBooks.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "All Books";
            // 
            // issuedBooksToolStripMenuItem
            // 
            this.issuedBooksToolStripMenuItem.Name = "issuedBooksToolStripMenuItem";
            this.issuedBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.issuedBooksToolStripMenuItem.Text = "Book History";
            this.issuedBooksToolStripMenuItem.Click += new System.EventHandler(this.IssuedBooksToolStripMenuItem_Click);
            // 
            // returnedBooksToolStripMenuItem
            // 
            this.returnedBooksToolStripMenuItem.Name = "returnedBooksToolStripMenuItem";
            this.returnedBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnedBooksToolStripMenuItem.Text = "Manage Books";
            this.returnedBooksToolStripMenuItem.Click += new System.EventHandler(this.ReturnedBooksToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvBooks);
            this.Controls.Add(this.gvStudents);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerANewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerANewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.DataGridView gvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem issuedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnedBooksToolStripMenuItem;
    }
}