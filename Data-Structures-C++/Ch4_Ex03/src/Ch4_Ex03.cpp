// ************************************************************
// Name         : Ch4_Ex02.cpp
// Author       : Alican Ceylan
// Date			: 03.13.2018
// Description  : Chapter 4 Programming Exercise 3
// The program outputs the vector size, largest number in the
// vector, smallest number in the vector, sum of the numbers
// in the vector, and an average of the numbers in the vector.
// ************************************************************

#include <iostream>
#include "vectorList.h"
using namespace std;

int main()
{
	//welcome message
	cout << "WELCOME TO THE VECTOR PROCESSOR";

	//prompt user for numbers
	cout << "\n\nEnter Numbers (-999 to quit):\n";

	//instantiate object
	vectors myVectors;

	//call to fillVector function
	myVectors.fillVector();

	//EOP message
	cout << "\n\nEnd of Program.";

	return 0;
}
