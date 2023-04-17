//Alican Ceylan
//02.13.2018
// Chapter 7 – Programming Exercise 1
// Calculate cost of vinyl siding

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidingEstimateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //declare variables and store user input in them
            double totalCost = 0.0;
            double length = Convert.ToDouble(lengthTextBox.Text);
            double depth = Convert.ToDouble(depthTextBox.Text);
            double cost = Convert.ToDouble(costTextBox.Text);

            //calculate the total cost of siding and display results
            totalCost = CalcCost(length, depth, cost);
            displayLabel.Text = "Cost of Siding is " + totalCost.ToString("c");

            //select all textboxes and set focus
            lengthTextBox.SelectAll();
            depthTextBox.SelectAll();
            costTextBox.SelectAll();
            lengthTextBox.Focus();
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
                lengthTextBox.Clear();
                depthTextBox.Clear();
                costTextBox.Clear();
                lengthTextBox.Focus();
            }
        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void depthTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private double CalcCost(double length, double depth, double cost )
        {
            //variable declaration
            double total = 0.0;

            //calculate total cost of siding
            total = (length * depth) * cost;

            return total;
        }
    }
}
