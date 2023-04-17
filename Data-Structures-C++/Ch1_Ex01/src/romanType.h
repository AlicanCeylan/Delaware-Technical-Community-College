//**************************************************************
// Author: D.S. Malik
//
// Class description: This class defines the member functions 
// that implement the basic properties for working with Roman
// Numerals.
//**************************************************************  
 
#include <string>
using namespace std;

class romanType
{
    
// ---------- CLASS DEFINITION ----------

public:
	void setRoman(string);
	// Function to set the Roman numeral according to the parameter
	// Postcondition: romanNum = rString
	// Calls romanToDecimal function

	void romanToDecimal();
	// Funxtion to convert Roman numeral to a decimal number
	// Postcondition: decimalNum = sum

	void printDecimal() const;
	// Function to output the decimal number to console in the
	// form decimalNum

	void printRoman() const;
	// Function to output the Roman numeral to console in the
	// form romanNum

	romanType();
	// Default constructor
	// Sets Roman number to 'I' and decimal number to 1
	// Postcondition: romanNum = 'I'; decimalNum = 1

	romanType(string);
	// Constructor with parameter
	// Sets roman number according to parameter
	// Postcondition: romanNum = rString
	// Calls romanToDecimal function

private:
	string romanNum;        // Variable to store Roman numeral
	int decimalNum;         // Variable to store decimal number
};
