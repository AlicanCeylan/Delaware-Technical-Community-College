//Alican Ceylan
//02.13.2018
// Chapter 7 – Programming Exercise 2
// Generate a multiplication table

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //declare variables and store user input
            int integer = Convert.ToInt32(intTextBox.Text);

            //call MultTable to get multiplication table displayed
            MultTable(integer);

            //select all textboxes and set focus
            intTextBox.SelectAll();
            intTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void intTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        public void MultTable(int integer)
        {
            //declare variables
            int total = 0;

            //loop used to multiply by integers 2 to 9 and display
            for (int i = 2; i < 10; i++)
            {
                total = integer * i;
                displayLabel.Text += integer + " * " + i + " = " + total + "\n";

            }
        }
    }
}
