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
//In_Lab03
//Lab Session Friday 1:30
*/

namespace In_Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit the Program
        }

        private void BtnSummary_Click(object sender, EventArgs e)
        {
            //Declare Variables
            Double Semester1;
            Semester1 = Double.Parse(txtSemester1.Text);
            Double Semester2;
            Semester2 = Double.Parse(txtSemester2.Text);
            Double Semester3;
            Semester3 = Double.Parse(txtSemester3.Text);
            Double Semester4;
            Semester4 = Double.Parse(txtSemester4.Text);

            
            



            txtOutput.Text = "Full Name: " + txtName.Text + "\r\n Semester One:" + Semester1 + "\r\n Semester Two: " + Semester2 + "\r\n Semester Three: " + Semester3 + "\r\n Semester Four: " + Semester4 + "\r\n College: " + cboCollege.Text + "\r\n";
            
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            //Declare Varaibless
            Double Semester1;
            Semester1 = Double.Parse(txtSemester1.Text);
            Double Semester2;
            Semester2 = Double.Parse(txtSemester2.Text);
            Double Semester3;
            Semester3 = Double.Parse(txtSemester3.Text);
            Double Semester4;
            Semester4 = Double.Parse(txtSemester4.Text);
            
            //Decleare Variables
            Double Average;
            Average = (Semester1 + Semester2 + Semester3 + Semester4) / (4); // Average Calculation set to variables
            string Output = txtOutput.Text;
            txtOutput.Text = Output + "Average GPA = " + Average.ToString("N");


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            txtName.Text = "";
            txtSemester1.Text = "";
            txtSemester2.Text = "";
            txtSemester3.Text = "";
            txtSemester4.Text = "";
            cboCollege.SelectedIndex = -1;
            txtName.Focus();

            
        }
    }
}
