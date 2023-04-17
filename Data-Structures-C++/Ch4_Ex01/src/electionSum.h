//*************************************************************************
// Author: B. Lord
// Modified by: Alican Ceylan
// Modified date: 03.13.2018
// Modicications: Add the implementation of the functions for the class
//
// Class description: This class specifies the member functions
// that implement the basic properties for working with vectors.
//*************************************************************************

#include <iostream>
#include <iomanip>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class electionSummary
{

// ---------- CLASS DEFINITION ----------

    public:
        int sumVotes(vector<int> votes, int listSize);
        // Function to sum number of votes cast during the election.
        // Postcondition: The sum of votes cast is returned to the caller of
        //                this function.

        int detWinner(vector<int> votes, int listSize);
        // Function to determine the winner of the election.
        // Postcondition: The vector index for the election winner is returned to
        //                the caller of this function.

        void displayResults(vector<string> candidate, vector<int> vote,  int sumOfVotes, string winnersName);
        // Function to display required output items. Also calculates the percentage
        // of votes received for each candidate.
        // Postcondition: Each candidate name, votes received, calculated percentage
        //                of votes received, and the winner of the election are
        //                displayed in the console.

        electionSummary();
        // Default constructor
        // Initializes instance variables
        // Postcondition: The sum and winnerIndex instance variables initialized to 0

        private:
            int sum;                // Variable to store sum (total votes cast)
            int winnerIndex;        // Variable to store vector index of winner
};

// ---------- CLASS IMPLEMENTATION ----------

int electionSummary::sumVotes(vector<int> votes, int listSize)
{
	//loop used to calculate sum
	for(int i = 0; i < listSize; i++)
	{
		sum += votes[i];
	}

	return sum;
}

int electionSummary::detWinner(vector<int> votes, int listSize)
{
	//variable declaration
	int mostVotes = 0;

	//loop used to find index of winner
	for(int i = 0; i < listSize; i++)
	{
		if(votes[i] > mostVotes)
		{
			mostVotes = votes[i];
			winnerIndex = i;
		}
	}

	return winnerIndex;
}

void electionSummary::displayResults(vector<string> candidate, vector<int> vote,  int sumOfVotes, string winnersName)
{
	//display results
	cout << "\nCandidate    Votes Received    % of Total Votes\n";
	cout << "---------    --------------    ----------------\n";
	for(size_t i = 0; i < candidate.size(); i++)
	{
		if(candidate[i] == "Jackson")
		{
			cout << candidate[i] << "          " << vote[i] << "                 " <<
					setprecision(2) << fixed << (vote[i] * 100.00 / sumOfVotes) << "\n";
		}
		else if(candidate[i] == "Mills")
		{
			cout << candidate[i] << "            " << vote[i] << "                 " <<
				 (vote[i] * 100.00 / sumOfVotes) << "\n";
		}
		else if(candidate[i] == "Dudley")
		{
			cout << candidate[i] << "           " << vote[i] << "                 "  <<
					(vote[i] * 100.00 / sumOfVotes) <<"\n";
		}
		else if(candidate[i] == "Robinson")
		{
			cout << candidate[i] << "         " << vote[i] << "                 " <<
					 (vote[i] * 100.00 / sumOfVotes) <<"\n";
		}
		else
		{
			cout << candidate[i] << "          " << vote[i] << "                  " <<
					(vote[i] * 100.00 / sumOfVotes) << "\n";
		}
	}
	cout << "                 -----\n";
	cout << "Total Votes      " << sumOfVotes;

	cout <<"\n\nThe winner of the election --> "  << winnersName << ".";
}

electionSummary::electionSummary()
{
	sum = 0;
	winnerIndex = 0;
}


