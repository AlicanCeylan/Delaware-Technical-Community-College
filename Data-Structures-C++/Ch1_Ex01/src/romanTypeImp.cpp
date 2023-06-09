//**************************************************************
// Author: D.S. Malik
//
// Class description: This class specifies the member functions 
// that implement the basic properties for working with Roman
// Numerals.
//**************************************************************
 
#include <iostream>
#include <string>
#include "romanType.h"

using namespace std;

// ---------- CLASS IMPLEMENTATION ----------

void romanType::printDecimal() const
{
    cout << decimalNum;
}

void romanType::printRoman() const
{
    cout << romanNum;
}

void romanType::setRoman(string rString)
{
    romanNum = rString;
    romanToDecimal();
}

void romanType::romanToDecimal()
{
    int sum = 0;
    int length =  romanNum.length();
    int i;
	
	int previous = 1000;

    for (i = 0; i < length; i++)
    {
         switch (romanNum[i])
         {
         case 'M': 
            sum += 1000;
            if (previous < 1000)
                sum -=  2 * previous;
            previous = 1000;
            break;
         case 'D': 
             sum += 500;
            if (previous < 500)
                sum -= 2 * previous;
            previous = 500;
            break;
         case 'C': 
             sum += 100;
            if (previous < 100)
                sum -= 2 * previous;
            previous = 100;
            break;
         case 'L': 
             sum += 50;
            if (previous < 50)
                sum -= 2 * previous;
            previous = 50;
            break;
         case 'X': 
             sum += 10;
            if (previous < 10)
                sum -= 2 * previous;
            previous = 10;
            break;
         case 'V': 
             sum += 5;
            if (previous < 5)
                sum -= 2 * previous;
		    previous = 5;
            break;
         case 'I': 
            sum += 1;
            previous = 1;
        }
    }

    decimalNum = sum;
}

// Default constructor
romanType::romanType()
{
    romanNum = 'I';
    decimalNum = 1;
}

// Constructor with parameters
romanType::romanType(string rString)
{
    romanNum = rString;
    romanToDecimal();
}
