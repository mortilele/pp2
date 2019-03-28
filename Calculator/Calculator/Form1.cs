using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        string last;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            editer.Text +="1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            editer.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            editer.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            editer.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            editer.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            editer.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            editer.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            editer.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            editer.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            editer.Text += "0";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(editer.Text);
            editer.Text = "";
            last = "div";
            operation.Text = a + " / ";
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(editer.Text);
            editer.Text = "";
            last = "sum";
            operation.Text = a + " + ";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(editer.Text);
            editer.Text = "";
            last = "multi";
            operation.Text = a + " * ";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(editer.Text);
            editer.Text = "";
            last = "sub";
            operation.Text = a + " - ";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            a = 0;
            editer.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (last == "sum")
            {
                a += Convert.ToInt32(editer.Text);
                editer.Text = a + "";
            }
            if (last == "multi")
            {
                a *= Convert.ToInt32(editer.Text);
                editer.Text = a + "";
            }
            if (last == "div")
            {
                a /= Convert.ToInt32(editer.Text);
                editer.Text = a + "";
            }
            if (last == "sub")
            {
                a -= Convert.ToInt32(editer.Text);
                editer.Text = a + "";
            }
            if (last == "pow")
            {
                double b = Convert.ToDouble(editer.Text);
                editer.Text = Convert.ToString(Math.Pow((double)a, b));
            }
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(editer.Text);
            editer.Text = "";
            last = "pow";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
