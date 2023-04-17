//***************************************************************
// Author: D.S. Malik
// Modified by: Alican Ceylan
// Modified date: 02.06.2018
// Modifications: added a check for valid month, year, and day
// added function to check for leap year
// Class description: This class specifies the member functions 
// that implement the basic properties for working with dates.
//***************************************************************

#include <iostream>
#include "dateType.h"

using namespace std;
 
// ---------- CLASS IMPLEMENTATION ----------

void dateType::setDate(int month, int day, int year)
{
    dMonth = month;
    dDay = day;
    dYear = year;

    int validate = 1;
    int leapYear = isLeapYear(year);

    //loops used to validate month, day, and year
    if(month < 0 || month > 12)
    {
    	dMonth = 1;
    }

    if(year < 1900)
    {
    	dYear = 1900;
    }

    if(month == 4 || month == 6 || month == 9 || month == 11)
    {
    	if(day > 30 || day < 0)
    	{
    		dDay = 1;
    	}
    }
    else if(month == 2)
    {
    	if(leapYear == validate)
    	{
    		if(day < 0 || day > 29)
    		{
    			dDay = 1;
    		}
    	}
    	else
    	{
    		if(day < 0 || day > 28)
			{
    			dDay = 1;
			}
    	}
    }
    else if(day < 0)
    {
    	dDay = 1;
    }
}

int dateType::getDay() const 
{
    return dDay;
}

int dateType::getMonth() const 
{
    return dMonth;
}

int dateType::getYear() const 
{
    return dYear;
}

void dateType::printDate() const
{
    cout << dMonth << "-" << dDay << "-" << dYear;
}

int dateType::isLeapYear(int year)
{
	//loop used to determine leap year
	if (((dYear % 4 == 0) && !(dYear % 100 == 0))|| (dYear % 400 == 0))
	{
		return 1;
	}
	else
	{
		return 0;
	}
}

// Constructor with parameters
dateType::dateType(int month, int day, int year) 
{ 
    setDate(month, day, year);
}

