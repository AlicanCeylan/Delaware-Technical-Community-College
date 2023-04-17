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
    class DatesUpdate : Dates
    {
        public string UpdateDates()
        {

            //switch statement used to check and increment dates
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if(day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        month++;
                        day = 1;
                    }
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        if(day < 29)
                        {
                            day++;
                        }
                        else
                        {
                            month++;
                            day = 1;
                        }
                    }
                    else
                    {
                        if (day < 28)
                        {
                            day++;
                        }
                        else
                        {
                            month++;
                            day = 1;
                        }
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 30)
                    {
                        day++;
                    }
                    else
                    {
                        month++;
                        day = 1;
                    }
                    break;
                case 12:
                    if (day < 31)
                    {
                        day++;
                    }
                    else
                    {
                        year++;
                        day = 1;
                        month = 1;
                    }
                    break;

            }

            //reformated date
            date = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
            return date;
        }
    }
}
