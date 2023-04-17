//Alican Ceylan
//01.18.2018
// Chapter 3 – Programming Exercise 3
// Average of Test Scores GUI



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //declare constants and variables
            double average = 0.0;
            const int NUM_TESTS = 5;
            double test1 = 0;
            double test2 = 0;
            double test3 = 0;
            double test4 = 0;
            double test5 = 0;

            //convert user input and assign to a variable
            test1 = Convert.ToInt32(test1TextBox.Text);
            test2 = Convert.ToInt32(test2TextBox.Text);
            test3 = Convert.ToInt32(test3TextBox.Text);
            test4 = Convert.ToInt32(test4TextBox.Text);
            test5 = Convert.ToInt32(test5TextBox.Text);

            //calculate average test score
            average = (test1 + test2 + test3 + test4 + test5) / NUM_TESTS;

            //display average to user
            avgDisplayLabel.Text = average.ToString("0, 0.00");

            //select all in the textbox
            test1TextBox.SelectAll();
            test2TextBox.SelectAll();
            test3TextBox.SelectAll();
            test4TextBox.SelectAll();
            test5TextBox.SelectAll();

            //set focus to first text box
            test1TextBox.Focus();

        }

        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the contents of the averageLabel
            avgDisplayLabel.Text = string.Empty;
        }

        private void test2TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the contents of the averageLabel
            avgDisplayLabel.Text = string.Empty;
        }

        private void test3TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the contents of the averageLabel
            avgDisplayLabel.Text = string.Empty;
        }

        private void test4TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the contents of the averageLabel
            avgDisplayLabel.Text = string.Empty;
        }

        private void test5TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the contents of the averageLabel
            avgDisplayLabel.Text = string.Empty;
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
                test1TextBox.Clear();
                test2TextBox.Clear();
                test3TextBox.Clear();
                test4TextBox.Clear();
                test5TextBox.Clear();
                test1TextBox.Focus();
            }
        }
    }
}
