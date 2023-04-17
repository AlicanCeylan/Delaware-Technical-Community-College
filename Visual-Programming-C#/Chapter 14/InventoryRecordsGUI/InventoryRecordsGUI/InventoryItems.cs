// Alican Ceylan
// 04.24.2018
// Chapter 14 – Programming Exercise 1 
// Enter and save inventory records to a text file. View saved inventory records from that text   
// file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryRecordsGUI
{
    class InventoryItems
    {
        //variable declaration
        public string ItemNum { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public new string ToString()
        {
            return ItemNum + ", " + Description + ", " + Price;
        }
    }

}
