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
    class OverdueInvoice : Invoice
    {
        public int daysOverDue
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
    }
}
