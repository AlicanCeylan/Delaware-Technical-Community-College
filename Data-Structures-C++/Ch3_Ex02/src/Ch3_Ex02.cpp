//*************************************************************
// Name         : Ch3_Ex02.cpp
// Author       : Alican Ceylan
// Date         : 02.20.2018
// Description  : Chapter 3 Programming Exercise 2
//		remove all occurrences of a value from the list
// ************************************************************

#include <iostream>
#include "arrayListType.H"
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

	//collect number user would like to remove
	cout << "\nEnter the number you would like removed: ";
	cin >> number;

	//remove number in list and display to console
	if(intList.seqSearch(number) != -1)
	{
		intList.removeAll(number);
		cout << "\nAfter removing index " << number << ", list is ---> ";
		intList.print();
		cout << "List size reduced to ---> " << intList.listSize() << "\n";
	}
	else
	{
		cout << "\nERROR - number not found for removal.\n";
	}
	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
