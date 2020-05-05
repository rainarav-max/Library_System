using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSytem_Group4
{
    public class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string Edition { get; set; }
        public string Shelf { get; set; }
        public string Pages { get; set; }
        public double Price { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }

        public Book() { }
        public Book(int id) { BookId = id; }

        public Book(int bookId, string isbn, string title, string author,string publisher,string category,string language, string edition, string shelf, string pages, double price, string year, string description , DateTime addedDate) {
            BookId = bookId;
            ISBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            Category = category;
            Language = language;
            Edition = edition;
            Shelf = shelf;
            Pages = pages;
            Price = price;
            Year = year;
            Description = description;
            AddedDate = addedDate;
        }

        public Book(string isbn, string title, string author, string publisher, string category, string language, string edition, string shelf, string pages, double price, string year, string description, DateTime addedDate)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            Category = category;
            Language = language;
            Edition = edition;
            Shelf = shelf;
            Pages = pages;
            Price = price;
            Year = year;
            Description = description;
            AddedDate = addedDate;
        }
    }
}
