//Alican Ceylan
//02.8.2017
// Chapter 6 – Programming Exercise 3
// Determine if zip code is in delivery area and display associated delivery charge


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryChargesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global array declaration
        double[] charges = new double[10]
            { 2.4, 3.00, 3.5, 4, 4.5, 5.00 , 5.25, 5.75, 6.10 , 10.00 };

        int[] zip = new int[10]
            { 19947, 19963 , 19950 , 19933 , 19973 , 19968, 19971, 19953, 19974, 19955 };

        private void checkButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            int zipcode = Convert.ToInt32(zipTextBox.Text);
            bool verify = false;
            int count = 0;


            //loop used to find correct charge for zipcode
            for(int i = 0; i < zip.Length; i++)
            {
                if(zipcode == zip[i])
                {
                    verify = true;
                    count = i;
                }
            }

            if(verify == true)
            {
                displayLabel.Text = "OK to deliver to" + zip[count] +
                                    "\n Cost of Delivery is " + charges[count].ToString("c");
            }
            else
            {
                displayLabel.Text = "Sorry - no Delivery to " + zipcode;
            }
            //set focus to textbox and select all text in textbox
            zipTextBox.SelectAll();
            zipTextBox.Focus();
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = "";
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
                zipTextBox.Clear();
                zipTextBox.Focus();
                
            }
        }
    }
}
