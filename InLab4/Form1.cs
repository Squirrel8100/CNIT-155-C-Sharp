using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * ‘=========================================================
‘ Logan Fish
Lab session Friday 1:30
‘ Email:fishl@purdue.edu
‘  CNIT 155 InLab-04
‘  Program Description:  The Program counts the number of orders, calculates the price of the order, and displays the details of the order. 
 ‘===========================================================

 * 
 * 
 * 
 */
namespace InLab04_Fish
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }
        //Counter for number of Orders
        private int mCounter = 0;

        //Named constants
        private const double cPrice = 6.00;        //starting price of plain pizza
                                                 //Price for Toppings additional
        private const double cPepporoni = 2.00;
        private const double cMeatLovares = 4.50;
        private const double cSausage = 2.50;
        private const double cMushroom = 1.00;
        private const double cVeggie = 3.50;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            mCounter++; // adds onto the counter when the compute button is pressed 
            txtOrderOutput.Text = mCounter.ToString();
            string topping;
            topping = cboToppings.Text;
            int OrderCount;
            OrderCount = int.Parse(txtOrderCount.Text);

            //allows the computed cost to be later set to a money value
            Double mCost;
            mCost = (cPrice + cMeatLovares) * OrderCount;
            Double pCost;
            pCost = (cPrice + cPepporoni) * OrderCount;
            Double vCost;
            vCost = (cPrice + cVeggie) * OrderCount;
            Double sCost;
            sCost = (cPrice + cSausage) * OrderCount;
            Double muCost;
            muCost = (cPrice + cMushroom) * OrderCount;
            Double plCost;
            plCost= (cPrice * OrderCount);
            if (topping == "Plain")
            {
                //Calculate Price

                txtOutput.Text = "Order Summary:\r\n" + OrderCount
                    + "Pizza (s)" + "\r\n" + "type of pizza:" + "Plain" +
                   "\r\n" + " Due Amount:" + plCost.ToString("C");
            }
            else if (topping == "Veggie") //  Outputs the specfic information for each type of pizza when selected and computed. 
            {
                txtOutput.Text = "Order Summary:\r\n" + OrderCount + ""
                    + "Pizza (s) " + "\r\n" + "type of pizza:" + "Veggie" + "\r\n" + " Due Amount:" + vCost.ToString("C");
            }
            if (topping == "Meat Lovers")
            {
                txtOutput.Text = "Order Summary:\r\n" + OrderCount
                    + "Pizza (s)" + "\r\n" + "type of pizza:" + "Meat Lovers" + "\r\n" + " Due Amount:" + mCost.ToString("C");

            }
            else if (topping =="Pepperoni")
            {
                txtOutput.Text = "Order Summary:\r\n" + OrderCount
                    + "Pizza (s)" + "\r\n" + "type of pizza:" + "Pepperoni" + "\r\n" + " Due Amount:" + pCost.ToString("C");

            }
            if (topping == "Sausage")
            {
                txtOutput.Text = "Order Summary:\r\n" + OrderCount
                    + "Pizza (s)" + "\r\n" + "type of pizza:" + "Sausage" +
                   "\r\n" + " Due Amount:" + sCost.ToString("C");
            }
            else if (topping == "Mushroom")
            {
                txtOutput.Text = "Order Summary:\r\n" + OrderCount
                    + "Pizza (s)" + "\r\n" + "type of pizza:" + "Mushroom" + "\r\n" + " Due Amount: " +muCost.ToString("C");
            }
            if (mCounter >9)
            {
                txtOutput.Text = txtOutput.Text + "\r\n" +
                    "Congratulations"; // displays the congradulations when orders reach 10
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            txtOrderCount.Text = "";
            txtOrderOutput.Text = "";
            cboToppings.SelectedIndex = -1;
            txtOrderCount.Focus(); // Clears the text and resets the cursor
        }

        private void cboToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {
            

            


        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void lblToppings_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
