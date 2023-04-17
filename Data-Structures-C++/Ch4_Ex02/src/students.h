//*************************************************************************
// Author: B. Lord
// Modified by: Alican Ceylan
// Modified date: 03.13.2018
// Modicications: add the implementation of the functions for the class
//
// Class description: This class specifies the member functions
// that implement the basic properties for working with vectors.
//*************************************************************************


#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class studentStats
{

// ---------- CLASS DEFINITION ----------

    public:
        double sumScores(vector<double> scores);
        // Function to sum all test scores in preparation to solve for class average.
        // Postcondition: The sum of all test scores is returned to the caller of
        //                this function.

        double highScoreIndex(vector<double> scores);
        // Function to determine the highest test score.
        // Postcondition: Vector index for the highest test score is returned to the
        //                caller of this function.

        void displayResults(vector<string> students, vector<double> scores, double studAvgScore);
        // Function to display required output items. Also calls the highScoreIndex
        // function to get the index of the highest test score.
        // Postcondition: The high score, students who have the highest score, class
        //                average, students whose score is less than class average,
        //                and remaining students are displayed in the console.

        studentStats();
        // Default constructor
        // Initializes instance variables
        // Postcondition: The sum and highIndex instance variables are initialized to 0

    private:
        int sum;            // Variable to store sum of test scores
        int highIndex;      // Variable to store vector index of highest score
};

// ---------- CLASS IMPLEMENTATION ----------

double studentStats::sumScores(vector<double> scores)
{
	//loop used to calculate sum of test scores
	for(size_t i = 0; i < scores.size(); i++)
	{
		sum += scores[i];
	}

	return sum;
}

double studentStats::highScoreIndex(vector<double> scores)
{
	//variable declaration
	double highScore = 0.0;

	for(size_t i = 0; i < scores.size(); i++)
		{
			if(scores[i] > highScore)
			{
				highScore = scores[i];
				highIndex = i;
			}
		}

	return highIndex;
}

void studentStats::displayResults(vector<string> students, vector<double> scores, double studAvgScore)
{
	//display results
	cout << "\nClass Size ------> " << scores.size();
	cout << "\nHighest Score ---> " << setprecision(2) << fixed << scores[highIndex];
	cout << "\nClass Average ---> " << studAvgScore;

	cout << "\n\nStudents whose score equaled the highest score:\n";
	//loop used to find students with scores equal to the high score
	for(size_t i = 0; i < scores.size(); i++)
	{
		if(scores[i] == scores[highIndex])
		{
			cout << "- " << students[i] << "\n";
		}
	}

	cout << "\nStudents whose scored less the class average:\n";
	//loop used to find students who score less than average
	for(size_t i = 0; i < scores.size(); i++)
	{
		if(scores[i] < studAvgScore)
		{
			cout << "- " << students[i] << "\n";
		}
	}

	cout << "\nStudents not listed above:\n";
	//loop used to find students not listed above
	for(size_t i = 0; i < scores.size(); i++)
	{
		if(scores[i] > studAvgScore && scores[i] != scores[highIndex])
		{
			cout << "- " << students[i] << "\n";
		}
	}
}

studentStats::studentStats()
{
	sum = 0;
	highIndex = 0;
}





