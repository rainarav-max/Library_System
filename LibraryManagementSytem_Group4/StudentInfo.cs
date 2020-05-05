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
    public partial class StudentInfo : Form
    {
        DatabaseAccess db = new DatabaseAccess();
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string studentId = txtStudentId.Text.Trim();
                string name = txtName.Text.Trim();
                string gender = "", message = "";
                if (radioMale.Checked)
                    gender = radioMale.Text;
                else if (radioFemale.Checked)
                    gender = radioFemale.Text;
                else
                    gender = "";

                string dob = txtDob.Value.ToString("yyyy-MM-dd");
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
                message += String.IsNullOrEmpty(course) || course.Equals("Select") ? "Course is required!\n" : "";
                message += String.IsNullOrEmpty(semester) ? "Semester is required!\n" : "";

                if (message != string.Empty)
                    MessageBox.Show(message);
                else
                {
                    Student obj = new Student(studentId, name, gender, course, department, semester, phone, email, Convert.ToDateTime(dob));
                    
                        if (db.UpdateStudent(obj))
                        {
                            MessageBox.Show("Student Updated to library system!");
                           
                            var studentBindingList = new BindingList<Student>(db.GetAllStudents());
                            var studentSource = new BindingSource(studentBindingList, null);

                            gvStudents.DataSource = studentSource;
                        }
                        else
                            MessageBox.Show("Unable to Update student. Please try again!");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // delete
            try
            {
                string studentid = txtStudentId.Text.Trim();
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Student?", "Confirmation Dialog", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    if (db.DeleteStudent(studentid))
                    {
                        MessageBox.Show("Student deleted from library system!");
                        txtStudentId.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtSemester.Text = "";
                        var studentBindingList = new BindingList<Student>(db.GetAllStudents());
                        var studentSource = new BindingSource(studentBindingList, null);

                        gvStudents.DataSource = studentSource;

                    }
                    else
                        MessageBox.Show("Unable to delete student. Please try again!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            var studentBindingList = new BindingList<Student>(db.GetAllStudents());
            var studentSource = new BindingSource(studentBindingList, null);
           
            gvStudents.DataSource = studentSource;
            cmbCourse.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
        }

        private void GvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (gvStudents.SelectedRows.Count != 0)
            {
                string studentid = Convert.ToString(gvStudents.CurrentRow.Cells["StudentId"].Value);
                Student student = db.GetStudentById(studentid);

                txtStudentId.Text = student.StudentId;
                txtName.Text = student.Name;
                radioMale.Checked = student.Gender == "Male" ? true : false;
                radioFemale.Checked = student.Gender == "Female" ? true : false;
                cmbCourse.SelectedIndex = cmbCourse.FindString(student.Course);
                cmbDepartment.SelectedIndex = cmbDepartment.FindString(student.Department);
                txtSemester.Text = student.Semester;
                txtDob.Value = student.DOB;
                txtPhone.Text = student.Phone;
                txtEmail.Text = student.Email;
               

            }
        }
    }
}
