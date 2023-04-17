// ************************************************************
// Name         : Ch4_Ex01.cpp
// Author       : Alican Ceylan
// Date			: 03.13.2018
// Description  : Chapter 4 Programming Exercise 1
//    The program is used to find each candidate’s name, votes
//    received, percentage of the total votes received,
//    and the winner of the election.
// ************************************************************


#include <iostream>
#include <iomanip>
#include <string>
#include <vector>
#include <algorithm>

#include "ElectionSum.h"
using namespace std;

int main()
{
	//variable declaration
	int x = 0;
	int y = 0;
	int sum = 0;
	int winnerIndex = 0;
	string winner = "";
	vector<string> candidates(5);
	vector<int> votes(5);

	//object instantiation
	electionSummary myElectionSum;

	//welcome message
	cout << "WELCOME TO THE ELECTION RESULT CALCULATOR\n";

	//prompt user for input
	cout << "\nEnter a candidate name and the votes received by that candidate:\n";

	//loop used to populate vectors
	for(int i = 0; i < 10; i++)
	{
		if(i%2 == 0)
		{
			cin >> candidates[x];
			x++;
		}
		else if(i%2 == 1)
		{
			cin >> votes[y];
			y++;
		}
	}

	//calculate and store sum, winnerIndex and winner name
	sum = myElectionSum.sumVotes(votes, votes.size());
	winnerIndex = myElectionSum.detWinner(votes, votes.size());
	winner = candidates[winnerIndex];

	//display results
	myElectionSum.displayResults(candidates, votes, sum, winner);

	//EOP message
	cout << "\n\nEnd of Program.";

	return 0;
}
