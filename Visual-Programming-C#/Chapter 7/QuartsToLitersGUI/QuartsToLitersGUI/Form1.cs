//Alican Ceylan
//02.13.2018
// Chapter 7 – Programming Exercise 3
// Collect number of quarts from the user. Calculate and display the conversion from quarts to // liters.  

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartsToLitersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //declare variables and store user input
            double quarts = Convert.ToDouble(quartsTextBox.Text);
            const double CON_RATE = 0.94635295;
            double liters = 0.0;

            //convert to liters using calcLiters method
            liters = CalcLiters(quarts, CON_RATE);

            //display results to display label
            displayLabel.Text = quarts.ToString() + " quarts is " + liters.ToString("0.000") + " liters.";

            //select all textboxes and set focus
            quartsTextBox.SelectAll();
            quartsTextBox.Focus();
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
                quartsTextBox.Clear();
                quartsTextBox.Focus();
            }
        }

        private void quartsTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private double CalcLiters(double quarts, double rate)
        {
            //variable declaration
            double liters = 0.0;

            //convert quarts to liters
            liters = quarts * rate;

            return liters;
        }
    }
}
