// Alican Ceylan
// 01.16.2018
// Chapter 3 – Programming Exercise 1
// Miles to Feet Conversion GUI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToFeetGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // constant and variable declarations
            const int FEET_IN_MILES = 5280;
            double miles = 0.0;
            double feet = 0.0;

            // convert user input and assign to varaible
            miles = Convert.ToDouble(milestextBox.Text);

            // convert distance in feet
            feet = miles * FEET_IN_MILES;

            // display results to user
            displayLabel.Text = miles + " miles is " + feet + " feet.";

            // set focus to the miles text box
            milestextBox.Focus();

            // select all text in the miles text box
            milestextBox.SelectAll();


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
                milestextBox.Clear();
                displayLabel.Text = string.Empty;
                milestextBox.Focus();

            }
        }

        private void milestextBox_TextChanged(object sender, EventArgs e)
        {
            displayLabel.Text = string.Empty;
        }
    }
}
