using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Web;
using WindowsFormsApp1.Interfejsy;

namespace WindowsFormsApp1
{
    public class Book : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Availability { get; set; }
        public Book(string title, string author, int year, string description, string availability)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Title cannot be empty or null", nameof(title));

            if (string.IsNullOrEmpty(author))
                throw new ArgumentException("Author cannot be empty or null", nameof(author));

            if (year <= 0)
                throw new ArgumentException("Year must be a positive number", nameof(year));

            if (year > DateTime.Now.Year)
                throw new ArgumentException("The year cannot be later than the current year ", nameof(year));
            Title = title;
            Author = author;
            Year = year;
            Description = description;
            Availability = availability;
        }
    }
}

