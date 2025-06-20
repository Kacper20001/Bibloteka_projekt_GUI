﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfejsy
{
    internal interface IBookHandle
    {
        Book GetBookById(int bookId);
        void EditBook(int id, string newTitle, string newAuthor, string newDescription, int newYear);
        void AddBook(string title, string author, int year, string description);
        void DeleteBook(int id);
        void ReturnBook(int bookId);
        DataTable LoadBooks(string searchTerm = "");

    }
}
