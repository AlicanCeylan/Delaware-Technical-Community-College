//Alican Ceylan
//04.12.2018
// Chapter 13 – Programming Exercise 1
// Select a movie and view starting and running times

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSelectorGUI
{
    public partial class Form1 : Form
    {
        //declare string array for run times
        string[] runTime = { "2 Hr. 22 Min.", "1 Hr. 50 Min.", "1 Hr. 30 Min.", "1 Hr. 40 Min.", "1 Hr. 45 Min." };

        public Form1()
        {
            InitializeComponent();
        }

        private void movieListBox_MouseHover(object sender, EventArgs e)
        {
            //display and enable labels
            movieLabel.Enabled = true;
            timeLabel.Enabled = true;
            timesDisplayLabel.Enabled = true;
            instructionLabel.Enabled = true;
            movieLabel.Visible = true;
            timeLabel.Visible = true;
            timesDisplayLabel.Visible = true;
            instructionLabel.Visible = true;
        }

        private void movieListBox_MouseLeave(object sender, EventArgs e)
        {
            //make labels invisible to user
            movieLabel.Visible = false;
            timeLabel.Visible = false;
            timesDisplayLabel.Visible = false;
            instructionLabel.Visible = false;

            //deselect movie and clear display label
            movieListBox.SelectedIndex = -1;
            displayLabel.Text = string.Empty;
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loop used to display run time of the selected movie
            for (int i = 0; i < movieListBox.Items.Count; ++i)
            {
                if (movieListBox.GetSelected(i) == true)
                    displayLabel.Text = "Running time for selected movie is " + runTime[i];
            }

            //hide instructions
            instructionLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //display exit message and box
            if (MessageBox.Show("Select OK to Confirm Exit", "Exit Request", MessageBoxButtons.OK) == DialogResult.OK)
                Close();
        }
    }
}
