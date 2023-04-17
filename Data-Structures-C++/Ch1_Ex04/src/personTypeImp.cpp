//***************************************************************
// Author: D.S. Malik
// Modified by: Alican Ceylan
// Modified date: 01.18.2018
// Modicications: add three new functions and middle name variable
// Class description: This class specifies the member functions 
// that implement the basic properties for working with names.
//***************************************************************

 
#include <iostream>
#include <string>
#include "personType.h"

using namespace std;

// ---------- CLASS IMPLEMENTATION ----------

void personType::print() const
{
    cout << firstName << " " << middleName << " " << lastName;
}

void personType::setName(string first, string middle, string last)
{
    firstName = first;
    middleName = middle;
    lastName = last;
}

string personType::getFirstName() const
{
    return firstName;
}

string personType::getLastName() const
{
    return lastName;
}

string personType::getMiddleName() const
{
	return middleName;
}

void personType::isFirstName()
{
	if (firstName == BASE_FIRST)
	{
		cout << "\nPerson's first name is Mary";
	}
	else
	{
		cout << "\nPerson's first name is not Mary";
	}
}

void personType::isMiddleName()
{
	if (middleName == BASE_MID)
		{
			cout << "\nPerson's first name is Beth";
		}
		else
		{
			cout << "\nPerson's first name is not Beth";
		}
}


void personType::isLastName()
{
	if (lastName == BASE_LAST)
		{
			cout << "\nPerson's first name is Regan\n";
		}
		else
		{
			cout << "\nPerson's first name is not Regan\n";
		}
}



// Default constructor
personType::personType() 
{ 
    firstName = "";
    lastName = "";
}

// Constructor with parameters
personType::personType(string first, string middle, string last)
{ 
    firstName = first;
    middleName = middle;
    lastName = last;
}

