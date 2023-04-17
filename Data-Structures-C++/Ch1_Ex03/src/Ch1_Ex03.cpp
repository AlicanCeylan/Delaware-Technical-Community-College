//============================================================================
// Name        : Ch1_Ex03.cpp
// Author      : Alican Ceylan
// Date        : 01.16.2018
// Description : collect current day and determine previous day, next day, and
//				 the day for number of days from currrent day
//============================================================================

#include <iostream>
#include <algorithm>
#include "dayType.h"
using namespace std;

int main()
{
	string currentDay = "";
	string newDay = "";
	int numDays = 0;

	//display welcome message
	cout << "WELCOME TO THE DAY FINDER";

	while (currentDay != "XXX")
	{
		//collect day from user
		cout << "\n\nEnter a day of the week (type XXX to quit): ";
		cin >> currentDay;

		if (currentDay == "xxx")
		{
			transform(currentDay.begin(), currentDay.end(), currentDay.begin(), ::toupper);
		}

		if (currentDay != "XXX")
		{
			//instantiate a day type object
			dayType myDayType;

			//send day to header file
			myDayType.setDay(currentDay);

			//return current day to console
			cout << "Current day - " << myDayType.getDay();

			//return current day to console
			cout << "\nPrevious day - " << myDayType.prevDay();

			//return current day to console
			cout << "\nNext day - " << myDayType.nextDay();

			//collect number of days away
			cout << "\n\nEnter number of days away: ";
			cin >> numDays;

			//find the new day and display it to console
		    myDayType.addDay(numDays);
		    cout << " days away - " << myDayType.getDay();

		}
	}

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
