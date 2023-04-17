//Alican Ceylan
//01.11.2018
// Chapter 2 - Programming Exercise 4
// Projected Sales Increase - Interactive


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedSalesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant declaration
            const double TEN_PERCENT_INC = 0.1;

            //variable declaration
            string northString = "";
            string southString = "";
            double northCurrent = 0.0;
            double southCurrent = 0.0;
            double northProjected = 0.0;
            double southProjected = 0.0;

            //prompt user for north sales and capture the input
            Console.Write("Enter current Sales for the North Division >> ");
            northString = Console.ReadLine();

            //prompt user for south sales and capture the input
            Console.Write("Enter current Sales for the South Division >> ");
            southString = Console.ReadLine();

            //convert user inputs to type double
            northCurrent = Convert.ToDouble(northString);
            southCurrent = Convert.ToDouble(southString);

            // calculate projected sales
            northProjected = northCurrent + (northCurrent * TEN_PERCENT_INC);
            southProjected = southCurrent + (southCurrent * TEN_PERCENT_INC);

            //Display current and projected sales
            Console.WriteLine("North division (current) " + northCurrent + " - (projected) " + northProjected + " next year.");
            Console.WriteLine("South division (current) " + southCurrent + " - (projected) " + southProjected + " next year.");
        }
    }
}
