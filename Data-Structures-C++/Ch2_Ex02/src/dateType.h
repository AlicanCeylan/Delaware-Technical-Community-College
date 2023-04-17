//***************************************************************
// Author: D.S. Malik
// Modified by: Alican Ceylan
// Modified date: 02.06.2018
// Modifications: Added a isLeapYear function to check for leap
// 				  year.
// Class description: This class defines the member functions 
// that implement the basic properties for working with dates.
//***************************************************************

#ifndef date_H
#define date_H

class dateType
{
    
// ---------- CLASS DEFINITION ----------

    public:
        void setDate(int month, int day, int year);
        // Function to set the date.
        // The member variables dMonth, dDay, and dYear are set 
        // according to the parameters.
        // Postcondition: dMonth = month; dDay = day; dYear = year

        int getDay() const;
        // Function to return the day.
        // Postcondition: The value of dDay is returned.

        int getMonth() const;
        // Function to return the month.  
        // Postcondition: The value of dMonth is returned.

        int getYear() const;
        // Function to return the year.     
        // Postcondition: The value of dYear is returned.

        void printDate() const;
        // Function to output the date in the form mm-dd-yyyy.

        int isLeapYear(int year);
        //function to check whether the year is a valid leap year
        //Postcondition: return 1 for true and 0 for false

        dateType(int month = 1, int day = 1, int year = 1900);
        // Constructor to set the date
        // The member variables dMonth, dDay, and dYear are set 
        // according to the parameters.
        // Postcondition: dMonth = month; dDay = day; dYear = year. 	 
        //    If no values are specified, the default values are 		 
        //    used to initialize the member variables.

    private:
        int dMonth;        // Variable to store the month
        int dDay;          // Variable to store the day
        int dYear;         // Variable to store the year
};

#endif
