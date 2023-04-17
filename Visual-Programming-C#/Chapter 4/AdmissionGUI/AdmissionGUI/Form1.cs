//Alican Ceylan
//01.23.2018
// Chapter 4 – Programming Exercise 1
// Collect GPA and test score from user. Determine and display college admission acceptance or // rejection based on these entries.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double gpa = 0.0;
            int testScore = 0;

            //convert and store user input
            gpa = Convert.ToDouble(gpaTextBox.Text);
            testScore = Convert.ToInt32(scoreTextBox.Text);

            //if statement used to determine if student application is accepted
            if (gpa >= 3.0 && testScore >= 60)
            {
                applicationDisplayLabel.Text = "Application Accepted";
            }
            else if (gpa < 3.0 && testScore >= 80)
            {
                applicationDisplayLabel.Text = "Application Accepted";
            }
            else
            {
                applicationDisplayLabel.Text = "Application Rejected";
            }

            //select all text boxes and set focus
            gpaTextBox.SelectAll();
            scoreTextBox.SelectAll();
            gpaTextBox.Focus();
        }

        private void gpaTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            applicationDisplayLabel.Text = string.Empty;
        }

        private void scoreTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            applicationDisplayLabel.Text = string.Empty;
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
                gpaTextBox.Clear();
                scoreTextBox.Clear();
                gpaTextBox.Focus();
            }
        }
    }
}
