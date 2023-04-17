//***************************************************************
// Program Name: Ch1_Ex05.cpp
// Author: D.S. Malik
// Modified by: Alican Ceylan
// Modified date: 01.23.2018
// Modifications: added while loop to allow more than two coin
// entries
// Description: Chapter 1 Programming Exercise 5
//              Implements operations of a Fruit Juice Machine 
// **************************************************************

#include <iostream>
#include "cashRegister.h"
#include "dispenserType.h"

using namespace std;

// lower-level function prototypes
void showSelection();
void sellProduct(dispenserType& product, cashRegister& pCounter);

int main()
{
    // instantiate objects
    cashRegister counter;
    dispenserType appleJuice(100, 50);		// 100 apple juices each 50 cents
    dispenserType orangeJuice(100, 65);	// 100 orange juices each 65 cents
    dispenserType mangoLassi(75, 45);		// 75 mango lassi juices each 45 cents
    dispenserType fruitPunch(100, 85);		// 100 fruit punch juices each 85 cents

    //variable to hold user selection
    int choice;

    // display menu to user
    showSelection();
    // capture user input and assign to variable
    cin >> choice;

    // loop active as long as user entry is not 9
    while (choice != 9)
    {
        // determine user choice - then call the sellProduct lower-level function
    	// passing the appropriate arguments
    	switch (choice)
        {
        case 1: 
            sellProduct(appleJuice, counter);
            break;

        case 2: 
            sellProduct(orangeJuice, counter);
            break;

        case 3: 
            sellProduct(mangoLassi, counter);
            break;

        case 4: 
            sellProduct(fruitPunch, counter);
            break;

        // invalid menu choice entered by user
        default: 
            cout << "Invalid selection - please try again." << endl;
        }//end switch

    	// display menu to user
    	showSelection();
    	// capture user input and assign to variable
    	cin >> choice;
    }//end while

    cout << endl <<  "End of Program.";

    return 0;
}//end main

// ----- showSelection lower-level function -----
void showSelection()
{
    cout << "************************************************\n";
    cout << "***** WELCOME TO SHELLY'S FRUIT JUICE SHOP *****\n";
    cout << "************************************************\n\n";
    cout << "1. Apple Juice\n";
    cout << "2. Orange Juice\n";
    cout << "3. Mango Lassi\n";
    cout << "4. Fruit Punch\n";
    cout << "9. End Program\n";
    cout << "\nSelect an item number and press enter: ";
}

// ----- sellProduct lower-level function -----
void sellProduct(dispenserType& product, cashRegister& pCounter)
{
    int amount;  //variable to hold the amount entered
    int amount2; //variable to hold the extra amount needed

    // determine if the dispenser is empty
    if (product.getNoOfItems() > 0)
    {

		// dispenser is not empty - deposit amount
		cout << "Please deposit " << product.getCost() << " cents" << endl;
		// capture user input and assign to variable
		cin >> amount;

		// determine if deposit amount is less than item cost
		while (amount < product.getCost())
		{
			if (amount < product.getCost())
			{
				// amount is less than item cost - second deposit required
				cout << "Please deposit another " << product.getCost() - amount << " cents" << endl;
				// capture user input and assign to variable
				cin >> amount2;
				// accumulate amount
				amount = amount + amount2;
		   }

			// determine if enough money has been deposited to make purchase
			if (amount >= product.getCost())
			{
				// enough deposited
				// call acceptAmount function passing amount
				pCounter.acceptAmount(amount);
				// call makeSale function
				product.makeSale();
				//  display message to user
				cout << endl;
				cout << "Collect your item at the bottom and enjoy!" << endl << endl;
			}
		}
    }
    else
        // despence is empty - display message to user
        cout << "Sorry, this item is currently sold out." << endl;
}
