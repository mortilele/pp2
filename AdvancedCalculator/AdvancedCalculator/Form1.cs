using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Form1 : Form
    {
        TextBox cons = new TextBox();  //global vars
        double temp, temp2;
        string last;
        bool biop;
        ComboBox cmb = new ComboBox();
        List<double> memory = new List<double>() { 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 77, x0 = 51;
            int y = 52, y0 = 20;
            BackColor = Color.FromArgb(35, 35, 35);
            Label caption = new Label();
            caption.Size = new Size(200, 20);
            caption.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold);
            caption.Location = new Point(15, 15);
            caption.Text = "Standard";
            cons.Size = new Size(295, 100);
            cons.Font = new Font("Microsoft Sans Serif", 30.25F);
            cons.Location = new Point(10, 50);
            cons.BackColor = Color.FromArgb(35,35,35);
            cons.ForeColor = Color.White;
            cons.KeyPress += new KeyPressEventHandler(cons_KeyPress);
            cons.TextAlign = HorizontalAlignment.Right;
            cons.BorderStyle = BorderStyle.None;
            cons.Text = "0";
            Controls.Add(cons);
            Controls.Add(caption);
            string[] memory = new string[]
                { "MC", "MR", "M+", "M-", "MS" };
            string[] sym = new string[]
                { "Mono:sin", "Mono:cos", "Mono:1/x", "Mono:√",
                  "Mono:C", "Bi:x^y", "Mono:<=", "Bi:/",
                  "Num:7", "Num:8", "Num:9", "Bi:*",
                  "Num:4", "Num:5", "Num:6", "Bi:-",
                  "Num:1", "Num:2", "Num:3", "Bi:+",
                  "Bi:+-", "Num:0", "Mono:.", "Bi:=",
                };
            int ind = 0, k = 0;

            for (int i = 0; i < 6; i++) //memory buttons drawing
            {
                if (k == 5)
                {
                    cmb.TabStop = false;
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.Size = new Size(50, 30);
                    cmb.Location = new Point(3 + x0 * 5, 110);
                    cmb.SelectionChangeCommitted += new EventHandler(cmb_Selected);
                    cmb.DropDown += new EventHandler(cmb_drop);
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmb.BackColor = Color.FromArgb(35, 35, 35);
                    cmb.ForeColor = Color.White;
                    cmb.Font = new Font("Microsoft Sans Serif", 12.25F);
                    cmb.Items.Add("ML");
                    cmb.Text = "ML";
                    Controls.Add(cmb);
                }
                else
                {
                    Button btn = new Button();
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += new EventHandler(memory_click);
                    btn.Text = memory[k++];
                    btn.Size = new Size(50, 30);
                    btn.Location = new Point(3 + x0 * i, 110);
                    Controls.Add(btn);
                }
            }

            for (int i = 0; i < 6; i++) //keypad op drawing
                for (int j = 0; j < 4; j++, ind++)
                {
                    Button btn = new Button();
                    if (sym[ind].IndexOf("Bi:") != -1)
                    {
                        btn.Text = sym[ind].Substring(sym[ind].LastIndexOf("Bi:") + 3);
                        btn.BackColor = Color.FromArgb(20, 20, 20);
                    }
                    if (sym[ind].IndexOf("Num") != -1)
                    {
                        btn.Text = sym[ind].Substring(sym[ind].LastIndexOf("Num:") + 4);
                        btn.BackColor = Color.Black;
                    }
                    if (sym[ind].IndexOf("Mono:") != -1)
                    {
                        btn.Text = sym[ind].Substring(sym[ind].LastIndexOf("Mono:") + 5);
                        btn.BackColor = Color.FromArgb(20,20,20);
                    }
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Size = new Size(75, 50);
                    btn.MouseEnter += new EventHandler(Mouse_Enter);
                    btn.MouseLeave += new EventHandler(Mouse_Leave);
                    btn.Click += new EventHandler(number_click);
                    btn.Location = new Point(3 + x * j, 148 + y * i);
                    btn.Font = new Font("Microsoft Sans Serif", 17.25F);
                    Controls.Add(btn);
                }
        }

        public void memory_click(object sender, EventArgs e) //memory button actions
        {
            Button btn = sender as Button;
            if (btn.Text == "MS" && cons.Text != "")
            {
                memory.Add(Convert.ToDouble(cons.Text));
                cmb.Items.Add(cons.Text);
            }
            if (btn.Text == "M+" && cons.Text != "")
            {
                memory[memory.Count - 1] += Convert.ToDouble(cons.Text);
                cmb.Items[cmb.Items.Count - 1] = Convert.ToString(memory[memory.Count - 1]);
            }
            if (btn.Text == "M-" && cons.Text != "")
            {
                memory[memory.Count - 1] -= Convert.ToDouble(cons.Text);
                cmb.Items[cmb.Items.Count - 1] = Convert.ToString(memory[memory.Count - 1]);
            }
            if (btn.Text == "MC")
            {
                memory = new List<double>() { 0 };
                cmb.Items.Clear();
                cmb.Items.Add("ML");
                cmb.Text = "ML";
            }
            if (btn.Text == "MR")
            {
                cons.Text = Convert.ToString(memory[memory.Count - 1]);
            }
        }

        public void number_click(object sender, EventArgs e) //key pad actions
        {
            Button btn = sender as Button;

            if (btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5" || btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9" || btn.Text == "0")
            {
                if (cons.Text == "0")
                {
                    cons.Text = "";
                }
                cons.Text += btn.Text;
            }

            if (btn.Text == "+" && cons.Text != "")
            {
                temp = Convert.ToDouble(cons.Text);
                cons.Text = "";
                last = "sum";
                biop = true;
            }

            if (btn.Text == "-" && cons.Text != "")
            {
                temp = Convert.ToDouble(cons.Text);
                cons.Text = "";
                last = "sub";
                biop = true;
            }

            if (btn.Text == "*" && cons.Text != "")
            {
                temp = Convert.ToDouble(cons.Text);
                cons.Text = "";
                last = "multi";
                biop = true;
            }

            if (btn.Text == "/" && cons.Text != "")
            {
                temp = Convert.ToDouble(cons.Text);
                cons.Text = "";
                last = "div";
                biop = true;
            }

            if (btn.Text == "C")
            {
                cons.Text = "";
                temp = 0;
            }

            if (btn.Text == "+-" && cons.Text != "")
            {
                double temp2 = -1 * Convert.ToDouble(cons.Text);
                cons.Text = Convert.ToString(temp2);
            }

            if (btn.Text == "√" && cons.Text != "")
            {
                double temp2 = Math.Sqrt(Convert.ToDouble(cons.Text));
                cons.Text = Convert.ToString(temp2);
            }

            if (btn.Text == "<=" && cons.Text != "")
            {
                if (cons.Text.Length != 1)
                    cons.Text = cons.Text.Remove(cons.Text.Length - 1, 1);
                else cons.Text = "0";
            }

            if (btn.Text == "sin" && cons.Text != "")
            {
                double angle = Math.Sin(Math.PI * (Convert.ToDouble(cons.Text)/180.0));
                cons.Text = Convert.ToString(angle);
            }

            if (btn.Text == "cos" && cons.Text != "")
            {
                double angle = Math.Cos(Math.PI * (Convert.ToDouble(cons.Text) / 180.0));
                cons.Text = Convert.ToString(angle);
            }

            if (btn.Text == "1/x" && cons.Text != "")
            {
                double temp2 = 1/(Convert.ToDouble(cons.Text));
                cons.Text = Convert.ToString(temp2);
            }

            if (btn.Text == "." && cons.Text != "")
            {
                if (cons.Text.IndexOf('.')==-1)
                    cons.Text += ".";

            }

            if (btn.Text == "x^y" && cons.Text != "")
            {
                temp = Convert.ToDouble(cons.Text);
                cons.Text = "";
                last = "pow";
                biop = true;
            }
            if (btn.Text == "=" && cons.Text != "")
            {
               double result = 0;
                if (!biop)
                {
                    temp = temp2;
                    biop = true;
                }
                temp2 = Convert.ToDouble(cons.Text);
              
                    if (last == "sum")
                        result = temp2 + temp;
                    if (last == "sub")
                        result = temp - temp2;
                    if (last == "div")
                        result = temp / temp2;
                    if (last == "multi")
                        result = temp * temp2;
                    if (last == "pow")
                        result = Math.Pow(temp, temp2);
                cons.Text = Convert.ToString(result);
            }
        }

        public void Mouse_Enter(object sender, EventArgs e) //Hover
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/" || btn.Text == "=")
            {
                btn.BackColor = Color.GreenYellow;
                btn.ForeColor = Color.Black;
            }
            else
                btn.BackColor = Color.FromArgb(60,60,60);
        }

        public void Mouse_Leave(object sender, EventArgs e) //Reset 
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
            string num = "0123456789";
            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/" || btn.Text == "=")
            {
                btn.BackColor = Color.FromArgb(20,20,20);
                btn.ForeColor = Color.White;
            }
            if (num.Contains(btn.Text))
                btn.BackColor = Color.Black;
            else btn.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void cmb_Selected(object sender, EventArgs e) //memory list selection
        {
            cons.Text = cmb.SelectedItem.ToString();
            cmb.Items.Add("ML");
            cmb.Text = "ML";
        }

        private void cmb_drop(object sender, EventArgs e) //clearing ML
        {
            if (cmb.Items.Contains("ML"))
                cmb.Items.Remove("ML");
        }

        private void cons_KeyPress(object sender, KeyPressEventArgs e) //accept textbox only digits and .
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
