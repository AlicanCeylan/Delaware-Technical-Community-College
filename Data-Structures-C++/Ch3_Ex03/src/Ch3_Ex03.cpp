//*************************************************************
// Name         : Ch3_Ex03.cpp
// Author       : Alican Ceylan
// Date         : 02.20.2018
// Description  : Chapter 3 Programming Exercise 3
//		find and display the minimum value from the list
// ************************************************************

#include <iostream>
#include "arrayListType.h"
using namespace std;

int main()
{
	//declare variables
	arrayListType<int> intList(100);
	int number = 0;

	//welcome message
	cout << "WELCOME TO THE MINIMUM NUMBER FINDER\n";

	//collect input from user
	cout << "\nEnter 10 integers:\n";

	//loop used to collect integers
	for (int i = 0; i < 10; i++)
	{
		cin >> number;
		intList.insertAt(i, number);
	}

	//display list entered to console
	cout << "\nThe list you entered is --->";
	intList.print();
	cout << endl;

	//display smallest number in the list
	cout << "The smallest number in the list ---> ";
	intList.minValue();
	cout << endl;

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
