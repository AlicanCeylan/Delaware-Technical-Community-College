//Alican Ceylan
//03.13.2018
// Chapter 9 – Programming Exercise 1
// Instantiate an object to display flight information

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfirmFlightGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //declare variables
            string airline = "";
            int flightNum = 0;
            int row = 0;
            char seat = ' ';

            //collect and store variables from user
            airline = airlineTextBox.Text;
            flightNum = Convert.ToInt32(flightTextBox.Text);
            row = Convert.ToInt32(rowTexBox.Text);
            seat = Convert.ToChar(seatTextBox.Text);

            //instantiate object
            Flight myFlight = new Flight();

            //set airline, flight number, row, and seat
            myFlight.GetAirline = airline;
            myFlight.GetFlightNum = flightNum;
            myFlight.GetRow = row;
            myFlight.GetSeat = seat;

            //display flight confirmation
            displayLabel.Text += "You are booked on flight # " + Convert.ToString(myFlight.GetFlightNum) + " on " + myFlight.GetAirline + " Airlines";
            displayLabel.Text += "\n\nYour seating assignment is Row " + Convert.ToString(myFlight.GetRow) + " Seat " + Convert.ToString(myFlight.GetSeat);
            displayLabel.Text += "\n\n** FLIGHT CONFIRMED **";

            //select all textboxes and set focus
            airlineTextBox.SelectAll();
            flightTextBox.SelectAll();
            rowTexBox.SelectAll();
            seatTextBox.SelectAll();
            airlineTextBox.Focus();
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
                flightTextBox.Clear();
                rowTexBox.Clear();
                airlineTextBox.Clear();
                seatTextBox.Clear();
                airlineTextBox.Focus();
            }
        }

        private void airlineTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void flightTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void rowTexBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }

        private void seatTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }
    }
}
