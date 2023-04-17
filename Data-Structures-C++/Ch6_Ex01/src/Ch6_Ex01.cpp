//============================================================================
// Name        : Ch6_Ex01.cpp
// Author      : Alican Ceylan
// Date		   : 03.27.2018
// Description : Chapter 6 Exercise 2
//    collect the max number of stars a user wants for a pattern then use a
//    recursive function to display the pattern
//============================================================================


#include <iostream>
#include "starGrid01.h"
using namespace std;

int main()
{
	//variable declarations
	int lines = 0;

	//object instantiation
	starPatterns myStarPatterns;

	//welcome message
	cout << "WELCOME TO THE GRID PATTERN CREATOR\n";

	//loop to get proper user input and display results
	while (lines <= 0)
	{
		cout << "\nEnter grid pattern size: ";
		cin >> lines;
		cout << "\n";

		//call to method that displays pattern
		myStarPatterns.displayStars(lines);

		//display completion of grid pattern
		if(lines > 0)
			cout << "\n" << lines << " Star Grid Pattern Complete.\n";
	}

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
