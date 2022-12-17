using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Debugging exercise 
 =======================================================================
 Your Name : Logan Fish
 Email:fishl@purdue.edu
 Program Description: This is the solution for inlab-4 with some Build errors injected.
        
           There are about 10 bugs.
           Write a comment after fixing each bug after the line // ....
           Once done, zip the working project and submit to the link.
 ==========================================================================
 */

namespace HwangJay_InLab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Counter 
        //private int mCount = 0;
        //price for plain pizza (starting price)
        //private const double cPrice = 6.00;

        private int mCount = 0;        //Count the orders
        // Named Constants
        private const double cPrice = 6.00;     //price for plain pizza (starting price)
        private const double cTopPepperoni = 2.0;
        private const double cTopMeat = 4.50;
        private const double cTopSausage = 2.50;
        private const double cTopMushroom = 1.0;
        private const double cTopVeggie = 3.50;

       
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCount.Clear();
            txtOrderDisplay.Clear();
            txtOutput.Clear();
            cboTopping.SelectedIndex = -1;
            txtCount.Focus();
        }


        private void BtnCompute_Click(object sender, EventArgs e)
        {
            int numofpizza;
            string toppings;
            double totalPrice;

            totalPrice = 0;
            numofpizza = int.Parse(txtCount.Text); // Try parse should be int.parse
            toppings = cboTopping.Text;

            mCount++;      // one more order is processed

            txtOrderDisplay.Text = mCount.ToString();


            if (cboTopping.Text == "Meat Lovers")  //Meat Lovers // added another "=" into the statement as it needs two
            {
                totalPrice = numofpizza * (cPrice + 4.50);
            }

            else if (cboTopping.Text == "Pepperoni")   //Pepperoni         // removed the ; because the statement shouldnt have it
            {
                totalPrice = numofpizza * (cPrice + 2.00);

            }
            else if (cboTopping.Text == "Mushroom")   //Mushroom  //added if into the statement 
            {
                totalPrice = numofpizza * (cPrice + 1.00);
            }
            else if (cboTopping.Text == "Sausage") // added if into the statement
            {
                totalPrice = numofpizza * (cPrice + cTopSausage);
            }
            else if (cboTopping.Text == "Veggie")    //Veggie // added if into the statement
            {
                totalPrice = numofpizza * (cPrice + 3.50);

            }
            else    //Plain
            {
                totalPrice = cPrice * numofpizza;
            }

            txtOutput.Text = "Order Summary : " + "\r\n" + numofpizza.ToString() + " Pizza (s)"
                    + "\r\nType of Pizza : " + toppings + "\r\nDue Amount: " + totalPrice.ToString("c");

            if (mCount == 10) // added another = to make the statement work, also removed the ; at the end as it shouldnt have it. 
            {
                txtOutput.Text = txtOutput.Text + "\r\n\r\nCongraturations!!!!";
            }

        }
        
    }
}
