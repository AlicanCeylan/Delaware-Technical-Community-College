//============================================================================
// Name        : Raise.cpp
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
	int salary= 0;
	int years = 0;
	double rate = 0.0;
	int raise = 0;


	//repetition loop
	do{
		cout << "\nEnter salary (negative number to stop): ";
		cin >> salary;


		for(rate = 0.03; rate < .07; rate += .01)
		{

			cout << "\nRaise rate is " << rate*100 << "%";
			for(years = 1; years <= 3; years ++ )
			{
				raise = (salary * rate) + raise;
				cout << "\n		year " << years << " raise amount: " << raise;
			}
		}

	}while(salary >= 0);



	return 0;
}
