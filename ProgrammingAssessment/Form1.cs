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

        private int i = 0;
        private int i2 = 0;
        private int i3 = 0;
        private int i4 = 0;
        private int i5 = 0;
        private int i6 = 0;
        private int i7 = 0;
        private int i8 = 0;
        private int intTotalValue1p = 0;
        private int intTotalValue2p = 0;
        private int intTotalValue5p = 0;
        private int intTotalValue10p = 0;
        private int intTotalValue20p = 0;
        private int intTotalValue50p = 0;
        private int intTotalValue1Pound = 0;
        private int intTotalValue2Pounds = 0;

        private void boxOnePence_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text == "" || txtCostPerCredit.Text == "0")
            {
                MessageBox.Show("You have not set the cost per credit");
            }
            else
            {
                i++;
                label1.Text = i.ToString();

                intTotalValue1p++;
                Convert.ToInt32(intTotalValue1p).ToString();
                txtTotalValue.Text = intTotalValue1p.ToString();
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

                intTotalValue2p += 2;
                Convert.ToInt32(intTotalValue2p).ToString();
                txtTotalValue.Text = intTotalValue2p.ToString();
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

                intTotalValue5p += 5;
                txtTotalValue.Text = intTotalValue5p.ToString();
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

                intTotalValue10p += 10;
                txtTotalValue.Text = intTotalValue10p.ToString();
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

                intTotalValue20p += 20;
                txtTotalValue.Text = intTotalValue20p.ToString();
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

                intTotalValue50p += 50;
                txtTotalValue.Text = intTotalValue50p.ToString();
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

                intTotalValue1Pound += 100;
                txtTotalValue.Text = intTotalValue1Pound.ToString();
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

                intTotalValue2Pounds += 200;
                txtTotalValue.Text = intTotalValue2Pounds.ToString();
            }
        }
    }
}
