using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum, discount, total;
            sum = 309000;
            discount = 0;
            if (checkBox1.Checked)
            {
                sum += 8900;
            }
            if (checkBox2.Checked)
            {
                sum += 4900;
            }
            if (checkBox3.Checked)
            {
                sum += 7590;
            }
            total = sum;
            string st = "Цена в выбранно комплектации: " + sum.ToString("c");
            if((checkBox1.Checked)&&(checkBox2.Checked)&&(checkBox3.Checked))
            {
                discount = sum * 0.01;
                total = sum - discount;
                st += "\nскидка (1%):  " +
                    discount.ToString("c") +
                    "\nИтогож: " + total.ToString("c");
            }
            label2.Text = st;
        }
    }
}
