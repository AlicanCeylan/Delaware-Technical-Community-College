//============================================================================
// Name        : Chap1135Vector.cpp
// Author      : Alican Ceylan
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include <vector>
#include "Chap1135.h"

using namespace std;

double getAndCalcSales(vector<double> , double, double);
void endPgm();

int main()
{

	endPgm();
	return 0;
}

// ***** getAndCalcSales function description *****
//
double getAndCalcSales(vector<double> dealership, double dealerTotal, double grandTotal)
{

	//instantiate a shipping object
	Dealership myDealership;

	for(int dealer = 1; dealer < 4; dealer ++)
	{
		double sales = 0.0;

		while(sales >= 0)
		{
			cout << "Enter sales for Dealership " <<
				dealer << " (negative number to stop): ";
			cin >> sales;
				if(sales >= 0)
			{
				dealership.push_back(sales);
				dealerTotal += sales;
			}
			else
			{
				cout << "Dealership total: " << dealerTotal << "\n\n";
			}
		}
		grandTotal += dealerTotal;
		dealerTotal = 0;

	}

	cout << "Grand total of all dealerships: $" << grandTotal << "\n";

	return grandTotal;
}

// ***** endPgm function description *****
//
void endPgm()
{



	//lower-level function
	getAndCalcSales(vector<double> {0}, 0.0, 0.0);

	//EOP message
	cout << "\nEnd of Program.";
}
