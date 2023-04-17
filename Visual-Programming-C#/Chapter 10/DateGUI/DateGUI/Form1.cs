//Alican Ceylan
//03.15.2018
// Chapter 10 – Programming Exercise 2
// Enter, manipulate, and display a date using multiple classes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            int month = 0;
            int day = 0;
            int year = 0;
            string date = "";
            string dateUpdate = "";

            //object insantiation
            DatesUpdate myDatesUpdate = new DatesUpdate();

            //store user input
            month = Convert.ToInt32(monthTextBox.Text);
            day = Convert.ToInt32(dayTextBox.Text);
            year = Convert.ToInt32(yearTextBox.Text);

            //check for valid date
            if (month > 12)
            {
                MessageBox.Show("Invalid month entered (1 - 12 only)", "Data Entry Error", MessageBoxButtons.OK);
                monthTextBox.Focus();
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 11 || month == 12)
            {
                if (day > 31 || day < 1)
                {
                    MessageBox.Show("Invalid day entered (1 - 31 only)", "Data Entry Error", MessageBoxButtons.OK);
                    dayTextBox.Focus();
                }
                else
                {
                    if (year < 1900)
                    {
                        MessageBox.Show("Invalid year entered (1900 or later)", "Data Entry Error", MessageBoxButtons.OK);
                        yearTextBox.Focus();
                    }
                    else
                    {
                        //send date to Date class and get today and tomorrow's date
                        myDatesUpdate.SetDate(month, day, year);
                        date = myDatesUpdate.BuildDate();
                        dateUpdate = myDatesUpdate.UpdateDates();

                        //display results
                        todayDisplayLabel.Text = "Today is ---> " + date;
                        tmrDisplayLabel.Text = "Tomorrow is ---> " + dateUpdate;
                    }
                }
            }
            else if (month == 2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    if (day > 29 || day < 1)
                    {
                        MessageBox.Show("Invalid day entered (1 - 29 only)", "Data Entry Error", MessageBoxButtons.OK);
                        dayTextBox.Focus();
                    }
                    else
                    {
                        if (year < 1900)
                        {
                            MessageBox.Show("Invalid day entered (1900 or later)", "Data Entry Error", MessageBoxButtons.OK);
                            yearTextBox.Focus();

                        }
                        else
                        {
                            //send date to Date class and get today and tomorrow's date
                            myDatesUpdate.SetDate(month, day, year);
                            date = myDatesUpdate.BuildDate();
                            dateUpdate = myDatesUpdate.UpdateDates();

                            //display results
                            todayDisplayLabel.Text = "Today is ---> " + date;
                            tmrDisplayLabel.Text = "Tomorrow is ---> " + dateUpdate;
                        }
                    }
                }
                else
                {
                    if (day > 28 || day < 1)
                    {
                        MessageBox.Show("Invalid day entered (1 - 28 only)", "Data Entry Error", MessageBoxButtons.OK);
                        dayTextBox.Focus();
                    }
                    else
                    {
                        if (year < 1900)
                        {
                            MessageBox.Show("Invalid day entered (1900 or later)", "Data Entry Error", MessageBoxButtons.OK);
                            yearTextBox.Focus();
                        }
                        else
                        {
                            //send date to Date class and get today and tomorrow's date
                            myDatesUpdate.SetDate(month, day, year);
                            date = myDatesUpdate.BuildDate();
                            dateUpdate = myDatesUpdate.UpdateDates();

                            //display results
                            todayDisplayLabel.Text = "Today is ---> " + date;
                            tmrDisplayLabel.Text = "Tomorrow is ---> " + dateUpdate;
                        }
                    }
                }

            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30 || day < 1)
                {
                    MessageBox.Show("Invalid day entered (1 - 30 only)", "Data Entry Error", MessageBoxButtons.OK);
                    dayTextBox.Focus();
                }
                else
                {
                    if (year < 1900)
                    {
                        MessageBox.Show("Invalid day entered (1900 or later)", "Data Entry Error", MessageBoxButtons.OK);
                        yearTextBox.Focus();
                    }
                    else
                    {
                        //send date to Date class and get today and tomorrow's date
                        myDatesUpdate.SetDate(month, day, year);
                        date = myDatesUpdate.BuildDate();
                        dateUpdate = myDatesUpdate.UpdateDates();

                        //display results
                        todayDisplayLabel.Text = "Today is ---> " + date;
                        tmrDisplayLabel.Text = "Tomorrow is ---> " + dateUpdate;
                    }
                }
            }

            //select all textboxes and set focus
            monthTextBox.SelectAll();
            dayTextBox.SelectAll();
            yearTextBox.SelectAll();
            monthTextBox.Focus();

        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            todayDisplayLabel.Text = string.Empty;
            tmrDisplayLabel.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            todayDisplayLabel.Text = string.Empty;
            tmrDisplayLabel.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            todayDisplayLabel.Text = string.Empty;
            tmrDisplayLabel.Text = string.Empty;
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
                monthTextBox.Clear();
                dayTextBox.Clear();
                yearTextBox.Clear();
                monthTextBox.Focus();
            }
        }
    }
}
