// Alican Ceylan
// 03.20.2018
// Chapter 11 – Programming Exercise 2
// Find the square root of a number. Catch data entry exceptions that might occur

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareRootGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            int num = 0;
            double sqRoot = 0.0;

            //check if input can be parsed to int and display results or throw exception with correct error statement
            try
            {
                if (Int32.TryParse(numTextBox.Text, out num))
                {
                    if (num > 0)
                    {
                        sqRoot = Math.Sqrt(num);
                        displayLabel.Text = "The square root of " + num + " is " + sqRoot.ToString("f4");
                    }
                    else if (num == 0)
                    {
                        throw new ApplicationException("Zero value not permitted.");
                    }
                    else
                    {
                        throw new ApplicationException("Negative values not permitted.");
                    }
                }
                else
                {
                    displayLabel.Text = "Non-integer values not permitted.";
                }
            }
            catch (ApplicationException error)
            {
                displayLabel.Text = error.Message;
            }


            //select all textboxes and set focus
            numTextBox.SelectAll();
            numTextBox.Focus();

        }

        private void numTextBox_TextChanged(object sender, EventArgs e)
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
                numTextBox.Clear();
                numTextBox.Focus();
            }
        }
    }
}
