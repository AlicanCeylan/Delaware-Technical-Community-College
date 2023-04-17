// Alican Ceylan
// 04.24.2018
// Chapter 14 – Programming Exercise 1 
// Enter and save inventory records to a text file. View saved inventory records from that text   
// file.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace InventoryRecordsGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //variable declarations
            const char DELIM = ',';
            const string FILE_NAME = "Inventory.txt";
                        
            //object insantiation
            InventoryItems myInventoryItems = new InventoryItems();
            FileStream infile = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            //variable declaration
            string userNum;
            string recordIn;
            string[] fields;
            bool validate = false;

            //store item num of item user is searching for and read a line from the file
            userNum = numTextBox.Text;
            recordIn = reader.ReadLine();

            //while loop used to process text file
            while(recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                myInventoryItems.ItemNum = fields[0];
                myInventoryItems.Description = fields[1];
                myInventoryItems.Price = fields[2];
                
                //if statement used to display item
                if (myInventoryItems.ItemNum == userNum)
                {
                    numTextBox.Clear();
                    numTextBox.Focus();
                    displayLabel.Text = myInventoryItems.ItemNum + "               " + myInventoryItems.Price + "                    " + myInventoryItems.Description;
                    validate = true;
                }
                recordIn = reader.ReadLine();
            }

            //if statement used to determine if item was found
            if(validate == false)
            {
                displayLabel.Text = "No record found for item number " + userNum;
                
                //set focus and select all in text box
                numTextBox.SelectAll();
                numTextBox.Focus();
            }
            //close StreamReader and FileStream
            infile.Close();
            reader.Close();        
        }

        private void numTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
