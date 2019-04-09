using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FruitCatch
{
    public partial class Form1 : Form
    {
        List<PictureBox> labels;
        List<int> random_list;
        public int cnt = 1;
        public int dy = 10;
        public Form1()
        {
            InitializeComponent();
            labels = new List<PictureBox>();
            random_list = new List<int>();
            Do();
            generate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //Movement of platform
        {
            Point location = new Point();
            location.Y = button1.Location.Y;
            location.X = e.Location.X - button1.Width / 2;
            button1.Location = location;
        }

        public int IsCollision(PictureBox lbl) //Collision check
        {
            if (lbl.Location.Y + 10 >= button1.Location.Y && (lbl.Location.X >= button1.Location.X && lbl.Location.X <= button1.Location.X + button1.Width))
            {
                if ((string)(lbl.Tag) == "bomb")
                    return 1;
                else return 2;
            }
            return 0;
        }

        public void Do()
        {
            Random random = new Random();
           
            while (random_list.Count <= 10)
            {
                int num = random.Next(1, 500);
                if (!random_list.Contains(num))
                {
                    random_list.Add(num);
                }
            }
        }

        public int randomize()
        {
            Random random = new Random();
            int x = random.Next(1, 3);
            return x;
        }

        public int randomize_y()
        {
            Random random = new Random();
            int y = random.Next(-300, 0);
            return y;
        }

        private void generate() //generate objects
        {
            for (int i = 0; i < 10; i++)
            {
                int x = random_list[i];
                int y = randomize_y();
                PictureBox lbl = new PictureBox();
                int val = randomize();
                lbl.SizeMode = PictureBoxSizeMode.Zoom;
                if (val == 1)
                {
                    lbl.Image = Image.FromFile("../../fruit.png");
                    lbl.Tag = "fruit";
                }
                else
                {
                    lbl.Image = Image.FromFile("../../bomb.png");
                    lbl.Tag = "bomb";
                }
                lbl.Text = "";
                lbl.Size = new Size(25, 25);
                lbl.Location = new Point(x, y);
                labels.Add(lbl);
                Controls.Add(labels[i]);
            }
        }

        public Point overflow()
        {
            Point p = new Point();
            Random random = new Random();
            p.X = random.Next(0, 500);
            p.Y = random.Next(-300, 0);
            return p;
        }

        private void timer1_Tick(object sender, EventArgs e) //movement of objects
        {
            
          
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + dy);
                if (labels[i].Location.Y > Height)
                {
                    labels[i].Location = overflow();
                }
                if (IsCollision(labels[i])==2)
                {
                    cnt++;
                    if (cnt % 5 == 0)
                        dy += 1;
                    labels[i].Location = overflow();
                }
                if (IsCollision(labels[i]) == 1)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("GAME OVER!" + Environment.NewLine + "Your record: " + (cnt-1));
                }
            }
            result.Text = cnt-1 + "";

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
