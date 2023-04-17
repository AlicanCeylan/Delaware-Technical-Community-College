//*******************************************************
// Author       : Alican Ceylan
// Date         : 01.30.2018
// Description  : Chapter 2 Programming Exercise 1
//                Extended Clock Type Header File
//				  Added a time zone variable
//*******************************************************

#ifndef EXTCLOCKTYPE_H_
#define EXTCLOCKTYPE_H_

#include "clockType.h"
#include <string>

using namespace std;

class extClockType: public clockType
{
public:

	void setNewTime(int hours, int minutes, int seconds, string timeZone);
	// Function to set the time
	// The time is set according to the parameters
	// Postcondition: hr = hours; min = minutes; sec = seconds
	// The function checks whether the values of hours,
	// minutes, and seconds are valid. If invalid,
	// the default value 0 is assigned.


	void printTime() const;
	// Function to print the time
	// Postcondition: Time is printed in the form hh:mm:ss.


	extClockType(int hours, int minutes, int seconds, string timeZone);
	// Constructor with parameters
	// The time is set according to the parameters.
	// Postconditions: hr = hours; min = minutes; sec = seconds
	// The constructor checks whether the values of hours,
	// minutes, and seconds are valid. If a value is invalid,
	// the default value 0 is assigned.


	extClockType();
	 // Default constructor
	// The time is set to 00:00:00.
	// Postcondition: hr = 0; min = 0; sec = 0

private:
	string tZone;
};

#endif /* EXTCLOCKTYPE_H_ */
