//============================================================================
// Name        : Ch1_Ex04.cpp
// Author      : Alican Ceylan
// Date        : 01.23.2018
// Description : Collect user name, determine if it matches base name, and
// 				 display name and whether or not user name matched base name
//============================================================================

#include <iostream>
#include <algorithm>
#include "personType.h"
using namespace std;

int main()
{
	//declare variables
	string name = "";
	string firstName = "";
	string midName = "";
	string lastName = "";

	//welcome message
	cout << "WELCOME TO THE NAME PARSER AND TESTER\n";

	//instantiate a person type object
	personType myPersonType;

	//loop used to collect variables
	while (firstName != "XXX" && midName != "XXX" && lastName != "XXX")
	{
		//collect first name from
		cout << "\nEnter a first name (type XXX to quit): ";
		cin >> firstName;

		//capitalize exit code
		if (firstName == "xxx")
		{
			transform(firstName.begin(), firstName.end(), firstName.begin(), ::toupper);
		}

		if (firstName != "XXX")
		{
			cout << "Enter a middle name (type XXX to quit): ";
			cin >> midName;

			//capitalize exit code
			if (midName == "xxx")
			{
				transform(midName.begin(), midName.end(), midName.begin(), ::toupper);
			}

			if (midName != "XXX")
			{
				cout << "Enter a last name (type XXX to quit): ";
				cin >> lastName;

				//capitalize exit code
				if (lastName == "xxx")
				{
					transform(lastName.begin(), lastName.end(), lastName.begin(), ::toupper);
				}

				//display results to console if exit code is not entered
				if (lastName != "XXX")
				{
					myPersonType.setName(firstName, midName, lastName);

					//display name entered by user
					cout << "\nName entered by user ---> ";
					myPersonType.print();
					cout << ".\n";

					//determine if first, middle, and last name are equal to base name and print to console
					myPersonType.isFirstName();
					myPersonType.isMiddleName();
					myPersonType.isLastName();


				}


			}
		}

	}

	//EOP message
	cout << "\nEnd of Program.";

	return 0;
}
