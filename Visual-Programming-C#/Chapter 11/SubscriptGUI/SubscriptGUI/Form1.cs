// Alican Ceylan
// 03.20.2018
// Chapter 11 – Programming Exercise 1
// Validate array subscripts. Catch an exception when an array subscript is out of the bounds
// of the array

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriptGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //array initialization
            int[] array = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 111 };

            //variable declaration
            int subscript = 0;

            //try block to catch index out of range except
            try
            {
                //collect and store subscript value
                subscript = Convert.ToInt32(subTextBox.Text);
                displayLabel.Text = array[subscript].ToString();
            }
            catch(IndexOutOfRangeException error)
            {
                MessageBox.Show(error.Message, "Invalid Entry", MessageBoxButtons.OK);
                subTextBox.Focus();
                subTextBox.SelectAll();
            }

            //select all text boxes and set focus
            subTextBox.Focus();
            subTextBox.SelectAll();
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
                subTextBox.Clear();
                subTextBox.Focus();
            }
        }

        private void subTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }
    }
}
