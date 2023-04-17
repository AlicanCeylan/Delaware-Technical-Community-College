//Alican Ceylan
//03.15.2018
// Chapter 10 – Programming Exercise 1
// View invoice information for service companies

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGUI
{
    class Invoice
    {
        //variable declarations
        protected int days;
 
        public string CompanyName { get; set; }

        public double AmountDue { get; set; }

        public override string ToString()
        {

            if ( CompanyName == "ENERGY ELECTRIC CO-OP" || CompanyName == "TEARDROP WATER SUPPLY" || CompanyName == "RIVAL MORTGAGE ASSOCIATES" || CompanyName == "PRO-TEC INSURANCE GROUP")
            {
                if (days > 0)
                {
                    return "FROM: " + CompanyName +
                        "\n      Amount Due: " + AmountDue.ToString("C") +
                        "\n      Days Overdue: " + days;
                }
                else
                {
                    return "FROM: " + CompanyName +
                        "\n      Amount Due: " + AmountDue.ToString("C");
                }
            }
            else
            {
                return "\n        INVALID ENTRY\n" +
                         "      Please Try Again!";
            }
        }
    }  
}
