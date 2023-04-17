//*************************************************************************
// Author:        B. Lord
// Modified by:   Alican Ceylan
// Modified date: 03.13.2018
// Modicications: Add the implementation of the functions for the vectors
//                class
// Class description: This class specifies the member functions 
// that implement the basic properties for working with vector lists.
//*************************************************************************
 
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class vectors
{

// ---------- CLASS DEFINITION ----------

    public:
        void fillVector();
        // Function to fill a vector by prompting and collecting values from
        // the user.
        // Postcondition: The vector is populated with the values entered using   
        //                the push_back function. Lastly, a call is issued to 
        //                the processVector function.

        void processVector(vector<double> vecList);
        // Function to process a vector using an iterator.
        // Postcondition: The smallest and largest vector values are determined. 
        //                The sum and average vector values are calculated. The 
        //                size if the list is determined. Lastly, a call is 
        //                issued to the printValues function.                

        void printValues(int, double, double, double, double);
        // Function to display required output items.
        // Postcondition: Vector size, largest number, smallest number, sum of
        //                numbers, and average values are displayed in the console.

        vectors();
        // Default constructor
        // Initializes instance variables
        // Postcondition: double type variables initialized to 0.0
        //                int type variable initialized to 0

    private:
        double smallest;        // variable to store smallest vector value
        double largest;         // variable to store largest vector value
        double vecSum;          // variable to store sum of vector values
        double vecAvg;          // variable to store average of vector values
        int vecSize;            // variable to store vector list size
};

// ---------- CLASS IMPLEMENTATION ----------


void vectors::fillVector()
{
	//variable declaration
	vector<double> vecList;
	double num = 0.0;

	//loop used to fill vector
	do{
		cin >> num;
		if(num > 0)
		vecList.push_back(num);
	}while(num != -999);

	//call to processVector function
	processVector(vecList);

}

void vectors::processVector(vector<double> vecList)
{
	//variable declaration
	int min = 0;
	int max = 0;
	vector<double>::iterator intVecIter;
	vecSize = vecList.size();

	//calculate largest and smallest values
	intVecIter = min_element(vecList.begin(), vecList.end());
	min = distance(vecList.begin(), intVecIter);
	intVecIter = max_element(vecList.begin(), vecList.end());
	max = distance(vecList.begin(), intVecIter);
	smallest = vecList[min];
	largest = vecList[max];

	//calculate sum and average
	for(intVecIter = vecList.begin(); intVecIter != vecList.end(); ++intVecIter)
	{
		vecSum += *intVecIter;
	}
	vecAvg = vecSum / vecSize;

	//call to print values function
	printValues(vecSize, largest, smallest, vecSum, vecAvg);
}

void vectors::printValues(int size, double max, double min, double sum, double avg)
{

	//display results
	cout << setprecision(2) << fixed;
	cout << "\nVector Size ---> " << size;
	cout << "\nLargest -------> " << max;
	cout << "\nSmallest ------> " << min;
	cout << "\nSum -----------> " << sum;
	cout << "\nAverage -------> " << avg;
}

vectors::vectors()
{
	smallest = 0.0;
	largest = 0.0;
	vecSize = 0;
	vecSum = 0.0;
	vecAvg = 0.0;
}

