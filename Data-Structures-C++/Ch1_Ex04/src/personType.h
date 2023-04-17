//***************************************************************
// Author: D.S. Malik
// Modified by: Alican Ceylan
// Modified date: 01.18.2016
// Modifications: add getMiddleName, isfirstname, ismiddlename, and
// islastname functions and the base name and middlName variables
// Class description: This class defines the member functions 
// that implement the basic properties for working with names.
//***************************************************************

#include <string>

using namespace std;

class personType
{
    
// ---------- CLASS DEFINITION ----------

    public:
        void print() const;
        // Function to output first name and last name to console
        // in the form firstName lastName.
  
        void setName(string first, string middle, string last);
        // Function to set firstName and lastName according to the
        // parameters.
        // Postcondition: firstName = first; lastName = last

        string getFirstName() const;
        // Function to return the first name.
        // Postcondition: The value of firstName is returned.

        string getLastName() const;
        // Function to return the last name.
        // Postcondition: The value of lastName is returned.

        string getMiddleName() const;
        //function to return middle name.
        //Postcondition: the value of middleName is returned.

        void isFirstName();
        //function to check if instantiated personType object is the
        //as base first name
        //Postcondition: returns whether they're the same or not

        void isMiddleName();
		//function to check if instantiated personType object is the
		//as base middle name
		//Postcondition: returns whether they're the same or not

        void isLastName();
		//function to check if instantiated personType object is the
		//as base last name
		//Postcondition: returns whether they're the same or not

        personType();
        // Default constructor
        // Sets firstName and lastName to null strings.
        // Postcondition: firstName = ""; lastName = "";

        personType(string first, string middle, string last);
        // Constructor with parameters.
        // Sets firstName and lastName according to the parameters.
        // Postcondition: firstName = first; lastName = last;  

    private:
        string firstName;        // Variable to store the first name
        string lastName;         // Variable to store the last name
        string middleName;		// Variable to store the middle name
    	const string BASE_FIRST = "Mary"; //constant variable for base first name
    	const string BASE_MID = "Beth"; //constant variable for base middle name
    	const string BASE_LAST = "Regan"; //constant variable for base last name
};
