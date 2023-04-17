//***************************************************************
// Author: D.S. Malik
//
// Class description: This class specifies the member functions 
// that implement the basic properties for working with a
// cash register.
//***************************************************************
  
#include <iostream>
#include "cashRegister.h"

using namespace std;

// ---------- CLASS IMPLEMENTATION ----------

int cashRegister::getCurrentBalance() const
{
    return cashOnHand;
}

void cashRegister::acceptAmount(int amountIn)
{
    cashOnHand = cashOnHand + amountIn;
}

// Default constructor
cashRegister::cashRegister()
{
    cashOnHand = 500;
}

// Constructor with parameters
cashRegister::cashRegister(int cashIn)
{
    if (cashIn >= 0)
        cashOnHand = cashIn;
    else
        cashOnHand = 500;
}
