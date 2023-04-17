//**************************************************************
// Author: D.S. Malik
//
// Class description: This class defines the member functions 
// that implement the basic properties for working with days
// of the week.
//**************************************************************
 
#include <string>

using namespace std;

class dayType
{
    
// ---------- CLASS DEFINITION ----------

    public:
        static string weekDays[7];
        // Function to build array in the form of weekDays[7] containing the days of the week
    	
        void print() const;
        // Function to output weekday in the form of weekDay

        string nextDay() const;
        // Function to determine the next day based on the value in weekDay
        // Postcondition: The next day value is returned
	
        string prevDay() const;
        // Function to determine the previous day based on the value in weekDay
        // Postcondition: The previous day value is returned

        void addDay(int nDays);
        // Function to determine a day in the future according to the parameter
        // Postcondition: The future day value is returned

        void setDay(string d);
        // Function to set the day according to the parameter
        // Postcondition: weekDay = d

        string getDay() const;
        // Function to return the week day
        // Postcondition: The value of weekDay is returned
    	
        dayType();
        // Default constructor
        // Sets weekDay to a null string
        // Postcondition: weekDay = ""    	

        dayType(string d);
        // Constructor with parameters
        // Sets weekDay according to the parameter
        // Postcondition: weekDay = d    

    private:
        string weekDay;	// Variable to store week day
};

