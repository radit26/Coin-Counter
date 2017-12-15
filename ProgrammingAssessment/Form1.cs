using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create integers to be used 
        private int i = 0;
        private int i2 = 0;
        private int i3 = 0;
        private int i4 = 0;
        private int i5 = 0;
        private int i6 = 0;
        private int i7 = 0;
        private int i8 = 0;
        private int intTotalValue = 0;
        private double dblPounds = 0;
        

        private void boxOnePence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0") //Sets the condition that the textbox has to be filled
            {
                MessageBox.Show("You have not set the cost per credit"); //Shows a box with a message if the user does not type in a number in the textbox
            }
            else
            {
                i++; //This will increment the integer i by 1
                label1.Text = i.ToString(); //Puts the integer i into the label and converts in into a string

               
                intTotalValue += 1; 
                txtTotalValue.Text = intTotalValue.ToString(); //Converts the text inside the txtTotalValue textbox into a string

                dblPounds += 0.01; //The double variable dblPounds will be added by 0.01
                txtPounds.Text = dblPounds.ToString(); //Inserts dblPounds into the textbox called txtPounds and converts it into a string 
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text)); //Formats the currency

                //Fill the txtNoOfCredits textbox with the result of the values in txtTotalValue divided by the values in txtCostPerCredit
                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString(); 


            }
        }

        private void boxTwoPence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i2++;
                label2.Text = i2.ToString();

                intTotalValue += 2;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds += 0.02;

                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));

                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();


            }
        }

        private void boxFivePence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i3++;
                label3.Text = i3.ToString();

                intTotalValue += 5;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds += 0.05;
                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));

                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();
            }
        }

        private void boxTenPence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i4++;
                label4.Text = i4.ToString();

                intTotalValue += 10;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds += 0.1;
                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));


                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();
            }
        }

        private void boxTwentyPence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i5++;
                label5.Text = i5.ToString();

                intTotalValue += 20;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds += 0.2;
                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));


                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();
            }
        }

        private void boxFiftyPence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i6++;
                label6.Text = i6.ToString();

                intTotalValue += 50;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds += 0.5;
                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));


                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();
            }
        }

        private void boxOnePound_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i7++;
                label7.Text = i7.ToString();

                intTotalValue += 100;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds++;
                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));


                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();
            }
        }

        private void boxTwoPounds_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i8++;
                label8.Text = i8.ToString();

                intTotalValue += 200;
                txtTotalValue.Text = intTotalValue.ToString();

                dblPounds += 2;
                txtPounds.Text = dblPounds.ToString();
                txtPounds.Text = String.Format("{0:n2}", Convert.ToDouble(txtPounds.Text));

                txtNoOfCredits.Text = (int.Parse(txtTotalValue.Text) / int.Parse(txtCostPerCredit.Text)).ToString();
            }
        }
    }
}
