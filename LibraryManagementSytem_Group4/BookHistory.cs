using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSytem_Group4
{
    public class BookHistory: Book
    {
        public int HistoryId { get; set; }
        public string StudentId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }

        public BookHistory() : base()
        {

        }
        public BookHistory(int historyId, string studentId, double balance, string status, int bookId) : base(bookId)
        {
            HistoryId = historyId;
            StudentId = studentId;
          
            Balance = balance;
            Status = status;
        }
        public BookHistory(int historyId, DateTime returnDate, double balance, string status)
        {
            HistoryId = historyId;
            ReturnDate = returnDate;
            Balance = balance;
            Status = status;
        }
        public BookHistory(int historyId, string studentId, DateTime issueDate, DateTime dueDate, DateTime returnDate, double balance, string status, int bookId) : base(bookId)
        {
            HistoryId = historyId;
            StudentId = studentId;
            IssueDate = issueDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
            Balance = balance;
            Status = status;
        }

        public BookHistory( string studentId, DateTime issueDate, DateTime dueDate, DateTime returnDate, double balance, string status, int bookId) : base(bookId)
        {
            StudentId = studentId;
            IssueDate = issueDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
            Balance = balance;
            Status = status;
        }
        public BookHistory(string studentId, DateTime issueDate, DateTime dueDate, double balance, string status, int bookId) : base(bookId)
        {
            StudentId = studentId;
            IssueDate = issueDate;
            DueDate = dueDate;
            Balance = balance;
            Status = status;
        }
        public BookHistory(int historyId, string studentId, DateTime issueDate, DateTime dueDate, double balance, string status, int bookId) : base(bookId)
        {
            HistoryId = historyId;
            StudentId = studentId;
            IssueDate = issueDate;
            DueDate = dueDate;
            Balance = balance;
            Status = status;
        }
        public BookHistory(string studentId, DateTime returnDate, double balance, string status, int bookId) : base(bookId)
        {
            StudentId = studentId;
            ReturnDate = returnDate;
            Balance = balance;
            Status = status;
        }

    }
}
