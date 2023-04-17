//Alican Ceylan
//01.30.2018
// Chapter 5 – Programming Exercise 1
// Display odd numbers from 1 to 99

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddNumbersGUI
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
            int i = 0;
            const int LIMIT = 99;

            //clear display label
            displayLabel.Text = string.Empty;

            //loop used to display ood numbers 1 to 99
            for (i = 1; i <= LIMIT; i += 2)
            {
                displayLabel.Text += i + " ";

            }

            //set focus
            displayButton.Focus();

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
                displayLabel.Text = string.Empty;
                displayButton.Focus();
            }
        }
    }
}
