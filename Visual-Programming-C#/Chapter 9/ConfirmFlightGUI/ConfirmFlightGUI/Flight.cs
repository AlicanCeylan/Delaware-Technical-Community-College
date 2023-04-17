//Alican Ceylan
//03.13.2018
// Chapter 9 – Programming Exercise 1
// Instantiate an object to display flight information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmFlightGUI
{
    class Flight
    {
        //variable declaration
        private string airline;
        private int flightNum;
        private int row;
        private char seat;

        //method used to get and set the airline variable
        public string GetAirline
        {
            get
            {
                return airline;
            }
            set
            {
                airline = value;
            }
        }

        //method used to get and set the flight number variable
        public int GetFlightNum
        {
                get
            {
                    return flightNum;
                }
                set
            {
                    flightNum = value;
                }
        }

        //method used to get and set the row variable
        public int GetRow
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        //method used to get and set the seat variable
        public char GetSeat
        {
            get
            {
                return seat;
            }
            set
            {
                seat = value;
            }
        }

        //default constructor
        public Flight()
        {

        }  
    }
}
