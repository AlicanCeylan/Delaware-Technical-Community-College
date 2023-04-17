// Alican Ceylan
// 04.12.2016
// Chapter 13 – Programming Exercise 2
// Guess a random number game using radio buttons

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumberGUI
{
    public partial class Form1 : Form
    {
        //instantiate a random object and variable to store it
        Random myRandom = new Random();
        int randomNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //generate a random number and store it
            randomNumber = myRandom.Next(1, 6);

            //hide the exit button
            exitButton.Visible = false;
        }

        private void hintLabel_MouseHover(object sender, EventArgs e)
        {
            //switch statement to display hint and disable wrong button
            switch (randomNumber)
            {
                case 1:
                    hintDisplayLabel.Text = "It's not Radio button 3";
                    radioButton3.Enabled = false;
                    break;
                case 2:
                    hintDisplayLabel.Text = "It's not Radio button 4";
                    radioButton4.Enabled = false;
                    break;
                case 3:
                    hintDisplayLabel.Text = "It's not Radio button 5";
                    radioButton5.Enabled = false;
                    break;
                case 4:
                    hintDisplayLabel.Text = "It's not Radio button 1";
                    radioButton1.Enabled = false;
                    break;
                case 5:
                    hintDisplayLabel.Text = "It's not Radio button 2";
                    radioButton2.Enabled = false;
                    break;

            }
        }

        private void hintLabel_MouseLeave(object sender, EventArgs e)
        {
            //clear hint display label
            hintDisplayLabel.Text = string.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if statement used to check if the button matches the random number
            if (randomNumber == 1)
            {
                resultDisplayLabel.Text = "Congratulations - You Guessed Correctly!";
                exitButton.Visible = true;
            }
            else
            {
                resultDisplayLabel.Text = "Sorry - you guessed incorrectly.";
                radioButton1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if statement used to check if the button matches the random number
            if (randomNumber == 2)
            {
                resultDisplayLabel.Text = "Congratulations - You Guessed Correctly!";
                exitButton.Visible = true;
            }
            else
            {
                resultDisplayLabel.Text = "Sorry - you guessed incorrectly.";
                radioButton2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //if statement used to check if the button matches the random number
            if (randomNumber == 3)
            {
                resultDisplayLabel.Text = "Congratulations - You Guessed Correctly!";
                exitButton.Visible = true;
            }
            else
            {
                resultDisplayLabel.Text = "Sorry - you guessed incorrectly.";
                radioButton3.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //if statement used to check if the button matches the random number
            if (randomNumber == 4)
            {
                resultDisplayLabel.Text = "Congratulations - You Guessed Correctly!";
                exitButton.Visible = true;
            }
            else
            {
                resultDisplayLabel.Text = "Sorry - you guessed incorrectly.";
                radioButton4.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //if statement used to check if the button matches the random number
            if (randomNumber == 5)
            {
                resultDisplayLabel.Text = "Congratulations - You Guessed Correctly!";
                exitButton.Visible = true;
            }
            else
            {
                resultDisplayLabel.Text = "Sorry - you guessed incorrectly.";
                radioButton5.Enabled = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //display exit message and box
            if (MessageBox.Show("Select OK to Confirm Exit", "Exit Request", MessageBoxButtons.OK) == DialogResult.OK)
                Close();
        }
    }
}
