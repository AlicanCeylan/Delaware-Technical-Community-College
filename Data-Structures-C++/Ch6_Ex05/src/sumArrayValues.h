//***********************************************************************************
// Author: B. Lord
// Modified by: Alican Ceylan
// Modified date: 03.27.2018
// Modifications: added the implementation of the constructor and the sumArray method
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

class sumElements
{

// ---------- CLASS DEFINITION ----------

    public:
        sumElements();
        // Default constructor to assign default values to class instance variables
        // Postcondition: Default values are assigned to class instance variables
        int sumArray(const int arrayList[], int low, int len);
        // Recursive Function to sum the values contained in an array 
        // This function requires three parameters; one is the array, one is the
        // lowest index in the array, and one is the length of the array
        // This function recursively calls itself  until the base case is reached,
        // which ends the execution of this function
        // Postcondition: The sum of the values contained in the array are returned
        //                to the caller of this function

    private:
};

// ---------- CLASS IMPLEMENTATION ----------


sumElements::sumElements()
{

}//end constructor

int sumElements::sumArray(const int arrayList[], int low, int length)
{
	//if statement to check if it has reached it's limit
	if(length <= low)
		return 0;

	//recursive call
	return (sumArray(arrayList, low, length - 1) + arrayList[length-1]);
}//end sumArray
