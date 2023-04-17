//Alican Ceylan
//01.23.2018
// Chapter 4 – Programming Exercise 2
// Determine Hurricane Category – Based on Wind Speeds

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurricaneGUI
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
            int speed = 0;

            //collect user input and convert it
            speed = Convert.ToInt32(speedTextBox.Text);

            //if statement used to determine category
            if(speed >= 157)
            {
                displayLabel.Text = "Category 5 Hurricane";
            }
            else if(speed >= 130)
            {
                displayLabel.Text = "Category 4 Hurricane";
            }
            else if(speed >= 111)
            {
                displayLabel.Text = "Category 3 Hurricane";
            }
            else if(speed >= 96)
            {
                displayLabel.Text = "Category 2 Hurricane";
            }
            else if(speed >= 74)
            {
                displayLabel.Text = "Category 1 Hurricane";
            }
            else
            {
                displayLabel.Text = "Not a Hurricane";
            }

            //select all text boxes and set focus
            speedTextBox.SelectAll();
            speedTextBox.Focus();
        }

        private void speedTextBox_TextChanged(object sender, EventArgs e)
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
                speedTextBox.Clear();
                speedTextBox.Focus();
            }
        }
    }
}
