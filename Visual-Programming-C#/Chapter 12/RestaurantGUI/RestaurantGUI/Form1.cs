//Alican Ceylan
//03.27.2018
// Chapter 12 – Programming Exercise 2
// Select menu items from various list boxes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            const double STEAK_PRICE = 6.99;
            const double SHRIMP_PRICE = 9.99;
            const double MUSH_PRICE = 7.99;
            const double LASAGNA_PRICE = 22.00;
            const double LINGUINI_PRICE = 20.00;
            const double SPAGHETTI_PRICE = 19.00;
            const double CANNOLI_PRICE = 6.50;
            const double TRUFFLE_PRICE = 8.50;
            const double MISU_PRICE = 7.50;
            int app = 0;
            int entree = 0;
            int desserts = 0;
            double total = 0.0;

            //collect and store item index
            app = appListBox.SelectedIndex;
            entree = entreeListBox.SelectedIndex;
            desserts = dessertListBox.SelectedIndex;

            //switch statement used to add appetizer price to total
            switch (app)
            {
                case 0:
                    total += STEAK_PRICE;
                    break;
                case 1:
                    total += SHRIMP_PRICE;
                    break;
                case 2:
                    total += MUSH_PRICE;
                    break;
            }

            //switch statement used to add entree price to total
            switch (entree)
            {
                case 0:
                    total += LASAGNA_PRICE;
                    break;
                case 1:
                    total += LINGUINI_PRICE;
                    break;
                case 2:
                    total += SPAGHETTI_PRICE;
                    break;
            }

            //switch statement used to add desserts price to total
            switch (desserts)
            {
                case 0:
                    total += CANNOLI_PRICE;
                    break;
                case 1:
                    total += TRUFFLE_PRICE;
                    break;
                case 2:
                    total += MISU_PRICE;
                    break;
            }

            //display total to user
            displayLabel.Text = "Total cost for selected items is " + total.ToString("c");

            //set focus
            resetButton.Focus();
            

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //clear listboxes and display label
            appListBox.ClearSelected();
            entreeListBox.ClearSelected();
            dessertListBox.ClearSelected();
            displayLabel.Text = string.Empty;
            viewButton.Focus();
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
                appListBox.ClearSelected();
                entreeListBox.ClearSelected();
                dessertListBox.ClearSelected();
                displayLabel.Text = string.Empty;
                appListBox.Focus();
            }
        }
    }
}
