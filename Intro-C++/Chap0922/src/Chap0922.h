//=======================================================================================================
// Name        : Chap0922.h
// Author      : Alican Ceylan
// Version     :
// Copyright   : 03.06.2017
// Description : 
//========================================================================================================

#ifndef CHAP0922_H_
#define CHAP0922_H_

#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;

// ***** CLASS DEFINITION *****
class RewardPoints
{
	public:
	RewardPoints();
	double calcStandard(double totPurchase);
    double calcPlus(double totPurchase);
    double calcPremium(double totPurchase);

	private:
           int points;
		
};

// ***** CLASS IMPLEMENTATION *****
//default constructor
RewardPoints::RewardPoints()
{

	points = 0;
}


//calculate standard functions - returns points earned to its caller
//requires one double parameter
double RewardPoints::calcStandard(double totPurchase)
{
	
	return 0;	
}

//
double RewardPoints::calcPlus(double totPurchase)
{
	
	return 0;	
}

//
double RewardPoints::calcPremium(double totPurchase)
{
	
	return 0;
}


#endif /* CHAP0922_H_ */
