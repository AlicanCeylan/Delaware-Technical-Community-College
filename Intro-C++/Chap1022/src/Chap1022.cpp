//============================================================================
// Name        : Chap1022.cpp
// Author      : Alican Ceylan
// Version     :
// Copyright   : 03.13.2017
// Description : Chapter 10 – Exercise 22
// 				 Calculate and display total amount customer owes, including
//				 shipping charge, if any
//============================================================================

#include <iostream>
#include <iomanip>
#include "Chap1022.h"

using namespace std;

//function prototypes
void getStatus(char &);
void validateCalculate(char);
void endPgm();

int main()
{
	//call to lower-level function
	endPgm();
	return 0;
}

// ***** getStatus function description ***** 
// 
void getStatus(char &mbrship)
{

	//Display console title and menu
	cout << "SHIPPING CHARGE CALCULATOR\n" << "\nS - Standard" <<
			"\nP - Premium"<< "\n";
	
	//collect membership status from user
	cout << "\nEnter customer's membership status (S or P): ";
	cin >> mbrship;

	validateCalculate(mbrship);
}

// ***** validateCalculate function description *****
//
void validateCalculate(char membership)
{

	//variable declarations
	double subtotal = 0.0;
	double shipping = 0.0;
	double total = 0.0;

	//instantiate a shipping object
	Shipping myShipping;
	
	//Determine if user entered a valid membership status
	if(toupper(membership) == 'P' || toupper(membership) == 'S')
	{
		cout << "Enter amount due before shipping: ";
		cin >> subtotal;
	}
	else
	{
		cout << "\nINVALID ENTRY - S or P only\n";
	}

	//determine the amount entered and where to send
	if(subtotal <= 0)
	{
		cout << "\nINVALID ENTRY - Must be greater than zero.\n";
	}
	else
	{
		if(toupper(membership) == 'P')
		{
			myShipping.calcPremium(subtotal, shipping);
		}
		else if(toupper(membership) == 'S')
		{
			myShipping.calcStandard(subtotal, shipping);
		}
	}

	//calculate and display total
	if(subtotal > 0)
	{
		total = subtotal + shipping;
		cout << "\nTotal amount due: $" << fixed << setprecision(2) << total <<
			"\n";
	}
}

// ***** endPgm function description *****
//
void endPgm()
{
	char mbrshipStatus = ' ';
	getStatus(mbrshipStatus);

	//EOP message
	cout << "\nEnd of Program.";
}

