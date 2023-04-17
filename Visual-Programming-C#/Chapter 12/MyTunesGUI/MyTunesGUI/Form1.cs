//Alican Ceylan
//03.27.2017
// Chapter 12 – Programming Exercise 1
// Select and purchase songs from a list box

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTunesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void musicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variable declaration
            int numSongs = 0;
            const double PRICES = .99;
            double cost = 0.0;

            //collect and store number of songs selected
            numSongs = musicListBox.SelectedItems.Count;

            cost = numSongs * PRICES;

            //if statement used to display results or clear display label
            if (numSongs == 1)
                displayLabel.Text = numSongs + " song selected - Download cost is " + cost.ToString("c");
            else if (numSongs == 0)
                displayLabel.Text = string.Empty;
            else
                displayLabel.Text = numSongs + " songs selected - Download cost is " + cost.ToString("c");
        }

        private void exitButtom_Click(object sender, EventArgs e)
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
                musicListBox.ClearSelected();

            }
        }
    }
}
