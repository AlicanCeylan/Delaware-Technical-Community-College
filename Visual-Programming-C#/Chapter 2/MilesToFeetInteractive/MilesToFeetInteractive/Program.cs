//Alican Ceylan
//01.11.2018
// Chapter 2 – Programming Exercise 2
// Miles to Feet Conversion - Interactive


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToFeetInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant declaration
            const int FEET_IN_MILE = 5280;
            
            //variable declaration
            double distanceMiles = 0.0;
            double distanceFeet = 0.0;
            string entryString = "";

            //prompt user for input
            Console.Write("Enter distance to the WAWA store in miles >> ");

            //capture user input
            entryString = Console.ReadLine();

            //convert user input to type double
            distanceMiles = Convert.ToDouble(entryString);

            // calculate distance in feet
            distanceFeet = distanceMiles * FEET_IN_MILE;

            //display calculated results to user
            Console.WriteLine("The distance to the WAWA store is " + distanceMiles + " miles or " + distanceFeet + " feet.");

        }
    }
}
