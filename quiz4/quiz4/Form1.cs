using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz4
{
    public partial class Form1 : Form
    {
        int res = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int temp = Convert.ToInt32(b.Text);
            temp++;
            if (temp % 2 == 0)
                res++;
            b.Text = temp + "";
            textBox1.Text = res + "";
        }
    }
}
