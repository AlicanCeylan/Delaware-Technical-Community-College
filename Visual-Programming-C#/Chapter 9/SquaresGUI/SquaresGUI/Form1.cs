//Alican Ceylan
//03.13.2018
// Chapter 9 – Programming Exercise 2
// Instantiate an array of square objects to display the area of each square

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquaresGUI
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
            Square[] squareArray = new Square[9];

            //fill array with length of sides 1 - 9
            for (int i = 0; i < squareArray.Length; i++)
            {
                squareArray[i] = new Square(i+1);
            }

            //calculate and display results to display label
            for (int i = 0; i < squareArray.Length; i++)
            {

                displayLabel.Text += "The area of a " + squareArray[i].GetSide 
                    + " by " + squareArray[i].GetSide + " square is "
                    + squareArray[i].GetArea + "\n";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
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
                displayLabel.Text = string.Empty;
                displayButton.Focus();
            }
        }
    }
}
