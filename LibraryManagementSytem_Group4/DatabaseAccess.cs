using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem_Group4
{
    public class DatabaseAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        public void connect()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + path + "\\LibraryManagement.mdf'; Integrated Security=True";

            con = new SqlConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
        }

        public User GetUserByField(string data, string fieldname)
        {
            User user = null;
            try
            {
                connect();
                String s = "select * from Users WHERE "+ fieldname +" = @info";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@info", data);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    user = new User(Convert.ToInt32(rd["UserId"].ToString()),
                                    rd["StudentId"].ToString(),
                                    rd["FullName"].ToString(),
                                    rd["UserName"].ToString(),
                                    rd["UserType"].ToString(),
                                    rd["Password"].ToString());
                }
                con.Close();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get User by field name: " + ex.Message.ToString());
            }
            return user;
        }

        public User Login(string username, string password)
        {
            User user = null;
            try
            {
                connect();
                String s = "select * from Users WHERE UserName = @user AND Password = @password";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    user = new User(Convert.ToInt32(rd["UserId"].ToString()),
                                    rd["StudentId"].ToString(),
                                    rd["FullName"].ToString(),
                                    rd["UserName"].ToString(),
                                    rd["UserType"].ToString(),
                                    rd["Password"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Login: " + ex.Message.ToString());
            }
            return user;
        }
        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>() ;
            try
            {
                connect();
                String s = "select * from Book";
                cmd.CommandText = s;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                  Book obj = new Book(Convert.ToInt32(rd["BookId"].ToString()),
                                    rd["ISBN"].ToString(),
                                    rd["Title"].ToString(),
                                    rd["Author"].ToString(),
                                    rd["Publisher"].ToString(),
                                    rd["Category"].ToString(),
                                    rd["Language"].ToString(),
                                    rd["Edition"].ToString(),
                                    rd["Shelf"].ToString(),
                                    rd["Pages"].ToString(),
                                    Convert.ToDouble(rd["Price"].ToString()),
                                    rd["year"].ToString(),
                                    rd["Description"].ToString(),
                                   Convert.ToDateTime(rd["AddedDate"].ToString())
                                    );
                    list.Add(obj);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get All Books: " + ex.Message.ToString());
            }
            return list;
        }

        public List<BookHistory> GetAllBookHistory()
        {
            List<BookHistory> list = new List<BookHistory>();
            try
            {
                connect();
                String s = "select A.*, B.Title,B.Author,B.Publisher from BookHistory A INNER JOIN Book B ON B.BookId = A.HBookId";
                cmd.CommandText = s;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BookHistory obj = new BookHistory();
                    obj.HistoryId = Convert.ToInt32(rd["BookHistoryId"].ToString());
                    obj.StudentId = rd["StudentId"].ToString();
                    obj.Title = rd["Title"].ToString();
                    obj.Author = rd["Author"].ToString();
                    obj.Publisher = rd["Publisher"].ToString();
                    obj.IssueDate = Convert.ToDateTime(rd["IssueDate"].ToString());
                    obj.DueDate = Convert.ToDateTime(rd["DueDate"].ToString());
                    DateTime returnDate;
                    DateTime.TryParse(rd["ReturnDate"].ToString(), out returnDate);
                   
                    obj.ReturnDate = returnDate;
                    obj.Balance = Convert.ToDouble(rd["Balance"].ToString());
                    obj.Status = rd["Status"].ToString();
                                  
                    
                    list.Add(obj);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get All Books: " + ex.Message.ToString());
            }
            return list;
        }
        public List<BookHistory> GetAllBookHistoryByStudent(string studentid)
        {
            List<BookHistory> list = new List<BookHistory>();
            try
            {
                connect();
                String s = "select A.*, B.Title,B.Author,B.Publisher from BookHistory A INNER JOIN Book B ON B.BookId = A.HBookId WHERE StudentId = @studentid";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@studentid", Convert.ToInt32(studentid));
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BookHistory obj = new BookHistory();
                    obj.HistoryId = Convert.ToInt32(rd["BookHistoryId"].ToString());
                    obj.BookId = Convert.ToInt32(rd["HBookId"].ToString());
                    obj.StudentId = rd["StudentId"].ToString();
                    obj.Title = rd["Title"].ToString();
                    obj.Author = rd["Author"].ToString();
                    obj.Publisher = rd["Publisher"].ToString();
                    obj.IssueDate = Convert.ToDateTime(rd["IssueDate"].ToString());
                    obj.DueDate = Convert.ToDateTime(rd["DueDate"].ToString());
                    DateTime returnDate;
                    DateTime.TryParse(rd["ReturnDate"].ToString(), out returnDate);

                    obj.ReturnDate = returnDate;
                    obj.Balance = Convert.ToDouble(rd["Balance"].ToString());
                    obj.Status = rd["Status"].ToString();


                    list.Add(obj);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get All Books: " + ex.Message.ToString());
            }
            return list;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> list = new List<Student>();
            try
            {
                connect();
                String s = "select * from Student";
                cmd.CommandText = s;
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Student obj = new Student(Convert.ToInt32(rd["StId"].ToString()),
                                      rd["StudentId"].ToString(),
                                      rd["Name"].ToString(),
                                      rd["Gender"].ToString(),
                                      rd["Course"].ToString(),
                                      rd["Department"].ToString(),
                                      rd["Semester"].ToString(),
                                      rd["Phone"].ToString(),
                                      rd["Email"].ToString(),
                                     Convert.ToDateTime(rd["DOB"].ToString()));
                    list.Add(obj);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get All Students: " + ex.Message.ToString());
            }
            return list;
        }
        public List<Book> GetBooksByField(string data, string field)
        {
            List<Book> list = new List<Book>();
            try
            {
                connect();
                String s = "select * from Book WHERE " + field + " = @field";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@field", "%"+data+"%");
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Book obj = new Book(Convert.ToInt32(rd["BookId"].ToString()),
                                      rd["ISBN"].ToString(),
                                      rd["Title"].ToString(),
                                      rd["Author"].ToString(),
                                      rd["Publisher"].ToString(),
                                      rd["Category"].ToString(),
                                      rd["Language"].ToString(),
                                      rd["Edition"].ToString(),
                                      rd["Shelf"].ToString(),
                                      rd["Pages"].ToString(),
                                      Convert.ToDouble(rd["Price"].ToString()),
                                      rd["year"].ToString(),
                                      rd["Description"].ToString(),
                                     Convert.ToDateTime(rd["AddedDate"].ToString())
                                      );
                    list.Add(obj);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get All Books: " + ex.Message.ToString());
            }
            return list;
        }
        public Book GetBookById(string id)
        {
            Book obj = null;
            try
            {
                connect();
                String s = "select * from Book WHERE BookId = @BookId";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(id));
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    obj = new Book(Convert.ToInt32(rd["BookId"].ToString()),
                                      rd["ISBN"].ToString(),
                                      rd["Title"].ToString(),
                                      rd["Author"].ToString(),
                                      rd["Publisher"].ToString(),
                                      rd["Category"].ToString(),
                                      rd["Language"].ToString(),
                                      rd["Edition"].ToString(),
                                      rd["Shelf"].ToString(),
                                      rd["Pages"].ToString(),
                                      Convert.ToDouble(rd["Price"].ToString()),
                                      rd["year"].ToString(),
                                      rd["Description"].ToString(),
                                     Convert.ToDateTime(rd["AddedDate"].ToString())
                                      );

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get Book by Id: " + ex.Message.ToString());
            }
            return obj;
        }
        public Student GetStudentById(string studentId)
        {
            Student obj = null;
            try
            {
                connect();
                String s = "select * from Student WHERE StudentId = @StudentId";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                     obj = new Student(Convert.ToInt32(rd["StId"].ToString()),
                                      rd["StudentId"].ToString(),
                                      rd["Name"].ToString(),
                                      rd["Gender"].ToString(),
                                      rd["Course"].ToString(),
                                      rd["Department"].ToString(),
                                      rd["Semester"].ToString(),
                                      rd["Phone"].ToString(),
                                      rd["Email"].ToString(),
                                     Convert.ToDateTime(rd["DOB"].ToString()));
                    

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get Student by StudentId: " + ex.Message.ToString());
            }
            return obj;
        }
        public BookHistory CheckBookIssueToStudent(string studentId, string bookId)
        {
            BookHistory obj = null;
            try
            {
                connect();
                String s = "select TOP 1 * from BookHistory WHERE StudentId = @StudentId AND HBookId = @bookId ORDER BY BookHistoryId DESC";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    obj = new BookHistory(Convert.ToInt32(rd["BookHistoryId"].ToString()),
                                     rd["StudentId"].ToString(),
                                     Convert.ToDateTime(rd["IssueDate"].ToString()),
                                     Convert.ToDateTime(rd["DueDate"].ToString()),
                                     Convert.ToDouble(rd["Balance"].ToString()),
                                     rd["Status"].ToString(),
                                     Convert.ToInt32(rd["HBookId"].ToString()) 
                                     );


                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get BookHistory by StudentId and Book Id: " + ex.Message.ToString());
            }
            return obj;
        }
        public bool Register(User user)
        {
            try
            {
                connect();
                String s = "INSERT INTO Users(StudentId, FullName,UserName,Password,UserType) VALUES(@StudentId, @FullName,@UserName,@Password,@UserType)";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@StudentId", user.StudentId);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@UserType", user.UserType);
                int result = cmd.ExecuteNonQuery();
                
                con.Close();

                if (result > 0)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add User: " + ex.Message.ToString());
            }
            return false;
        }
        public bool AddStudent(Student obj)
        {
            try
            {
                connect();
                String s = "INSERT INTO Student(StudentId,Name,Gender,Course,Department,Semester,DOB,Phone,Email) VALUES(@StudentId,@Name,@Gender,@Course,@Department,@Semester,@DOB,@Phone,@Email)";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@StudentId", obj.StudentId);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                cmd.Parameters.AddWithValue("@Course", obj.Course);
                cmd.Parameters.AddWithValue("@Department", obj.Department);
                cmd.Parameters.AddWithValue("@Semester", obj.Semester);
                cmd.Parameters.AddWithValue("@DOB", obj.DOB);
                cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Student: " + ex.Message.ToString());
            }
            return false;
        }
        public bool AddBook(Book book)
        {
            try
            {
                connect();
                String s = "INSERT INTO Book(ISBN, Title,Author,Publisher,Category,Language,Edition,Shelf,Pages,Price,year,Description,AddedDate) VALUES(@ISBN,@Title,@Author,@Publisher,@Category,@Language,@Edition,@Shelf,@Pages,@Price,@year,@Description,@AddedDate)";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                cmd.Parameters.AddWithValue("@Category", book.Category);
                cmd.Parameters.AddWithValue("@Language", book.Language);
                cmd.Parameters.AddWithValue("@Edition", book.Edition);
                cmd.Parameters.AddWithValue("@Shelf", book.Shelf);
                cmd.Parameters.AddWithValue("@Pages", book.Pages);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@year", book.Year);
                cmd.Parameters.AddWithValue("@Description", book.Description);
                cmd.Parameters.AddWithValue("@AddedDate", book.AddedDate);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Book: " + ex.Message.ToString());
            }
            return false;
        }
        public bool IssueBook(BookHistory book)
        {
            try
            {
                connect();
                String s = "INSERT INTO BookHistory(StudentId, HBookId,IssueDate,DueDate,Balance,Status) VALUES(@StudentId, @HBookId,@IssueDate,@DueDate,@Balance,@Status)";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@StudentId", book.StudentId);
                cmd.Parameters.AddWithValue("@HBookId", book.BookId);
                cmd.Parameters.AddWithValue("@IssueDate", book.IssueDate);
                cmd.Parameters.AddWithValue("@DueDate", book.DueDate);
                cmd.Parameters.AddWithValue("@Balance", book.Balance);
                cmd.Parameters.AddWithValue("@Status", book.Status);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Issue Book: " + ex.Message.ToString());
            }
            return false;
        }
        public bool ReturnBook(BookHistory book)
        {
            try
            {
                connect();
                String s = "Update BookHistory SET ReturnDate = @ReturnDate,  Balance = @Balance, Status = @Status WHERE BookHistoryId = @Id";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@ReturnDate", book.ReturnDate);
                cmd.Parameters.AddWithValue("@Balance", book.Balance);
                cmd.Parameters.AddWithValue("@Status", book.Status);
                cmd.Parameters.AddWithValue("@Id", book.HistoryId);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Return Book: " + ex.Message.ToString());
            }
            return false;
        }
        public bool UpdateBook(Book book)
        {
            try
            {
                connect();
                String s = "UPDATE Book SET ISBN = @ISBN, Title = @Title,Author = @Author,Publisher = @Publisher,Category = @Category,Language = @Language,Edition = @Edition,Shelf = @Shelf,Pages = @Pages,Price = @Price,year = @year,Description = @Description,AddedDate = @AddedDate WHERE BookId = @BookId";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                cmd.Parameters.AddWithValue("@Category", book.Category);
                cmd.Parameters.AddWithValue("@Language", book.Language);
                cmd.Parameters.AddWithValue("@Edition", book.Edition);
                cmd.Parameters.AddWithValue("@Shelf", book.Shelf);
                cmd.Parameters.AddWithValue("@Pages", book.Pages);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@year", book.Year);
                cmd.Parameters.AddWithValue("@Description", book.Description);
                cmd.Parameters.AddWithValue("@AddedDate", book.AddedDate);
                cmd.Parameters.AddWithValue("@BookId", book.BookId);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Book: " + ex.Message.ToString());
            }
            return false;
        }
        public bool DeleteBook(string bookid)
        {
            try
            {
                connect();
                String s = "DELETE FROM Book WHERE BookId = @BookId";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@BookId", bookid);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("DELETE Book: " + ex.Message.ToString());
            }
            return false;
        }
        public bool UpdateStudent(Student obj)
        {
            try
            {
                connect();
                String s = "UPDATE Student SET Name = @Name,Gender = @Gender,Course = @Course,Department = @Department,Semester = @Semester,DOB = @DOB,Phone = @Phone,Email = @Email WHERE StudentId = @StudentId";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@StudentId", obj.StudentId);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                cmd.Parameters.AddWithValue("@Course", obj.Course);
                cmd.Parameters.AddWithValue("@Department", obj.Department);
                cmd.Parameters.AddWithValue("@Semester", obj.Semester);
                cmd.Parameters.AddWithValue("@DOB", obj.DOB);
                cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Student: " + ex.Message.ToString());
            }
            return false;
        }

        public bool DeleteStudent(string studentid)
        {
            try
            {
                connect();
                String s = "DELETE FROM Student WHERE StudentId = @studentid";
                cmd.CommandText = s;
                cmd.Parameters.AddWithValue("@studentid", studentid);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("DELETE Student: " + ex.Message.ToString());
            }
            return false;
        }
    }
}
