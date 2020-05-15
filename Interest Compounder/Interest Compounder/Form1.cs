using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Compounder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthlySavingsValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nextMonth_Click(object sender, EventArgs e)
        {

            int currentMonth = Int32.Parse(monthsValue.Text) + 1;

            bool validEntry = Double.TryParse(monthlySavingsValue.Text, out double initialPrincipal);
            if (validEntry)
            {
                invalidInput.SetError(monthlySavingsValue, "");
                validEntry = Double.TryParse(annualInterestValue.Text, out double apr);

                if (validEntry)
                {
                    invalidInput.SetError(annualInterestValue, "");
                    apr = apr / (12.0 * 100.0);

                    double currentSavings = double.Parse(balanceValue.Text.Replace("$", ""));



                    currentSavings += (currentSavings * apr) + initialPrincipal;
                    monthsValue.Text = "" + currentMonth;
                    balanceValue.Text = "$" + currentSavings.ToString("#.00");
                }

                else
                {
                    annualInterestValue.Focus();
                    invalidInput.SetError(annualInterestValue, "That was an invalid apr.");
                }
                
            }

            else
            {
                monthlySavingsValue.Focus();
                invalidInput.SetError(monthlySavingsValue, "That was an invalid dollar amount.");
            }
            
            


        }

        private void calculateNewBalance ()
        {
            
        }

        private void balanceValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthlySavings_Click(object sender, EventArgs e)
        {

        }

        private void annualInterest_Click(object sender, EventArgs e)
        {

        }

        private void annualInterestValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberOfMonths_Click(object sender, EventArgs e)
        {

        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void balanceValue_Click(object sender, EventArgs e)
        {

        }
    }
}
