//***********************************************************************************
// Author: B. Lord
// Modified by: Alican Ceylan
// Modified date: 03.27.2018
// Modifications: added the implementations of the constructor and displayStars
//  function
// Class description: This class defines the member functions that implement the
// basic properties for working with recursive calls.
//***********************************************************************************
 
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class starPatterns
{

// ---------- CLASS DEFINITION ----------

    public:
        starPatterns();
        // Default constructor to assign default value to class instance variable
        // Postcondition: A single asterisk is assigned to class instance variable
        void displayStars(int lineNo, int lines);
        // Recursive Function to display pattern of stars based on user input for
        // the maximum number of stars that make up the grid pattern
        // This function receives two integer values; one is the maximum number
        // of stars that are to be in the pattern an the other is the current line
        // number
        // This function recursively calls itself  until the base case is reached,
        // which ends the execution of this function
        // Postcondition: Star pattern is displayed to the console with the maximum
        //                number of stars specified by the user

    private:
        char oneStar;         // Variable to store one asterisk

};

// ---------- CLASS IMPLEMENTATION ----------


starPatterns::starPatterns()
{
	oneStar = '*';
}

void starPatterns::displayStars(int lineNo, int lines)
{


	if(lines < 0)
			cout << endl << "Please enter a non negative number.\n";
	else
	{
		if (lineNo > lines)
			return;
		else
		{
			//loop to draw top half of diamond
			if(lineNo < lines)
			{
				cout << setw(lines - lineNo + 1);
				for (int i = 1; i <= lineNo; i++)
				{
					cout << " " << oneStar;
				}
				cout << endl;
			}

			//recursive call
			displayStars(lineNo + 1, lines);

			//loop to draw bottom half of diamond
			cout << setw(lines - lineNo + 1);
			for (int i = 1; i <= lineNo; i++)
			{
				cout << " " << oneStar;
			}

			//display completion
			if(lineNo == 1)
				cout << "\n\n" << lines << " Star grid pattern Complete.";
			else
				cout << endl;
		}
	}
}



