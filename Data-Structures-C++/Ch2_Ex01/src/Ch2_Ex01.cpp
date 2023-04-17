//============================================================================
// Name        : Ch2_Ex01.cpp
// Author      : Alican Ceylan
// Date        : 02.06.2018
// Description : Chapter 2 Programming Exercise 1
// 				 collect Hour, Minute, Second, and time zone and return
// 				 time in format "00:00:00 TIMEZONE"
//============================================================================

#include <iostream>
#include "extClockType.h"
using namespace std;

int main()
{
	//declare variables
	int hr = 0;
	int min = 0;
	int sec = 0;
	string tZone = "";

	//instantiate an extended clock type object
	extClockType myExtClockType;

	//Welcome message
	cout << "WELCOME TO THE TIME CALCULATOR";

	//display to console how to exit
	cout << "\n\nEnter negative value for hour to quit.\n";

	//loop used to get time and display it
	while(hr >= 0)
	{
		cout << "\nEnter hour:      ";
		cin >> hr;
		if(hr >= 0)
		{
			cout << "Enter minute:    ";
			cin >> min;

			cout << "Enter second:    ";
			cin >> sec;

			cout << "Enter time-zone: ";
			cin >> tZone;

			myExtClockType.setNewTime(hr, min, sec, tZone);

			cout << "\nTime entered --> ";
			myExtClockType.printTime();
			cout << "\nIncremented ---> ";

			//increment time and print to console
			myExtClockType.incrementHours();
			myExtClockType.incrementMinutes();
			myExtClockType.incrementSeconds();
			myExtClockType.printTime();
			cout << endl;
		}

	}

	//EOP message
	cout << "\nEnd of Program.";
	return 0;
}
