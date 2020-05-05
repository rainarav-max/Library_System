using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem_Group4
{
    public partial class LoginForm : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public static User loggedUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            rgUserType.SelectedIndex = 0;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string usertype = rgUserType.SelectedItem.ToString().Trim();
                string fullname = rgFullName.Text.Trim();
                string username = rgUserName.Text.Trim();
                string password = rgPassword.Text.Trim();
                string studentid = "", message = "";

                if (String.IsNullOrEmpty(usertype) ||  usertype.Equals("Select"))
                {
                    message += "User type is required!\n";
                }
                if (!String.IsNullOrEmpty(usertype) && usertype.Equals("Student"))
                {
                    if (String.IsNullOrEmpty(rgStudentId.Text.Trim())){
                        message += "Student Id is required!\n";
                    }
                    studentid = rgStudentId.Text.Trim();
                }

                if (String.IsNullOrEmpty(fullname))
                {
                    message += "Full Name is required!\n";
                }
                if (String.IsNullOrEmpty(username))
                {
                    message += "User Name is required!\n";
                }
                if (String.IsNullOrEmpty(password))
                {
                    message += "Password is required!\n";
                }

                

                if (!String.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, "Invalid data Message box");
                }
                else
                {
                    if (db.GetUserByField(username, "UserName") == null)
                    {
                        User user = new User(studentid, fullname, username, usertype, password);
                        if (usertype.Equals("Admin"))
                        {
                            if (db.Register(user))
                                MessageBox.Show("New user registered! Please login now!");
                            else
                                MessageBox.Show("Unable to regiser user! Please try again!");
                        }
                        else if(usertype.Equals("Student"))
                        {
                            if(db.GetUserByField(studentid, "StudentId") == null)
                            {
                                if(db.GetStudentById(studentid) != null)
                                {
                                    if (db.Register(user))
                                        MessageBox.Show("New user registered! Please login now!");
                                    else
                                        MessageBox.Show("Unable to regiser user! Please try again!");
                                }
                                else
                                {
                                    MessageBox.Show("Student Id does not exists in System, Please ask Admin to register student first");
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("User with this student id already exists.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select user type!");
                        }
                        
                    }
                    else
                    {
                        message += "Username already taken, Please try another!\n";
                        MessageBox.Show(message, "Invalid data Message box");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Register Message Box");
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = lgUserName.Text.Trim();
                string password = lgPassword.Text.Trim();

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                    MessageBox.Show("Username and password are required!");
                else
                {
                    loggedUser = db.Login(username, password);
                    if (loggedUser != null)
                    {
                        
                        if (loggedUser.UserType.Equals("Admin"))
                        {
                            var form1 = new Form1();
                            this.Hide();
                            form1.Closed += (s, args) => this.Close();
                            form1.Show();
                        }
                        else if (loggedUser.UserType.Equals("Student"))
                        {
                            var form2 = new StudentMain();
                            this.Hide();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                        }
                        else { MessageBox.Show("Wrong user type"); }
                            
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please enter correct match");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Login Message Box");
            }
        }

        private void RgUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgUserType.SelectedItem.Equals("Student"))
            {
                rgStudentId.ReadOnly = false;
            }
            else
            {
                rgStudentId.ReadOnly = true;
            }
        }
    }
}
