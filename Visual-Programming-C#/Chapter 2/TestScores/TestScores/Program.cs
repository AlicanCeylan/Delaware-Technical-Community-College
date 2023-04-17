//Alican Ceylan
//01.11.2018
// Chapter 2 – Programming Exercise 5
// Average of Test Scores

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant declaration
            const double NUM_TEST_SCORES = 5;

            //variable declaration
            int firstTest = 91;
            int secTest = 75;
            int thirdTest = 88;
            int fourthTest = 100;
            int fifthTest = 95;
            double avg = 0.0;

            //calculate the average
            avg = (firstTest + secTest + thirdTest + fourthTest + fifthTest) / NUM_TEST_SCORES;

            //display average to user
            Console.WriteLine("The average of the five test scores is " + String.Format("{0:0.00}", avg) + ".");
        }
    }
}
