//============================================================================
// Name        : Ch6_Ex04.cpp
// Author      : Alican Ceylan
// Date		   : 03.27.2018
// Description : Chapter 6 Exercise 4
//     Collected a string from a user then counted the number of vowels
//     using a recursive function
//============================================================================

#include <iostream>
#include <string>
#include <algorithm>
#include "vowelCount.h"
using namespace std;

int main()
{
	//variable declaration
	string str = "";
	string upperStr = "";
	int length = 0;
	int numVowels = 0;

	//object instantiation
	countVowels myCountVowels;

	//welcome statement
	cout << "WELCOME TO THE VOWEL COUNTER\n";

	//display exit instructions
	cout << "\nEnter XXX to stop data entry.\n";

	//collect string from user and display number of vowels
	do
	{
		//collect string
		cout << "\nEnter a string Value: ";
		getline(cin, str);

		//transform whole string to upper
		upperStr = str;
		transform(upperStr.begin(), upperStr.end(), upperStr.begin(), ::toupper);

		//get length of string
		length = str.length();

		//call to recursive function
		numVowels = myCountVowels.numVowels(upperStr, 0, length);

		//display results
		if(upperStr != "XXX")
			cout << "The number of vowels in the string \"" << str << "\" is " << numVowels << ".\n";
	}
	while(upperStr != "XXX");

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
