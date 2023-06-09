//***********************************************************************************
// Author: D.S. Malik
// Modified by:
// Modified date:
// Modicications:
//
// Class description: This class defines and specifies the member functions 
// that implement the basic properties for working with array-based lists.
//***********************************************************************************

#ifndef H_arrayListType
#define H_arrayListType

#include <iostream>
#include <cassert>

using namespace std;

template <class elemType>
class arrayListType
{

// ---------- CLASS DEFINITION ----------

    public:
        const arrayListType<elemType>& operator= (const arrayListType<elemType> &);
        // Overloads the assignment operator
        bool isEmpty();
        // Function to determine whether the list is empty
        // Postcondition: Returns true if the list is empty; 
        //                otherwise, returns false.
        bool isFull();
        // Function to determine whether the list is full.
        // Postcondition: Returns true if the list is full; 
        //                otherwise, returns false.
        int listSize();
        // Function to determine the number of elements in the list
        // Postcondition: Returns the value of length.
        int maxListSize();
        // Function to determine the size of the list.
        // Postcondition: Returns the value of maxSize.
        void print() const;
        // Function to output the elements of the list
        // Postcondition: Elements of the list are output on the 
        //                standard output device.
        bool isItemAtEqual(int location, const elemType &item);
        // Function to determine whether the item is the same 
        // as the item in the list at the position specified by
        // Postcondition: Returns true if the list[location] 
        //                is the same as the item; otherwise, 
        //                returns false.
        void insertAt(int location, const elemType &insertItem);
        // Function to insert an item in the list at the 
        // position specified by location. The item to be inserted 
        // is passed as a parameter to the function.
        // Postcondition: Starting at location, the elements of the
        //                list are shifted down, list[location] = insertItem;,
        //                and length++;. If the list is full or location is
        //                out of range, an appropriate message is displayed.
        void insertEnd(const elemType &insertItem);
        // Function to insert an item at the end of the list. 
        // The parameter insertItem specifies the item to be inserted.
        //Postcondition: list[length] = insertItem; and length++;
        //               If the list is full, an appropriate message is 
        //               displayed.
        void removeAt(int location);
        // Function to remove the item from the list at the 
        // position specified by location 
        // Postcondition: The list element at list[location] is 
        //                removed and length is decremented by 1. If location is 
        //                out of range,an appropriate message is displayed.
        void retrieveAt(int location, elemType &retItem);
        // Function to retrieve the element from the list at the  
        // position specified by location. 
        // Postcondition: retItem = list[location] 
        //                If location is out of range, an appropriate message 
        //                is displayed.
        void replaceAt(int location, const elemType &repItem);
        // Function to replace the elements in the list at the 
        // position specified by location. The item to be replaced 
        // is specified by the parameter repItem.
        // Postcondition: list[location] = repItem 
        //                If location is out of range, an appropriate message 
        //                is displayed.
        void clearList();
        // Function to remove all the elements from the list. 
        // After this operation, the size of the list is zero.
        // Postcondition: length = 0;
        int seqSearch(const elemType& item);
        // Function to search the list for a given item. 
        // Postcondition: If the item is found, returns the 
        //                location in the array where the item is found; otherwise, 
        //                returns -1.
        void insert(const elemType &insertItem);
        // Function to insert the item specified by the parameter 
        // insertItem at the end of the list. However, first the
        // list is searched to see whether the item to be inserted 
        // is already in the list. 
        // Postcondition: list[length] = insertItem and length++
        //                If the item is already in the list or the list
        //                is full, an appropriate message is displayed.
        void remove(const elemType &removeItem);
        // Function to remove an item from the list. The parameter 
        // removeItem specifies the item to be removed.
        // Postcondition: If removeItem is found in the list,
        //                it is removed from the list and length is 
        //                decremented by one.
        arrayListType(int size = 100);
        // Constructor
        // Creates an array of the size specified by the 
        // parameter size. The default array size is 100.
        // Postcondition: The list points to the array, length = 0, 
        //                and maxSize = size
        arrayListType(const arrayListType<elemType> &otherList); 
        // Copy constructor
        ~arrayListType();
        // Destructor
        // Deallocates the memory occupied by the array.
        void insertionSort();
        //Function to sort a list using the insertion sort method
        //Postcondition: The list is sorted using the insertion sort
        void shellSort();
        //Function to sort a list using the shell sort method
        //Postcondition: The list is sorted using the shell sort
        void intervalInsertionSort(int begin, int inc);






  

     protected:
        elemType *list;        // Array to hold the list elements
        int length;            // Variable to store the length of the list
        int maxSize;           // Variable to store the maximum size of the list
};

// ---------- CLASS IMPLEMENTATION ----------
template <class elemType>
void arrayListType<elemType>::insertionSort()
{
	//variable declaration
	int firstOutOfOrder, location;
	elemType temp;

	//loop used to sort list
	for (firstOutOfOrder = 1; firstOutOfOrder < length;	firstOutOfOrder++)
		//if statement used to check if next element is smaller than the last
		if (list[firstOutOfOrder] < list[firstOutOfOrder - 1])
		{
			temp = list[firstOutOfOrder];
			location = firstOutOfOrder;

			//do-while loop use to move the numbers
			do
			{
			list[location] = list[location - 1];
			location--;
			}
			while (location > 0 && list[location - 1] > temp);

			list[location] = temp;
		}
}//end insertionSort

template <class elemType>
void arrayListType<elemType>::shellSort()
{
	int inc;

	for (inc = 1; inc < (length - 1) / 9; inc = 3 * inc + 1);

	do
	{
		for (int begin = 0; begin < inc; begin++)
			intervalInsertionSort(begin, inc);

		inc = inc / 3;
	}
	while (inc > 0);
}//end shellSort

template <class elemType>
void arrayListType<elemType>::intervalInsertionSort(int begin, int inc)
{
	elemType temp;


	for(int begin = inc; begin < length; begin++)
	  {
	    for(int i = begin; i >= inc && list[i] < list[i-inc]; i -= inc)
	    {
	      temp = list[i];
	      list[i] = list[i - inc];
	      list[i - inc] = temp;
	    }
	  }
}

template <class elemType>
bool arrayListType<elemType>::isEmpty()
{
    return (length == 0);
} // end isEmpty

template <class elemType>
bool arrayListType<elemType>::isFull()
{
    return (length == maxSize);
} // end isFull

template <class elemType>
int arrayListType<elemType>::listSize()
{
    return length;
} // end listSize

template <class elemType>
int arrayListType<elemType>::maxListSize()
{
    return maxSize;
} // end maxListSize

template <class elemType>
void arrayListType<elemType>::print() const
{
    for (int i = 0; i < length; i++)
        cout << list[i] << " ";

    cout << endl;
} // end print

template <class elemType>
bool arrayListType<elemType>::isItemAtEqual
                            (int location, const elemType &item)
{
    return(list[location] == item);
} // end isItemAtEqual

template <class elemType>
void arrayListType<elemType>::insertAt
                  (int location, const elemType &insertItem)
{
    if (location < 0 || location >= maxSize)
        cerr << "The position of the item to be inserted "
             << "is out of range" << endl;
    else
        if (length >= maxSize)            //list is full
            cerr << "Cannot insert in a full list" << endl;
        else
        {
            for (int i = length; i > location; i--)
                 list[i] = list[i - 1];   //move the elements down

            list[location] = insertItem;  //insert the item at the 
                                          //specified position

            length++;     //increment the length
    }
} //end insertAt

template <class elemType>
void arrayListType<elemType>::insertEnd(const elemType &insertItem)
{

    if (length >= maxSize)  //the list is full
        cerr << "Cannot insert in a full list" << endl;
    else
    {
         list[length] = insertItem;   //insert the item at the end
         length++;                    //increment the length
    }
} //end insertEnd

template <class elemType>
void arrayListType<elemType>::removeAt(int location)
{
    if (location < 0 || location >= length)
        cerr << "The location of the item to be removed "
             << "is out of range" << endl;
    else
    {
        for (int i = location; i < length - 1; i++)
            list[i] = list[i+1];

        length--;
    }
} //end removeAt

template <class elemType>
void arrayListType<elemType>::retrieveAt
                             (int location, elemType &retItem)
{
    if (location < 0 || location >= length)
        cerr << "The location of the item to be retrieved is "
             << "out of range." << endl;
    else
        retItem = list[location];
} //end retrieveAt


template <class elemType>
void arrayListType<elemType>::replaceAt
                          (int location, const elemType &repItem)
{
    if (location < 0 || location >= length)
        cerr << "The location of the item to be replaced is "
             << "out of range." << endl;
    else
        list[location] = repItem;

} //end replaceAt

template <class elemType>
void arrayListType<elemType>::clearList()
{
    length = 0;
} //end clearList

template <class elemType>
int arrayListType<elemType>::seqSearch(const elemType &item)
{
    int loc;
    bool found = false;

    for (loc = 0; loc < length; loc++)
        if (list[loc] == item)
        {
            found = true;
            break;
        }

    if (found)
        return loc;
    else
        return -1;
} //end seqSearch

template <class elemType>
void arrayListType<elemType>::insert(const elemType &insertItem)
{
    int loc;

    if (length == 0)   //list is empty
        list[length++] = insertItem;    //insert the item and 
                                        //increment the length
    else if (length == maxSize)
        cerr << "Cannot insert in a full list." << endl;
    else
    {
        loc = seqSearch(insertItem);

        if (loc == -1)                  //the item to be inserted 
                                        //does not exist in the list
            list[length++] = insertItem;
        else
            cerr << "the item to be inserted is already in "
                 << "the list. No duplicates are allowed." << endl;
    }
} //end insert

template<class elemType>
void arrayListType<elemType>::remove(const elemType &removeItem)
{
    int loc;

    if (length == 0)
        cerr << "Cannot delete from an empty list." << endl;
    else
    {
        loc = seqSearch(removeItem);

        if (loc != -1)
            removeAt(loc);
        else
            cout << "The item to be deleted is not in the list."
                 << endl;
    }
} //end remove

template <class elemType>
arrayListType<elemType>::arrayListType(int size)
{
    if (size < 0)
    {
        cerr << "The array size must be positive. Creating "
             << "an array of size 100. " << endl;

        maxSize = 100;
    }
    else
        maxSize = size;

    length = 0;

    list = new elemType[maxSize];
    assert(list != NULL);
} // end constructor with parameters

template <class elemType>
arrayListType<elemType>::~arrayListType()
{
    delete [] list;
} // end destructor

template <class elemType>
arrayListType<elemType>::arrayListType
                   (const arrayListType<elemType> &otherList)
{
    maxSize = otherList.maxSize;
    length = otherList.length;
    list = new elemType[maxSize]; //create the array
    assert(list != NULL);         //terminate if unable to allocate
                                  //memory space

    for (int j = 0; j < length; j++)  //copy otherList
        list [j] = otherList.list[j];
} //end copy constructor

template <class elemType>
const arrayListType<elemType>& arrayListType<elemType>::operator=
                      (const arrayListType<elemType> &otherList)
{
    if (this != &otherList)      //avoid self-assignment
    {
        delete [] list; 
        maxSize = otherList.maxSize; 
        length = otherList.length; 
 
        list = new elemType[maxSize];  //create the array
        assert(list != NULL);    //if unable to allocate memory 
                                 //space, terminate the program 
        for (int i = 0; i < length; i++)
            list[i] = otherList.list[i]; 
    }

    return *this; 
} // end operator overload

#endif
