using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Calculator
{
    public partial class Form1 : Form
    {
        List<string> operators;
        string input;
        public Form1()
        {
            InitializeComponent();
            operators = new List<string>(6) { "(", ")", "+", "-", "*", "/" };
        }

        public int Priority(string s)
        {
            if (s == "(" || s == ")")
                return 0;
            if (s == "+" || s == "-")
                return 1;
            if (s == "*" || s == "/")
                return 2;
            return 3;
        }

        public List <string> Divide_and_Conquer()
        {
            List<string> output = new List<string>();
            int i = 0;
            while (i < input.Length)
            {
                string k = input[i] + "";
                if (char.IsDigit(input[i]))
                {
                    int j = i + 1;
                    while (j < input.Length && char.IsDigit(input[j]))
                    {
                        k += input[j];
                        j++;
                    }
                }
                output.Add(k);
                i += k.Length;
            }
            return output;
        }

        public List <string> ConvertOPN(List <string> divided)
        {
            List<string> operations = new List<string>();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < divided.Count; i++)
            {
                if (operators.Contains(divided[i]))
                {
                    if (stack.Count > 0 && divided[i] != "(")
                    {
                        if (divided[i] == ")")
                        {
                            string k = stack.Pop();
                            while (k != "(") //add all operations inside branches
                            {
                                operations.Add(k);
                                k = stack.Pop();
                            }
                        }
                        else if (Priority(divided[i]) > Priority(stack.Peek())) //less priority in stack just add to stack
                        {
                            stack.Push(divided[i]);
                        }
                        else
                        {
                            while (stack.Count > 0 && Priority(divided[i]) <= Priority(stack.Peek())) // (+ -) || (* /)
                            {
                                operations.Add(stack.Pop());
                            }
                            stack.Push(divided[i]);
                        }
                    }
                    else
                    {
                        stack.Push(divided[i]); // if stack empty
                    }
                }
                else
                {
                    operations.Add(divided[i]); //if number
                }
            }
            //remaining
            if (stack.Count > 0)
            {
                while (stack.Count > 0)
                {
                    string temp = stack.Pop();
                    operations.Add(temp);
                }
            }
            return operations;
        }

        public int Operate(string oper, int a, int b)
        {
            if (oper == "+")
                return a + b;
            if (oper == "-")
                return b - a;
            if (oper == "/")
                return b / a;
            return b * a;
        }


        public int Calculate(List <string> opn)
        {
            Stack<string> stack = new Stack<string>();
            int i = 0;
            string k = opn[i];
            int size = opn.Count;
            size--;
            while (size >= 0)
            {
                if (!operators.Contains(k)) //add numbers to stack
                {
                    stack.Push(k);
                    i++;
                    k = opn[i];
                    size--;
                }
                else
                {
                    int a = Convert.ToInt32(stack.Pop()); //meet two last numbers and last operations
                    int b = Convert.ToInt32(stack.Pop());
                    int result = Operate(k, a, b);
                    stack.Push(Convert.ToString(result));
                    if (size > 0)
                    {
                        i++;
                        k = opn[i];
                        size--;
                    }
                    else
                        break; 
                }
            }
            return Convert.ToInt32(stack.Pop());
        }



        private void button1_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            List<string> divided = Divide_and_Conquer(); //process input string
            List<string> opn = ConvertOPN(divided); // convert to notation
            int ans = Calculate(opn); //calculate
            string d = ""; 
            for (int i = 0; i < opn.Count; i++)
            {
                d += opn[i] + ",";
            }
            label1.Text = ans + "";
            textBox1.Text = d;
        }
    }
}
