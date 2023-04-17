// ************************************************************
// Name         : Ch4_Ex02.cpp
// Author       : Alican Ceylan
// Date			: 03.13.2018
// Description  : Chapter 4 Programming Exercise 2
//    The program is to display the class size, highest test
//    score, class average, names of all students having the
//    highest score, names of all students whose test scores
//    are below the class average, and any remaining students
//    not yet listed.
// ************************************************************
#include "students.h"

using namespace std;

int main()
{
	//variable declarations
	vector<string> students(10);
	vector<double> scores(10);
	double avg;
	double sum;
	int x = 0;
	int y = 0;

	//instantiate objects
	studentStats myStudentStats;

	//welcome message
	cout << "WELCOME TO THE CLASS STATISTICS CALCULATOR\n";

	//Display requirements for entry
	cout << "\nEnter student name and a test score:\n";

	//populate vectors
	for(int i = 0; i < 20; i++)
		{
			if(i%2 == 0)
			{
				cin >> students[x];
				x++;
			}
			else if(i%2 == 1)
			{
				cin >> scores[y];
				y++;
			}
		}

	//calculate sum of scores and the average
	sum = myStudentStats.sumScores(scores);
	avg = sum / students.size();

	//find index of highest score
	myStudentStats.highScoreIndex(scores);

	//display results
	myStudentStats.displayResults(students, scores, avg);

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
