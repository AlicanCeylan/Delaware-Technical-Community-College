//***************************************************************
// Author: D.S. Malik
// 
// Class description: This class specifies the member functions 
// that implement the basic properties for working with a
// despensing machine.
//***************************************************************
 
#include <iostream>
#include "dispenserType.h"

using namespace std;

// ---------- CLASS IMPLEMENTATION ----------

int dispenserType::getNoOfItems() const
{
    return numberOfItems;
}

int dispenserType::getCost() const
{
    return cost;
}

void dispenserType::makeSale()
{
    numberOfItems--;
}

// Default constructor
dispenserType::dispenserType()
{
    numberOfItems = 50;
    cost = 50;
}

// Constructor with parameters
dispenserType::dispenserType(int setNoOfItems, int setCost)
{
    if (setNoOfItems >= 0)
         numberOfItems = setNoOfItems;
    else    
        numberOfItems = 50;

    if (setCost >= 0)
        cost = setCost;
    else
        cost = 50;
}
