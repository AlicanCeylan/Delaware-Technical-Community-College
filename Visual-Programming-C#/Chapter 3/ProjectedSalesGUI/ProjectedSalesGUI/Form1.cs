//Alican Ceylan
//01.18.2018
// Chapter 3 – Programming Exercise 2
// Project Sales Increase GUI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedSalesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                northTextBox.Clear();
                southTextBox.Clear();
                northDisplayLabel.Text = string.Empty;
                southDisplayLabel.Text = string.Empty;
                northTextBox.Focus();
            }

        }

        private void projectSalesButton_Click(object sender, EventArgs e)
        {
            //constant and variable declaration
            const double SALES_INCREASE = 0.12;
            double northSales = 0.0;
            double southSales = 0.0;
            double northProSales = 0.0;
            double southProSales = 0.0;

            // convert user input and assign to variable
            northSales = Convert.ToDouble(northTextBox.Text);
            southSales = Convert.ToDouble(southTextBox.Text);

            //calculate project sales for north and south divisions
            northProSales = northSales + (northSales * SALES_INCREASE);
            southProSales = southSales + (southSales * SALES_INCREASE);

            //display results to user
            northDisplayLabel.Text = northProSales.ToString("C");
            southDisplayLabel.Text = southProSales.ToString("C");

            //set focus to north text box
            northTextBox.Focus();

            //select all in north text box
            northTextBox.SelectAll();

            //select all in south text box
            southTextBox.SelectAll();



        }

        private void northTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            northDisplayLabel.Text = string.Empty;
            southDisplayLabel.Text = string.Empty;
        }

        private void southTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            northDisplayLabel.Text = string.Empty;
            southDisplayLabel.Text = string.Empty;
        }
    }
}
