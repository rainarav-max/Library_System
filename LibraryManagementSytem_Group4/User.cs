using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSytem_Group4
{
    public class User
    {
        public int UserId { get; set; }
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(int userId, string fullName, string userName, string userType, string password)
        {
            UserId = userId;
            FullName = fullName;
            UserName = userName;
            UserType = userType;
            Password = password;
        }
        public User(string fullName, string userName, string userType, string password)
        {
            FullName = fullName;
            UserName = userName;
            UserType = userType;
            Password = password;
        }

        public User(string studentId,string fullName, string userName, string userType, string password)
        {
            StudentId = studentId;
            FullName = fullName;
            UserName = userName;
            UserType = userType;
            Password = password;
        }
        public User(int userId,string studentId, string fullName, string userName, string userType, string password)
        {
            UserId = userId;
            StudentId = studentId;
            FullName = fullName;
            UserName = userName;
            UserType = userType;
            Password = password;
        }
    }
}
