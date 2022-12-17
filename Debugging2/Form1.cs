using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modularity_InLab
{
    /*********************************************************
     * CNIT15501
     * Student's Name : Logan Fish
     * Lab Session Fri 1
     * 
     * Debugging Exercise-2
     * This is your inlab06 with some bugs introduced.
     *      * 
     * Objectives:  Run the program and fix all the build error and runtime errors.
     *              Add comment after each statement you modify.
     * *********************************************************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

        
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            //NOTE : Initializing variables to zero as valid data will be assigned in the validation function (ValidateInput())below:
            double amount;
            int number;
            double share;

           
          


            //Call the helper method to Validate input:
            if(ValidateInput()==false)
            {
                return;                 // if it is false, return so that it can be repeated until the users input is valid. 
            }

            // Parse input into variables               // parsed data should be after the validation check, 
            amount = double.Parse(txtAmount.Text);
            number = int.Parse(txtHeirs.Text);



            share = ComputeShare(amount, number);      // added share = to make allow for the output string to work. 

            txtOutput.Text = "Share of each heir: " + share.ToString("C");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //=============================== Helper Methods ================================

        /****************************************************
             * Helper Method: ValidateInput
             * Input parameters:  None
             * Output data type:   bool
             * Task: Validate user's input. For any invalid input
             *       inform the user, set focus, return false
             *       Return true, if everything is valid.
          ****************************************************/
        private bool ValidateInput()
        {
            double amount;
            int heirs;
            // Validate user's input:
            // Existence Check:
            // Existence Check for name:
            if (txtName.Text == "")
            {
                DisplayMessageOK("Name is required.");
                txtName.Focus();
                return false;
            }
           
            // Type Check for inheritance amount:
            if (double.TryParse(txtAmount.Text, out amount) == false)//Checks if type is right and also parses the input into amount variable
            {
                DisplayMessageOK("The amount for inheritance must be a real number.");
                txtAmount.Focus();
                return false;
            }
            
            // Type Check for number of heirs:
            if (int.TryParse(txtHeirs.Text, out heirs) == false)//Checks if type is right and also parses the input into heirs variable
            {
                DisplayMessageOK("The number of heirs must be whole number.");
                txtHeirs.Focus();
                return false;
            }
            // Range Check for number of shares (1 to 12):
            if (heirs < 1 || heirs > 12)
            {
                DisplayMessageOK("Valid range is 1 to 12.");
                txtHeirs.Focus();
                return false;
            }
            return true; // is needed for the statement to work, returns true when everything is valid. 
           
            
        }

        /****************************************************
          * Helper Method: DisplayMessageOK
          * Input parameters:  string
          * Output data type:   void
          * Task: Display the input string using MessageBox.Show
       ****************************************************/
        private void DisplayMessageOK(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /****************************************************
          * Helper Method: ClearAll
          * Input parameters:  None
          * Output data type:   void
          * Task: Clear all the GUI objects required
       ****************************************************/
        private void ClearAll()
        {
            txtName.Clear();
            txtAmount.Clear();
            txtHeirs.Clear();
            txtOutput.Clear();
            txtName.Focus();
        }
        /****************************************************
           * Helper Method: ComputeShare
           * Input parameters:  double, int
           * Output data type:   double
           * Task: Computes the equal share for each
        ****************************************************/
        private double ComputeShare(double money, int count) // needs a bracket surrounding the data
        {
            double result;
            result = money / count;
            return result;
        }
private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
