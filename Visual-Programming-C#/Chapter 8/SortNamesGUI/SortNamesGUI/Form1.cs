//Alican Ceylan
//03.01.2018
// Chapter 8 – Programming Exercise 2
// Collect and sort first names

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SortNamesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            int numNames = 0;
            int index = 0;
            string names = "";

            //collect number of names
            int.TryParse(numTextBox.Text, out numNames);

            //declare array
            String[] namesArray = new String[numNames];

            if(numNames == 2 || numNames == 5 || numNames == 10)
            {
                do
                {
                    //present input box to user and assign entry to variable
                    names = InputNames();
                    //store name in the array
                    namesArray[index] = names;
                    //increment index
                    index++;
                } while (index < numNames);
                SortAndDisplayNames(namesArray);
                DisplayCount(numNames);
            }

            //set focus and select all textboxes
            numTextBox.Focus();
            numTextBox.SelectAll();
        }

        public String InputNames()
        {
            //variable declaration
            string names = "";
     
            //display input box and store inputs in a variable
            names = Microsoft.VisualBasic.Interaction.InputBox("Enter a Name", "Name Data Entry", "");

            return names;
        }

        public void SortAndDisplayNames(params string[] namesArray)
        {
            //sort array
            Array.Sort(namesArray);

            //loop used to display array
            for (int i = 0; i < namesArray.Length; i++)
            {
                displayLabel.Text += namesArray[i] + "\n";
            }
        }

        public void DisplayCount(int numNames)
        {
            //display number of names
            displayLabel.Text += "\n\nNumber of Names ---> " + numNames;
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
