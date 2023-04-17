//*************************************************************
// Name         : Ch3_Ex01.cpp
// Author       : Alican Ceylan
// Date         : 02.20.2018
// Description  : Chapter 3 Programming Exercise 1
//		remove a value from index of a list and replace it with
//		value in last index.
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
	cout << "WELCOME TO THE INTEGER PROCESSOR\n";

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

	//collect index number user would like to remove
	cout << "\nEnter the index for the number you would like removed: ";
	cin >> number;

	//remove number in index and display to console
	intList.removeAt(number);
	cout << "\nAfter removing index " << number << ", list is ---> ";
	intList.print();
	cout << "List size reduced to ---> " << intList.listSize() << "\n";

	//EOP message
	cout << "\nEnd of Program.";
	return 0;
}
