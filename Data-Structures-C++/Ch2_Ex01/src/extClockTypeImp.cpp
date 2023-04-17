//*******************************************************
// Author       : Alican Ceylan
// Date         : 01.30.2018
// Description  : Chapter 2 Programming Exercise 1
//                Clock Type Implementation File
//*******************************************************

#include <iostream>
#include "extClockType.h"

using namespace std;

// ---------- CLASS IMPLEMENTATION ---------

void extClockType::setNewTime(int hours, int minutes, int seconds, string timeZone)
{
	clockType::setTime(hours, minutes, seconds);

	if(timeZone == "EST")
	{
		tZone = "EST";
	}
	else if(timeZone == "CST")
	{
		tZone = "CST";
	}
	else if(timeZone == "MST")
	{
		tZone = "MST";
	}
	else if(timeZone == "PST")
	{
		tZone = "PST";
	}
	else if(timeZone == "EDT")
	{
		tZone = "EDT";
	}
	else if(timeZone == "CDT")
	{
		tZone = "CDT";
	}
	else if(timeZone == "MDT")
	{
		tZone = "MDT";
	}
	else if(timeZone == "PDT")
	{
		tZone = "PDT";
	}
	else
	{
		tZone = "";
	}
}

void extClockType::printTime() const
{
	clockType::printTime();

	cout << " " << tZone;

}


//constructor with parameters
extClockType::extClockType(int hours, int minutes, int seconds, string timeZone)
:clockType(hours, minutes, seconds)
{

	if(timeZone == "EST")
		{
			tZone = "EST";
		}
		else if(timeZone == "CST")
		{
			tZone = "CST";
		}
		else if(timeZone == "MST")
		{
			tZone = "MST";
		}
		else if(timeZone == "PST")
		{
			tZone = "PST";
		}
		else if(timeZone == "EDT")
		{
			tZone = "EDT";
		}
		else if(timeZone == "CDT")
		{
			tZone = "CDT";
		}
		else if(timeZone == "MDT")
		{
			tZone = "MDT";
		}
		else if(timeZone == "PDT")
		{
			tZone = "PDT";
		}
		else
		{
			tZone = "";
		}

}

//default constructor
extClockType::extClockType()
:clockType()
{
	tZone = "";
}

