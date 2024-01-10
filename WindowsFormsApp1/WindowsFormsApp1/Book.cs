using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public Book(int id, string title, string author, int year, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Description = description;
        }

        public void DisplayBookInformation()
        {
            Console.WriteLine($"Książka {Title}, została napisana przez {Author} w roku {Year}");
            Console.WriteLine("Krótki opis: " + Description);
        }
    }
}
