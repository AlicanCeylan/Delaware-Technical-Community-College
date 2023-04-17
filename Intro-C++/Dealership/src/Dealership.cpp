//============================================================================
// Name        : Dealership.cpp
// Author      : Alican Ceylan
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
using namespace std;

int main()
{
	//initialize variables
	int dealerTotal = 0;
	int totalSales = 0;
	int sales = 0;
	int dealers = 0;

	//repetition loop
	for(dealers = 1; dealers < 4; dealers ++)
	{

		do
		{
			if(dealerTotal == 0)
			{
				cout << "Enter first sales amount for Dealership " << dealers << "(negative number to stop):";
				cin >> sales;
				if(sales > 0)
					dealerTotal += sales;
			}
			else
			{
				cout << "Enter next sales amount for Dealership " << dealers << "(negative number to stop): ";
				cin >> sales;
				if(sales > 0)
					dealerTotal += sales;
			}
			if(sales < 0)
			{
				cout << "\nDealer " << dealers << " total sales: $" << dealerTotal << "\n\n";
			}

		}while(sales >= 0);
		totalSales += dealerTotal;
		dealerTotal = 0;
	}

	//display total sales
	cout << "Total sales of all dealerships: $" << totalSales;

	return 0;
}
