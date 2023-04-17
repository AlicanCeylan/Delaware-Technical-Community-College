//============================================================================
// Name        : Ch10_Ex02.cpp
// Author      : 
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include "arrayListType.h"
using namespace std;

//function declaration
void printListInfo(arrayListType<int> &passedList);

int main()
{
	//variable declaration
	arrayListType<int> myIntList;
	int number = 0;
	int i = 0;

	//welcome message
	cout << "WELCOME TO THE ARRAY SORTER\n";

	//Exit directions
	cout << "\nEnter -999 to stop data entry.\n";

	//loop used to collect integers
	cout << "\nEnter integer values:\n";
	while (number != -999)
	{
		cin >> number;
		if(number != -999)
		{
			myIntList.insertAt(i, number);
			i++;
		}
	}

	//display list info by calling lower-level function
	printListInfo(myIntList);

	//EOP message
	cout << "\n\nEnd of Program.";

	return 0;
}

void printListInfo(arrayListType<int> &passedList)
{
	//display list entered to console
		cout << "\nThe list you entered ------> ";
		passedList.print();

		//sort list
		passedList.insertionSort();

		//display sorted list
		cout << "\n\nThe list after sorting ---> ";
		passedList.print();

		//display list size and max list size
		cout << "\nList size is: " << passedList.listSize();
		cout << "\nMax List size is: " << passedList.maxListSize();
}
