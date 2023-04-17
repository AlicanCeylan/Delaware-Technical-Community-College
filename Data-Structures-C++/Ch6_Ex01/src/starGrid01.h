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
        void displayStars(int lines);
        // Recursive Function to display pattern of stars based on user input for
        // the maximum number of stars that make up the grid pattern
        // This function receives one integer value that contains the maximum number
        // of stars that are to be in the grid pattern
        // This function recursively calls itself  until the base case is reached,
        // which ends the execution of this function
        // Postcondition: Star pattern is displayed to the console with the maximum
        //                number of stars specified by the user
 
    private:
        char oneStar;         // Variable to store one asterisk
};

// ---------- CLASS IMPLEMENTATION ----------
//Default constructor
starPatterns::starPatterns()
{
	oneStar = '*';
}//end constructor


//method to display stars to user
void starPatterns::displayStars(int lines)
{
	//check to see if number of lines is greater than zero
	if(lines < 0)
		cout << endl << "Please enter a non negative number.\n";
	else
	{
		if (lines == 0)
			return;
		else
		{
			//loop used to display top portion of pattern
			for(int i = 1; i <= lines; i++)
			{
				cout << oneStar;
			}
			cout << "\n";

			//recursive call
			displayStars(lines - 1);

			//loop used to display bottom half of pattern
			for(int i = 1; i <= lines; i++)
			{
				cout << oneStar;
			}
			cout << "\n";
		}

	}
}//end displayStars

