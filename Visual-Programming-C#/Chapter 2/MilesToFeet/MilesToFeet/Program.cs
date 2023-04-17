//Alican Ceylan
//01/11/2018
// Chapter 2 – Programming Exercise 1
// Miles to Feet Conversion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant declaration
            const int FEET_IN_MILE = 5280;
            //variable declaration
            double distanceMiles = 8.5;
            double distanceFeet = 0.0;

            // calculate distance in feet
            distanceFeet = distanceMiles * FEET_IN_MILE;

            //display calculated results to user
            Console.WriteLine("The distance to the WAWA store is " + distanceMiles + " miles or " + distanceFeet + " feet.");             
         }
    }
}
