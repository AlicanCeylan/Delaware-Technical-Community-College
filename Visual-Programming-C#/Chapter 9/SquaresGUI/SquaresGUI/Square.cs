//Alican Ceylan
//03.13.2018
// Chapter 9 – Programming Exercise 2
// Instantiate an array of square objects to display the area of each square

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresGUI
{
    class Square
    {
        private int side;
        private int area;

        public Square(int length)
        {
            side = length;

            CalcArea();

        }

        //method that gets and sets the area variable
        public int GetArea
        {
            get
            {
                return area;
            }
            set
            {
               area = value;
            }
        }

        //method that gets and sets the area variable
        public int GetSide
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }

        }

        //method used to calculate area
        private void CalcArea()
        {
            area = side * side;
        }
    }
}
