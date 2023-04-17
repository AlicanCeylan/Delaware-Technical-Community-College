//Alican Ceylan
//02.08.2018
// Chapter 6 – Programming Exercise 2
// Calculate tip average and determine how far each tip is from the average

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipsListGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare global arrays
  
        double[] tips = new double[7];
        double[] dif = new double[7];

        private void processButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int i = 0;
            double tip = 0;
            double avg = 0.0;
            double total = 0.0;

            //collect input and store in array
            if (double.TryParse(day1TextBox.Text, out tip))
                tips[0] = tip;
            if (double.TryParse(day2TextBox.Text, out tip))
                tips[1] = tip;
            if (double.TryParse(day3TextBox.Text, out tip))
                tips[2] = tip;
            if (double.TryParse(day4TextBox.Text, out tip))
                tips[3] = tip;
            if (double.TryParse(day5TextBox.Text, out tip))
                tips[4] = tip;
            if (double.TryParse(day6TextBox.Text, out tip))
                tips[5] = tip;
            if (double.TryParse(day7TextBox.Text, out tip))
                tips[6] = tip;

            //calculate total tips and the average
            for(i=0; i < tips.Length; i++)
            {
                total += tips[i];
            }
            avg = total / 7;

            //calculate the difference from the average
            for (i = 0; i < tips.Length; i++)
            {
                dif[i] = tips[i] - avg;
            }

            //display difference from average, total, and average
            if(dif[0] < 0)
                dif1DisplayLabel.ForeColor = Color.Red;
            dif1DisplayLabel.Text = dif[0].ToString("n");
            if (dif[1] < 0)
                dif2DisplayLabel.ForeColor = Color.Red;
            dif2DisplayLabel.Text = dif[1].ToString("n");
            if (dif[2] < 0)
                dif3DisplayLabel.ForeColor = Color.Red;
            dif3DisplayLabel.Text = dif[2].ToString("n");
            if (dif[3] < 0)
                dif4DisplayLabel.ForeColor = Color.Red;
            dif4DisplayLabel.Text = dif[3].ToString("n");
            if (dif[4] < 0)
                dif5DisplayLabel.ForeColor = Color.Red;
            dif5DisplayLabel.Text = dif[4].ToString("n");
            if (dif[5] < 0)
                dif6DisplayLabel.ForeColor = Color.Red;
            dif6DisplayLabel.Text = dif[5].ToString("n");
            if (dif[6] < 0)
                dif7DisplayLabel.ForeColor = Color.Red;
            dif7DisplayLabel.Text = dif[6].ToString("n");

            totalDisplayLabel.Text = total.ToString("c");
            avgDisplayLabel.Text = avg.ToString("c");

            //select all textboxes
            day1TextBox.SelectAll();
            day2TextBox.SelectAll();
            day3TextBox.SelectAll();
            day4TextBox.SelectAll();
            day5TextBox.SelectAll();
            day6TextBox.SelectAll();
            day7TextBox.SelectAll();

            //set focus to first textbox
            day1TextBox.Focus();

        }

        private void day1TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
        }

        private void day2TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
        }

        private void day3TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
        }

        private void day4TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
        }

        private void day5TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
        }

        private void day6TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
        }

        private void day7TextBox_TextChanged(object sender, EventArgs e)
        {
            //clear display labels
            dif1DisplayLabel.Text = "";
            dif2DisplayLabel.Text = "";
            dif3DisplayLabel.Text = "";
            dif4DisplayLabel.Text = "";
            dif5DisplayLabel.Text = "";
            dif6DisplayLabel.Text = "";
            dif7DisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
            avgDisplayLabel.Text = "";
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
                day1TextBox.Clear();
                day2TextBox.Clear();
                day3TextBox.Clear();
                day4TextBox.Clear();
                day5TextBox.Clear();
                day6TextBox.Clear();
                day7TextBox.Clear();
                day1TextBox.Focus();
            }
        }
    }
}
