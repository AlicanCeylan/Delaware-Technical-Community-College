//=======================================================================================================
// Name        : Chap1022.h
// Author      : Alican Ceylan
// Version     :
// Copyright   : 03.13.2017
// Description : Chapter 10 – Exercise 22
// 				 Calculate and display total amount customer owes, including
//				 shipping charge, if any
//========================================================================================================

#ifndef CHAP1022_H_
#define CHAP1022_H_

// ***** CLASS DEFINITION *****
class Shipping
{
	public:
	   Shipping();
	   void calcStandard(double, double &);
	   void calcPremium(double, double &);

	private:
};

// ***** CLASS IMPLEMENTATION *****
//default constructor
Shipping::Shipping()
{

}

//calcStandard function 
//
void Shipping::calcStandard(double subtotal, double &shipping)
{

	//determine shipping prices for standard membership
	if(subtotal >= 0 && subtotal < 100)
	{
		shipping = 12.99;
	}
	else
	{
		shipping = 8.99;
	}

}

//calcPremium function 
//
void Shipping::calcPremium(double subtotal, double &shipping)
{
	//determine shipping prices for premium membership
	if(subtotal >= 0 && subtotal < 50)
	{
		shipping = 6.99;
	}
	else
	{
		shipping = 0;
	}
}

#endif /* CHAP1022_H_ */
