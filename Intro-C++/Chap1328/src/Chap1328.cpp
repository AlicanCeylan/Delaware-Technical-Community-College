//============================================================================
// Name        : Chap1328.cpp
// Author      : 
// Version     :
// Copyright   : 
// Description : 
//============================================================================

#include <iostream>
#include <string>
#include "Chap1328.h"

using namespace std;

//function prototypes
string getItemNum(string);
void endPgm();

int main()
{
	//call to lower=level function
	getItemNum(" ");
	
	return 0;
}

// ***** getItemNum function description *****
//
string getItemNum(string itemNum)
{
	//Console Title
	cout << "ITEM NUMBER VALIDATION\n";

	while(itemNum != "X" )
	{
		cout << "\nEnter item number (X to stop): ";
		getline(cin, itemNum);

		if(itemNum != "X")
		{
		//instantiate a validation object
		Validation myValidation;

		myValidation.validateAndDisplay(itemNum);
		}
	}


	//call to lower=level function
	endPgm();
	
	return itemNum;
}


// ***** endPgm function description *****
//
void endPgm()
{
	
}
