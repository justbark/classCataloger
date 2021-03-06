﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCatalogerWPF
{
    public class Book
    {
        public string isbn10; //isbn 10 digit number
        public string isbn13; //isbn 13 digit number
        public string title; //title of the book
        public string author; //name of the author
        public string editor;
        public string coAuthor;
        public string date;
        public string numberOfPages;
        public List<String> tags = new List<String>();
        public string studentName; // who has the book checked out
        public string prevStudentName; // variable for the last student who had the book
        public bool checkedOut;
        public DateTime checkOutDate;
        public int checkOutDur;
        public bool reminder;

        public bool IsOverdue()
        {
            if(checkOutDate.AddDays(7) >= DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
