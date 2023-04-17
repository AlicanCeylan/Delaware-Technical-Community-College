//Alican Ceylan
//03.15.2018
// Chapter 10 – Programming Exercise 1
// View invoice information for service companies

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGUI
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
            string company = "";
            double amount = 0.0;
            int overdueDays = 0;

            //store company name
            company = fromTextBox.Text;
            
            //obstantiate objects
            Invoice myInvoice = new Invoice();
            OverdueInvoice myOverdueInvoice = new OverdueInvoice();

            //determine invoice amount and days overdue
            if (company == "ENERGY ELECTRIC CO-OP")
            {
                amount = 175.75;
                overdueDays = 0;
            }
            else if (company == "TEARDROP WATER SUPPLY")
            {
                 amount = 125.25;
                overdueDays = 30;
            }
            else if (company == "RIVAL MORTGAGE ASSOCIATES")
            {
                amount = 750.50;
                overdueDays = 0;
            }
            else if (company == "PRO-TEC INSURANCE GROUP")
            {
                amount = 400.00;
                overdueDays = 60;
            }

            //loop used to display results
            if (overdueDays > 0)
            {
                myOverdueInvoice.AmountDue = amount;
                myOverdueInvoice.CompanyName = company;
                myOverdueInvoice.daysOverDue = overdueDays;
                displayLabel.Text += myOverdueInvoice.ToString();
            }
            else
            {
                myInvoice.AmountDue = amount;
                myInvoice.CompanyName = company;
                displayLabel.Text += myInvoice.ToString();
            }

            //select all textboxes and set focus
            fromTextBox.SelectAll();
            fromTextBox.Focus();

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
                fromTextBox.Clear();
                fromTextBox.Focus();
            }
        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display label
            displayLabel.Text = string.Empty;
        }
    }
}
