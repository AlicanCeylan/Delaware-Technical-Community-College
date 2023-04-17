//*************************************************************
// Name         : pointTypeImp.cpp
// Author       : Alican Ceylan
// Date         : 02.08.2018
// Description  : Chapter 2 Programming Exercise 3
//				  This class specifies the member functions
// that implement the basic properties for working with points
// on a grid.
// ************************************************************


#include <iostream>
#include <iomanip>
#include "pointType.h"

using namespace std;

void pointType::setPoints(double x, double y)
{
	pointX = x;
	pointY = y;
}

double pointType::getX() const
{
	return pointX;
}

double pointType::getY() const
{
	return pointY;
}

void pointType::printPoints() const
{
cout << fixed << setprecision(2);

	cout << "\nX Coordinate entered ---> (" << getX() << ")";
	cout << "\nX Coordinate entered ---> (" << getY() <<")\n";
	cout << "X Y Coordinates --------> (" << pointX << ", " << pointY << ")";
}

pointType::pointType()
{

}

