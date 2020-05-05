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
    public partial class RegisterStudent : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public static User loggedUser = null;
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string studentId = txtId.Text.Trim();
                string name = txtName.Text.Trim();
                string gender = "", message = "";
                if (radioMale.Checked)
                    gender = radioMale.Text;
                else if (radioFemale.Checked)
                    gender = radioFemale.Text;
                else
                    gender = "";

                string dob = txtdob.Value.ToString("yyyy-MM-dd");
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string course = cmbCourse.SelectedItem.ToString();
                string department = cmbDepartment.SelectedItem.ToString();
                string semester = txtSemester.Text.Trim();

                message += String.IsNullOrEmpty(studentId) ? "Student Id is required!\n" : "";
                message += String.IsNullOrEmpty(name) ? "Student Name is required!\n" : "";
                message += String.IsNullOrEmpty(gender) ? "Gender is required!\n" : "";
                message += String.IsNullOrEmpty(dob) ? "Date of birth is required!\n" : "";
                message += String.IsNullOrEmpty(email) ? "Email Id is required!\n" : "";
                message += String.IsNullOrEmpty(course) || course.Equals("Select")  ? "Course is required!\n" : "";
                message += String.IsNullOrEmpty(semester) ? "Semester is required!\n" : "";

                if(message != string.Empty)
                    MessageBox.Show(message);
                else
                {
                    Student obj = new Student(studentId, name, gender,course, department, semester, phone,email, Convert.ToDateTime(dob));
                    if (db.GetStudentById(studentId) == null)
                    {
                        if (db.AddStudent(obj))
                        {
                            MessageBox.Show("Student added to library system!");
                            txtId.Text = "";
                            txtName.Text = "";
                            txtPhone.Text = "";
                            txtEmail.Text = "";
                            txtSemester.Text = "";
                        }
                        else
                            MessageBox.Show("Unable to add student. Please try again!");
                    }
                    else
                        MessageBox.Show("Student Id already taken, Please use different id!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close(); 
            form1.Show();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            loggedUser = LoginForm.loggedUser;
            userLbl.Text = "Welcome: " + loggedUser.FullName;
            cmbCourse.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            radioMale.Checked = true;
        }
    }
}
