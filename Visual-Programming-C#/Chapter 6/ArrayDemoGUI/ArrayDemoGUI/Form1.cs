// Alican Ceylan
// 02.06.2018
// Chapter 6 – Programming Exercise 1
// Collect ten integer values from the user storing each in an array. Display the array values in
// the order they were entered, reverse order, and sorted (ascending) order.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDemoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare array
        int[] intArray = new int[10];

        //declare global variables
        int i = 0;

        private void writeButton_Click(object sender, EventArgs e)
        {
            //loop used to store integers in array
            if (i < intArray.Length)
            {
                //collect and store user input
                intArray[i] = Convert.ToInt32(intTextBox.Text);
                intTextBox.Text = "";
                i++;

            }
            else
            {
                MessageBox.Show("Array is Full - Click OK to Close", "Array Capacity Error", MessageBoxButtons.OK);
                entryOrderButton.Focus();
            }
        }

        private void entryOrderButton_Click(object sender, EventArgs e)
        {
            //loop used to display array in original order
            for (i = 0; i < intArray.Length; i++)
            {
                entryDisplayLabel.Text += intArray[i].ToString() + "\n";
            }

            //set focus to reverse order button
            revButton.Focus();
        }

        private void revButton_Click(object sender, EventArgs e)
        {
            //reverses array order
            Array.Reverse(intArray);

            //loop used to display array in reverse order
            for (i = 0; i < intArray.Length; i++)
            {
                revDisplayOrder.Text += intArray[i].ToString() + "\n";
            }

            //set focuse on sorted order button
            sortButton.Focus();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            //reverses array order
            Array.Sort(intArray);

            //loop used to display array in a sorted order
            for (i = 0; i < intArray.Length; i++)
            {
                sortedDisplayLabel.Text += intArray[i].ToString() + "\n";
            }

            //set counter back to zero
            i = 0;
            //set focuse on exit button
            exitButton.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // display exit message box and determine if YES or NO is clicked
            MessageBox.Show("Click OK to Close", "Exit Request", MessageBoxButtons.OK);
        }
    }
}