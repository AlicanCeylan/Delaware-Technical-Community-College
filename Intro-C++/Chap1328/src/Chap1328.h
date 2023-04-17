//=======================================================================================================
// Name        : Chap1328.h
// Author      : 
// Version     :
// Copyright   : 
// Description : 
//========================================================================================================

#ifndef CHAP1328_H_
#define CHAP1328_H_

#include <iostream>

using namespace std;

// ***** CLASS DEFINITION *****
class Validation
{
	public:
	   Validation();
	   void validateAndDisplay(string);

	private:


};

// ***** CLASS IMPLEMENTATION *****
//default constructor
Validation::Validation()
{

}

//validateAndDisplay function
//
void Validation::validateAndDisplay(string itemNum)
{
	//validate item number
	if(itemNum.length() != 8)
	{
		cout << "INCORRECT FORMAT - length of string must be 8.";
	}
	else if(itemNum.substr(0,1) != "A"||
			itemNum.substr(0,1) != "B"||
			itemNum.substr(0,1) != "C")
	{
		cout << "INCORRECT FORMAT - first character must be A, B, or C.\n";
	}
	else if(itemNum.substr(1,1) != "1"||
			itemNum.substr(1,1) != "2"||
			itemNum.substr(1,1) != "3")
	{
		cout << "INCORRECT FORMAT - second character must be 1, 2, or 3.\n";
	}
	else if(itemNum.substr(2,1) != "4"||
			itemNum.substr(2,1) != "5"||
			itemNum.substr(2,1) != "6")
		{
			cout << "INCORRECT FORMAT - third character must be 4, 5, or 6.\n";
		}
	else if(itemNum.substr(3,1) != "-")
		{
			cout << "INCORRECT FORMAT - fourth character must be a hyphen.\n";
		}
	else if(itemNum.substr(4,1) != "D"||
			itemNum.substr(4,1) != "E")
		{
			cout << "INCORRECT FORMAT - fifth character must be D or E.\n";
		}
	else if(itemNum.substr(5,1) != "7"||
			itemNum.substr(5,1) != "8"||
			itemNum.substr(5,1) != "9")
		{
			cout << "INCORRECT FORMAT - sixth character must be 7, 8, or 9.\n";
		}
	else if(itemNum.substr(6,1) != " ")
		{
			cout << "INCORRECT FORMAT - fourth character must be a blank space.\n";
		}
	else if(itemNum.substr(7,1) != "X"||
			itemNum.substr(7,1) != "Y"||
			itemNum.substr(7,1) != "Z")
		{
			cout << "INCORRECT FORMAT - sixth character must be X, Y, or Z.\n";
		}
	else
	{
		cout << "Correct format - item number with hyphen and" <<
				" blank space removed ---> " << itemNum.substr(0,3)
				<< itemNum.substr(5,2) << itemNum.substr(8,1) << "\n";
	}
}

#endif /* CHAP1328_H_ */
