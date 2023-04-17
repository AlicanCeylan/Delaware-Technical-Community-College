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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            const string FILE_NAME = "Inventory.txt";

            //object instantiation
            InventoryItems myInventoryItems = new InventoryItems();
            FileStream outFile = new FileStream(FILE_NAME, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            //store user input in variables
            myInventoryItems.ItemNum = itemNumTextBox.Text;
            myInventoryItems.Description = itemDscTextBox.Text;
            myInventoryItems.Price = itemPriceTextBox.Text;

            //write to file
            writer.WriteLine(myInventoryItems.ToString());

            //clear textboxes and set focus
            itemDscTextBox.Text = string.Empty;
            itemNumTextBox.Text = string.Empty;
            itemPriceTextBox.Text = string.Empty;
            itemNumTextBox.Focus();

            //close the StreamWriter and FileStream
            writer.Close();
            outFile.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            //displays form 2 to select an item
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();

            //set focus
            itemNumTextBox.Focus();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            //displays form 2 to select an item
            Form3 myForm3 = new Form3();
            myForm3.ShowDialog();

            //set focus
            itemNumTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // display exit message box and determine if YES or NO is clicked
            if (MessageBox.Show("Select OK to Confirm Exit", "Exit Request", MessageBoxButtons.OK) == DialogResult.OK)
            {
                // OK clicked - terminate app
                Close();
            }
        }
    }
}
