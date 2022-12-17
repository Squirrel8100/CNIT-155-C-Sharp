using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Logan Fish   
 * Email:Fishl@purdue.edu
 * Cnit155 inLab-05
 */
namespace InLab05FishLogan
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }
        private const Double OneRose = 5.0;
        private const Double MultiRoseUnitPrice = 4.0;
        private const Double GiftWrap = 3.0;
        private const Double TaxRate = 0.08;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a Name", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return; // return
            }


            int Stems = 0;

            if (int.TryParse(txtStemsNum.Text, out Stems) == false)
            {
                MessageBox.Show("Number of stems must be a whole number", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStemsNum.Focus();
                return; // return
            }

            if (Stems < 1 || Stems >12)
            {
                MessageBox.Show("Number of roses should be between 1-12", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStemsNum.Focus();
                return; // return
            }




            int Roses;
            Roses = int.Parse(txtStemsNum.Text);

            Double PriceSingle; //price of single rose
            PriceSingle = OneRose;

            Double MoreRoses; //price of more than one rose
            MoreRoses = MultiRoseUnitPrice * Roses;

            Double SingleTax; // price of single rose with tax
            SingleTax = (PriceSingle * TaxRate) + PriceSingle;

            
            Double MultiTax = (MoreRoses * TaxRate) + MoreRoses; //price of more roses taxed

            Double Wrapped;
            Wrapped = PriceSingle + GiftWrap;   //price of single rose with gift wrap

            Double WrappedTaxed;
            WrappedTaxed = (Wrapped * TaxRate) + Wrapped; // price of single rose with gift wrapped taxed

            Double MoreWrapped;
            MoreWrapped = (MoreRoses + GiftWrap); // price of more roses with wrap

            Double MoreWrappedTax;
            MoreWrappedTax = (MoreWrapped * TaxRate) + MoreWrapped; // price of more roses with wrap taxed. 



            if (Roses == 1)
            {
               txtOutput.Text = "Customer: " + txtName.Text + "\r\n" + "Number of Roses " + Roses + "\r\n"+
                    "Price" + PriceSingle.ToString("C") + "\r\n" + "Price after tax: " + SingleTax;
                if (chkWrap.Checked == true)
                {
                    txtOutput.Text = "Customer: " + txtName.Text + "\r\n" + "Number of Roses " + Roses
                        + "\r\n" +
                    "Price" + Wrapped.ToString("C") + "\r\n" + "Price after tax: " + WrappedTaxed.ToString("C");
                }
            }
            
            else if (Roses >=2)
            {
                txtOutput.Text = "Customer: " + txtName.Text + "\r\n" + "Number of Roses " + Roses + "\r\n" +
                   "Price" + MoreRoses.ToString("C") + "\r\n" + "Price after tax: " + MultiTax.ToString("C");
                if (chkWrap.Checked == true)
                {
                    txtOutput.Text = "Customer: " + txtName.Text + "\r\n" + "Number of Roses " + Roses
                       + "\r\n" +
                   "Price" + MoreWrapped.ToString("C") + "\r\n" + "Price after tax: " + MoreWrappedTax.ToString("C");
                }
            }

        }

        private void ChkWrap_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            chkWrap.Checked = false;
            txtName.Text = "";
            txtOutput.Text = "";
            txtStemsNum.Text = "";
            txtName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
