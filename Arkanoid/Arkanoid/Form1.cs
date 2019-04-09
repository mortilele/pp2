using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        public List<PictureBox> blocks = new List<PictureBox>();
        List<Color> colors = new List<Color>() { Color.Gray, Color.Red, Color.Yellow, Color.Blue, Color.Green };
        int block_x = 35, block_y = 16;
        public const int beg = 5;
        int ball_dx = beg, ball_dy = -beg;
        public int cur = 0;
        bool[] collised = new bool[50];
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            int t = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PictureBox temp = new PictureBox();
                    temp.BackColor = colors[i];
                    temp.Size = new Size(34, 15);
                    temp.Location = new Point(30 + block_x * j, 60 + block_y * i);
                    blocks.Add(temp);
                    collised[t++] = false;
                    panel1.Controls.Add(temp);
                }
            }
        }

        public void CollisionWithBlock()
        {
            for (int i = 0; i < blocks.Count; i++)
            {
                if (collised[i] == false)
                {
                    if ((ball.Location.X >= blocks[i].Location.X && ball.Location.X <= blocks[i].Location.X + blocks[i].Width && ball.Location.Y >= blocks[i].Location.Y && ball.Location.Y <= blocks[i].Location.Y + blocks[i].Height) || (ball.Location.X >= blocks[i].Location.X && ball.Location.X <= blocks[i].Location.X + blocks[i].Width && ball.Location.Y + ball.Height >= blocks[i].Location.Y && ball.Location.Y <= blocks[i].Location.Y + blocks[i].Height))
                    {
                        cur++;
                        if (cur == 150)
                        {
                            timer1.Enabled = false;
                            MessageBox.Show("   Congratulations! You won!");
                        }
                        if (cur % 10 == 0)
                        {
                            if (ball_dx >= 0)
                                ball_dx += 1;
                            else ball_dx -= 1;
                            if (ball_dy >= 0)
                                ball_dy += 1;
                            else ball_dy -= 1;
                        }
                        if (ball_dx >= 0 && ball_dy >= 0)
                            ball_dy *= -1;
                        else if (ball_dx < 0 && ball_dy >= 0)
                            ball_dy *= -1;
                        else if (ball_dx < 0 && ball_dy < 0)
                            ball_dy *= -1;
                        else if (ball_dx >= 0 && ball_dy < 0)
                            ball_dy *= -1;
                        if (blocks[i].BackColor == Color.Green)
                        {
                            collised[i] = true;
                            blocks[i].Visible = false;
                        }
                        if (blocks[i].BackColor == Color.Blue)
                            blocks[i].BackColor = Color.Green;
                        if (blocks[i].BackColor == Color.Yellow)
                            blocks[i].BackColor = Color.Blue;
                        if (blocks[i].BackColor == Color.Red)
                            blocks[i].BackColor = Color.Yellow;
                        if (blocks[i].BackColor == Color.Gray)
                            blocks[i].BackColor = Color.Red;
                    }
                }
            }
        }

        public void CollisionWithPlatform()
        {
            if (ball.Location.X >= platform.Location.X && ball.Location.X <= platform.Location.X + platform.Width && ball.Location.Y + ball.Height >= platform.Location.Y && ball.Location.Y <= platform.Location.Y + platform.Height)
            {
                if (ball_dx >= 0 && ball_dy >= 0)
                    ball_dy *= -1;
                if (ball_dx < 0 && ball_dy >= 0)
                    ball_dy *= -1;
            }
        }

        public Point CollisionWithWall()
        {
            Point location = ball.Location;
            if (location.X + ball.Width > Width || location.X < 0)
                ball_dx *= -1;
            if (location.Y < 0)
                ball_dy *= -1;
            if (location.Y + ball.Height > Height)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!");
            }
            location.X += ball_dx;
            location.Y += ball_dy;
            return location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CollisionWithPlatform();
            CollisionWithBlock();
            result.Text = cur+"";
            ball.Location = CollisionWithWall();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                ball_dy = -beg; ball_dx = beg;
            timer1.Enabled = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point location = new Point();
            location.Y = platform.Location.Y;
            location.X = e.Location.X;
            platform.Location = location;
            if (!timer1.Enabled)
                ball.Location = new Point(e.Location.X + platform.Width / 2, 541);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
