//Alican Ceylan
//01.23.2018
// Chapter 4 – Programming Exercise 3
// Determine high and low numbers based on user entries 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighLowGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determineButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            double int1 = 0;
            double int2 = 0;
            double int3 = 0;

            //collect input and store them
            int1 = Convert.ToDouble(int1TextBox.Text);
            int2 = Convert.ToDouble(int2TextBox.Text);
            int3 = Convert.ToDouble(int3TextBox.Text);

            //if statement used to determine high and low number
            if (int1 > int2 && int1 > int3)
            {
                highDisplayLabel.Text = int1.ToString();

                //determine low number
                if (int2 < int3)
                {
                    lowDisplayLabel.Text = int2.ToString();
                }
                else
                {
                    lowDisplayLabel.Text = int3.ToString();
                }
            }
            else if (int2 > int1 && int2 > int3)
            {
                highDisplayLabel.Text = int2.ToString();

                //determine low number
                if (int1 < int3)
                {
                    lowDisplayLabel.Text = int1.ToString();
                }
                else
                {
                    lowDisplayLabel.Text = int3.ToString();
                }
            }
            else
            {
                highDisplayLabel.Text = int3.ToString();
                //determine low number
                if (int1 < int2)
                {
                    lowDisplayLabel.Text = int1.ToString();
                }
                else
                {
                    lowDisplayLabel.Text = int2.ToString();
                }
            }

            //select all text boxes and set focus
            int1TextBox.SelectAll();
            int2TextBox.SelectAll();
            int3TextBox.SelectAll();
            int1TextBox.Focus();
        }

        private void int1TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the diplay labels
            lowDisplayLabel.Text = string.Empty;
            highDisplayLabel.Text = string.Empty;
        }

        private void int2TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the diplay labels
            lowDisplayLabel.Text = string.Empty;
            highDisplayLabel.Text = string.Empty;
        }

        private void int3TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear the diplay labels
            lowDisplayLabel.Text = string.Empty;
            highDisplayLabel.Text = string.Empty;
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
                int1TextBox.Clear();
                int2TextBox.Clear();
                int3TextBox.Clear();
                int1TextBox.Focus();
            }
        }
    }
}
