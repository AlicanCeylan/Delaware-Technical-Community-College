//============================================================================
// Name        : Ch2_Ex03.cpp
// Author      : Alican Ceylan
// Date        : 02.08.2018
// Description : Chapter 2 Programming Exercise 3
// 				 Collect the x and y value from user and return a point
//============================================================================

#include <iostream>
#include <iomanip>
#include "pointType.h"

using namespace std;

int main()
{
//welcome message
cout << "WELCOME TO THE X-Y COORDINATE FINDER\n";


//variable declaration
double x = 1.0;
double y = 0.0;

//object instantiation
pointType myPointType;

//display exit instructions
cout << "\nEnter 0 for X coordinate to quit.\n";

//collect input from user
while(x != 0)
{
	cout << "\nEnter X Coordinate: ";
	cin >> x;
	if(x != 0)
	{
		cout << "Enter Y Coordinate: ";
		cin >> y;

		//set points
		myPointType.setPoints(x, y);

		//display X coordinate and Y coordinate entered
		myPointType.printPoints();
		cout << "\n";
	}
}
//EOP message
cout << "\nEnd of Program.";
	return 0;
}
