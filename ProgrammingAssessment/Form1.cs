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
    }
}
