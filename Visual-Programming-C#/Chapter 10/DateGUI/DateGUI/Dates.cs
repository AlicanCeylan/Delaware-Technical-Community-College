//Alican Ceylan
//03.15.2018
// Chapter 10 – Programming Exercise 2
// Enter, manipulate, and display a date using multiple classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateGUI
{
    class Dates
    {
        protected int month;
        protected int day;
        protected int year;
        protected string date;
       public void SetDate(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public string BuildDate()
        {
            date = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
            return date;
        }

        public Dates()
        {
            month = 0;
            day = 0;
            year = 0;
            date = string.Empty;
        }
    }
}
