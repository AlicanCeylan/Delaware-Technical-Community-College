//Alican Ceylan
//01.11.2018
// Chapter 2 – Programming Exercise 6
// Average of Test Scores - Interactive

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScoresInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant declaration
            const double NUM_TEST_SCORES = 5;

            //variable declaration
            int firstTest = 0;
            int secTest = 0;
            int thirdTest = 0;
            int fourthTest = 0;
            int fifthTest = 0;
            string firstString = "";
            string secString = "";
            string thirdString = "";
            string fourthString = "";
            string fifthString = "";
            double avg = 0;

            //prompt user for test scores and store them
            Console.Write("Enter first test score ----> ");
            firstString = Console.ReadLine();

            Console.Write("Enter second test score ---> ");
            secString = Console.ReadLine();

            Console.Write("Enter third test score ----> ");
            thirdString = Console.ReadLine();

            Console.Write("Enter fourth test score ---> ");
            fourthString = Console.ReadLine();

            Console.Write("Enter fifth test score ----> ");
            fifthString = Console.ReadLine();

            //convert collected scores to double type
            firstTest = Convert.ToInt32(firstString);
            secTest = Convert.ToInt32(secString);
            thirdTest = Convert.ToInt32(thirdString);
            fourthTest = Convert.ToInt32(fourthString);
            fifthTest = Convert.ToInt32(fifthString);


            //calculate the average
            avg = (firstTest + secTest + thirdTest + fourthTest + fifthTest) / NUM_TEST_SCORES;

            //display average to user
            Console.WriteLine("The average of the five test scores entered is " + String.Format("{0:0.000}", avg) + ".");
        }
    }
}
