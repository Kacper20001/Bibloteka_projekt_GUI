﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfejsy
{
    internal interface IBook
    {
        string Title { get; }
        string Author { get; }
        int Year { get; }
        string Description { get; }
        string Availability { get; }
    }
}
