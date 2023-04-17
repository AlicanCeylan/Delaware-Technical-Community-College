//============================================================================
// Name        : Ch2_Ex02.cpp
// Author      : Alican Ceylan
// Date        : 02.06.2018
// Description : Chapter 2 Programming Exercise 3
// 		 Collect Month, Date, and Year then return it in the form mm-dd-yyyy
//============================================================================

#include <iostream>
#include "dateType.h"
using namespace std;

int main()
{
	//Welcome message
	cout << "WELCOME TO THE DATE CALCULATOR\n";

	//variable declaration
	int month = 1;
	int day = 0;
	int year = 0;

	//Instantiate dayType object
	dateType myDateType;

	//directions to exit program
	cout << "\nEnter 0 for month to quit\n";

	//loop to collect and process date
	while(month > 0)
	{
		cout << "\nenter month: ";
		cin >> month;
		if(month > 0)
		{
			cout << "enter day: ";
			cin >> day;
			cout << "enter year: ";
			cin >> year;

			//display user date
			cout << "\nUser date --------> " << month << "-" << day << "-" << year;

			//process date and print
			myDateType.setDate(month, day, year);
			cout << "\nProcessed Date ---> ";
			myDateType.printDate();
			cout << "\n";
		}
	}

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
