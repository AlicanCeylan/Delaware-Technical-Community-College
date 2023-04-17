//Alican Ceylan
//01.30.2018
// Chapter 5 – Programming Exercise 4
// Increase a base price by percentages 10 through 20.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncreaseGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            double i = 0;
            const int LIMIT = 20;
            double price = 0.0;
            double increase = 0.0;

            //convert and store user input
            price = Convert.ToDouble(priceTextBox.Text);

            for (i = 10; i <= LIMIT; ++i)
            {
                increase = price * (i/100) + price;
                displayLabel.Text += i + " % increase ---> " + increase.ToString("c") + "\n";
            }

            //select all text boxes and set focus
            priceTextBox.SelectAll();
            priceTextBox.Focus();
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
                priceTextBox.Focus();
            }
        }
    }
}
