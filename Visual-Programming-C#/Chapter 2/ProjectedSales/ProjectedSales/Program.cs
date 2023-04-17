//Alican Ceylan
//01.11.2018
// Chapter 2 – Programming Exercise 3
// Projected Sales Increase

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant declaration
            const double TEN_PERCENT_INC = 0.1;

            //variable declaration
            double northCurrent = 4000;
            double southCurrent = 5500;
            double northProjected = 0;
            double southProjected = 0;

            // calculate projected sales
            northProjected = northCurrent + (northCurrent * TEN_PERCENT_INC);
            southProjected = southCurrent + (southCurrent * TEN_PERCENT_INC);

            //Display current and projected sales
            Console.WriteLine("North division (current) " + northCurrent + " - (projected) " + northProjected + " next year.");
            Console.WriteLine("South division (current) " + southCurrent + " - (projected) " + southProjected + " next year.");
        }
    }
}
