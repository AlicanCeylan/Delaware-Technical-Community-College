//Alican Ceylan
//01.23.2018
// Chapter 4 – Programming Exercise 4
// Discount a price based on user entries. Calculates and displays discounted price and savings // amount

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double price = 0.0;
            double rate = 0.0;
            double discPrice = 0.0;
            double savings = 0.0;

            //collect user input and store it
            price = Convert.ToDouble(priceTextBox.Text);
            rate = Convert.ToDouble(discountTextBox.Text);

            //determine if price and discount rate is greater than zero
            if (price < 0)
            {
                MessageBox.Show("Price figure must be greater than zero (0)", "Data Entry Error", MessageBoxButtons.OK);

                //select all textboxes and set focus
                priceTextBox.SelectAll();
                discountTextBox.SelectAll();
                priceTextBox.Focus();
            }
            else if (rate < 0)
            {
                MessageBox.Show("Rate figure must be greater than zero (0)", "Data Entry Error", MessageBoxButtons.OK);

                //select all textboxes and set focus
                priceTextBox.SelectAll();
                discountTextBox.SelectAll();
                discountTextBox.Focus();
            }
            else
            {
                rate = rate / 100;
                savings = price * rate;
                discPrice = price - savings;

                //display results to user
                priceDisplayLabel.Text = discPrice.ToString("c");
                savingsDisplayLabel.Text = savings.ToString("c");

                //select all textboxes and set focus
                priceTextBox.SelectAll();
                discountTextBox.SelectAll();
                priceTextBox.Focus();
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            priceDisplayLabel.Text = string.Empty;
            savingsDisplayLabel.Text = string.Empty;
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            priceDisplayLabel.Text = string.Empty;
            savingsDisplayLabel.Text = string.Empty;
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
                discountTextBox.Clear();
                priceTextBox.Focus();
            }
        }
    }
}
