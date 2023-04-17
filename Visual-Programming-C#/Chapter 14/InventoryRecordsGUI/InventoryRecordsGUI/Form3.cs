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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //variable declarations
            const char DELIM = ',';
            const string FILE_NAME = "Inventory.txt";

            //object insantiation
            InventoryItems myInventoryItems = new InventoryItems();
            FileStream infile = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            //variable declaration
            string recordIn = reader.ReadLine();
            string[] fields;

            //while loop used to process text file
            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                myInventoryItems.ItemNum = fields[0];
                myInventoryItems.Description = fields[1];
                myInventoryItems.Price = fields[2];
                displayLabel.Text += myInventoryItems.ItemNum + "     " + myInventoryItems.Price + "    " + myInventoryItems.Description + "\n";
                recordIn = reader.ReadLine();
            }

            //close StreamReader and FileStream
            infile.Close();
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }
    }
}
