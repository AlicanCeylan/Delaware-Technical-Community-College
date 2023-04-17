//*************************************************************
// Name         : pointTypeImp.cpp
// Author       : Alican Ceylan
// Date         : 02.08.2018
// Description  : Chapter 2 Programming Exercise 3
//				  This class defines the member functions
// that implement the basic properties for working with points
// on a grid.
// ************************************************************

#ifndef POINTTYPE_H_
#define POINTTYPE_H_

class pointType
{
public:

	void setPoints(double x, double y);
	// Function to set the date.
	// The member variables pointX and pointY are set
	// according to the parameters.
	// Postcondition: pointX = x; pointY = y;

	double getX() const;
	// Function to return the point x.
	// Postcondition: The value of pointX is returned.

	double getY() const;
	// Function to return the point Y.
	// Postcondition: The value of pointY is returned.

	void printPoints() const;
	// Function to print the point
	// Postcondition: Point is printed in the form (x,y)  .

	pointType(double x, double y);
	// Default constructor with parameters

	pointType();
	// Default constructor

private:
	double pointX;
	double pointY;
};

#endif /* POINTTYPE_H_ */
