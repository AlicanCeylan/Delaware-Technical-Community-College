//***********************************************************************************
// Author: B. Lord
// Modified by: Alican Ceylan
// Modified date: 03.27.2018
// Modifications: Added the implementation of the constructor and numVowels function
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

class countVowels
{

// ---------- CLASS DEFINITION ----------

    public:
        countVowels();
        // Default constructor to assign default value to class instance variable
        // Postcondition: Zero is assigned to class instance variable
        int numVowels(string str, int low, int strLength);
        // Recursive Function to count the number of vowels found in a string of any
        // length
        // This function requires three parameters; one is the string entered by the
        // user, one is the lowest index in the string, and one is the length of the
        // string
        // This function recursively calls itself  until the base case is reached,
        // which ends the execution of this function
        // Postcondition: The number of vowels found in the string is returned to the
        //                caller of this function

    private:
        int counter;              // Variable to store number of vowels               	

};

// ---------- CLASS IMPLEMENTATION ----------

countVowels::countVowels()
{
	counter = 0;
}

int countVowels::numVowels(string str, int lower, int strLength)
{
	//check to see if recursive call should be stopped
	if(str.length() == 0)
		return 0;

	//check string for vowels using a switch statement
	switch(str[lower])
	{
		case 'A':
		case 'E':
		case 'I':
		case 'O':
		case 'U':
			//recursive call
			return 1 + numVowels(str.substr(1), lower++, strLength);
		default:
			//recursive call if no vowels are found
			return numVowels(str.substr(1), lower++, strLength);
	}
}//end numVowels



