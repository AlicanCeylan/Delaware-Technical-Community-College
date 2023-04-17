//============================================================================
// Name        : Ch9_Ex01.cpp
// Author      : Alican Ceylan
// Date		   : 04.19.2018
// Description : Chapter 9 exercise 1
//		Find the location of a number in a list using a recursive function
//============================================================================

#include <iostream>
#include "arrayListType.h"
using namespace std;

int main()
{
	//declare variables
	arrayListType<int> intList(100);
	int number = 0;
	int i = 0;
	int srcNum = 0;
	int numIndex = 0;

	//welcome message
	cout << "WELCOME TO THE ARRAY POSITION FINDER\n";

	//Exit directions
	cout << "\nEnter -999 to stop data entry.\n";

	//loop used to collect integers
	cout << "\nEnter integer values:\n";
	while (number != -999)
	{
		cin >> number;
		if(number != -999)
		{
			intList.insertAt(i, number);
			i++;
		}
	}

	//display list entered to console
	cout << "\nThe list you entered is ---> ";
	intList.print();

	//display list size
	cout << "list size is ----------------> " << intList.listSize();

	//collect number to search for
	cout << "\n\nWhat number in the list do you want to search for? ";
	cin >> srcNum;

	//display position of number in array
	numIndex = intList.recSeqSearchImp(srcNum);
	if(numIndex == -1)
		cout <<  "The number " << srcNum << " was not found in the list.";
	else
		cout << "The number " << srcNum << " was found in position " << numIndex << " of the list.";

	//EOP message
	cout << "End of Program.";

	return 0;
}
