using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSytem_Group4
{
    public class Student
    {
        public int StId { get; set; }
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        public Student() { }
        public Student(int stId, string studentId,string name, string gender, string course, string department,string semester,string phone,string email, DateTime dob)
        {
            StId = stId;
            StudentId = studentId;
            Name = name;
            Gender = gender;
            Course = course;
            Department = department;
            Semester = semester;
            Phone = phone;
            Email = email;
            DOB = dob;
        }

        public Student( string studentId, string name, string gender, string course, string department, string semester, string phone, string email, DateTime dob)
        {
            StudentId = studentId;
            Name = name;
            Gender = gender;
            Course = course;
            Department = department;
            Semester = semester;
            Phone = phone;
            Email = email;
            DOB = dob;
        }
    }
}
