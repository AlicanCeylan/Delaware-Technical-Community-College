//============================================================================
// Name        : Ch6_Ex05.cpp
// Author      : Alican Ceylan
// Date		   : 03.27.2018
// Description : Chapter 6 Exercise 5
//     Collect integers into an array from the user then calculated the sum
//     using a recursive function
//============================================================================

#include <iostream>
#include "sumArrayValues.h"
using namespace std;

int main()
{
	//variable declarations
	int size = 0;
	int sum = 0;

	//object instantiation
	sumElements mySumElements;

	//welcome message
	cout << "WELCOME TO THE ARRAY CALCULATOR\n";

	//collect array size
	cout << "\nEnter the number of elements you would like in the array: ";
	cin >> size;

	int sumArray[size];

	//collect array elements with for loop
	cout << "\nEnter integer values:\n";
	for(int i = 0; i < size; i++)
	{
		cin >> sumArray[i];
	}

	//get sum of array and display the results
	sum = mySumElements.sumArray(sumArray, 0, size);
	cout << "\nThe sum of values in the array ---> " << sum << ".\n";

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
