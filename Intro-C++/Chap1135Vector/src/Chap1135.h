//==============================================================================
// Name        : Chap1135.h
// Author      : 
// Version     :
// Copyright   : 
// Description : 
//==============================================================================

#ifndef CHAP1135_H_
#define CHAP1135_H_

#include <iostream>
#include <vector>

using namespace std;

// ***** CLASS DEFINITION *****
class Dealership
{
	public:
	   Dealership();
	   void calcContribution (vector<double>, double);
	   void dspContribution (double, double, double);

	private:
	   double x;
	   double xx;
	   double xxx;
};

// ***** CLASS IMPLEMENTATION *****
//default constructor
Dealership::Dealership()
{
	x = 0.0;
	xx = 0.0;
	xxx = 0.0;

}

//calcContribution function
//
void Dealership::calcContribution(vector<double>, double)
{
	

}

//dspContribution function 
//
void Dealership::dspContribution(double, double, double)
{
	
}

#endif /* CHAP1135_H_ */
