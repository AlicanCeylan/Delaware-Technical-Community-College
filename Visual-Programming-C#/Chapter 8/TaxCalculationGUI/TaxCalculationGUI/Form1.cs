//Alican Ceylan
//03.01.2018
// Chapter 8 – Programming Exercise 1
// Tax amount calculations

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            double price = 0.0;
            int rate = 0;

            //store user input
            price = Convert.ToDouble(priceTextBox.Text);
            rate = Convert.ToInt32(rateTextBox.Text);

            //method calls
            ComputeTax(price, rate);
            ComputeTax(rate, price);
        }

        public void ComputeTax(double price, double rate)
        {
            //variable declaration
            double tax = 0.0;

            //calculate and display tax amount
            tax = rate/100 * price;
            displayLabel.Text += rate * .01 + " tax on " + price.ToString() + " is " + tax.ToString("c") + "\n";

            //set focus and select all textboxes
            priceTextBox.Focus();
            priceTextBox.SelectAll();
            rateTextBox.SelectAll();
        }

        public void ComputeTax(int rate, double price)
        {
            //variable declaration
            double tax = 0.0;

            //calculate and display tax amount
            tax = price * (rate * .01);
            displayLabel.Text += (rate /100.0).ToString("p") + " tax on " + price + " is " + tax.ToString("c");
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
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
                priceTextBox.Clear();
                rateTextBox.Clear();
                priceTextBox.Focus();
            }
        }
    }
}
