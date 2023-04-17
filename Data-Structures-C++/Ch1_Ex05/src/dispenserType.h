//************************************************************
// Author: D.S. Malik
// 
// Class description: This class defines the member functions 
// that implement the basic properties for working with a
// despensing machine.
//************************************************************
  
class dispenserType
{
    
// ---------- CLASS DEFINITION ----------

    public:
        int getNoOfItems() const; 
        // Function to show the number of items in the machine.
        // Postcondition: The value of numberOfItems is returned.

        int getCost() const; 
        // Function to show the cost of the item.
        // Postcondition: The value of cost is returned.

        void makeSale();  
        // Function to reduce the number of items by 1.
        // Postcondition: numberOfItems--;

        dispenserType(); 
        // Default constructor 
        // Sets the cost and number of items in the dispenser
        // to 50.
        // Postcondition: numberOfItems = 50; cost = 50;

        dispenserType(int setNoOfItems, int setCost); 
        // Constructor with parameters 
        // Sets the cost and number of items in the dispenser
        // to the values specified by the user.
        // Postcondition: numberOfItems = setNoOfItems;
        //                cost = setCost;


    private:
        int numberOfItems;     // Variable to store number of items in the dispenser
        int cost;              // Variable to store the cost of an item
};
