//Alican Ceylan
//01.30.2018
// Chapter 5 – Programming Exercise 3
// Sum the numbers from 1 to a number entered by the user

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfNumbersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int sum = 0;
            int i = 0;
            int userInt = 0;

            //collect and store user input
            userInt = Convert.ToInt32(intTextBox.Text);

            //loop used to calculates and displays the sum of the numbers from 1 to user entry
            while(i <= userInt)
            {
                sum += i;
                i++;
                displayLabel.Text = "The sum of the numbers 1 to " + userInt + " is " + sum;
            }

            //set focus and select all text boxes
            intTextBox.Focus();
            intTextBox.SelectAll();
        }

        private void intTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // display exit message box and determine if YES or NO is clicked
            if (MessageBox.Show("Select YES to Confirm Exit\nSelect NO to Resume", "Exit Request", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // YES clicked - terminate app
                Close();
            }
            else
            {
                // NO clicked - clear interface and set focus
                intTextBox.Clear();
                intTextBox.Focus();
            }
        }
    }
}
