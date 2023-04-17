//*************************************************************
// Name				: Ch1_Ex01.cpp
// Author			:  FirstName LastName
// Date				: 01.16.2018
// Description		: Chapter 1 Programming Exercise 1
//                    Convert Roman Numeral to Decimal number
// ************************************************************

#include <iostream>
#include <algorithm>
#include "romanType.h"
using namespace std;

int main()
{
	//variable declaration
	string romanString = "";

	//display welcome message
	cout << "WELCOME TO THE ROMAN NUMERAL CONVERTER\n";

	//while loop used to collect Roman numeral and convert
	while (romanString != "END")
	{

		cout << "\nEnter a Roman Numeral (type END to quit): ";
		cin >> romanString;

		//Capitalize the string variable
		transform(romanString.begin(), romanString.end(), romanString.begin(), ::toupper);

		//if loop used to convert Roman numeral
		if (romanString != "END")
		{

			//instantiate a romanType object
			romanType myRomanType;

			//call setRoman method
			myRomanType.setRoman(romanString);

			//display results
			cout << "\nThe equivalent of the Roman Numeral ", myRomanType.printRoman();
			cout << " is ",  myRomanType.printDecimal();
			cout << ".\n";

		}

	}

	//display EOP message
	cout << "\nEnd of Program.";


	return 0;
}
