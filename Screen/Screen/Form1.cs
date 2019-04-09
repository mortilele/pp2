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

namespace Screen
{

    public partial class Form1 : Form
    {
        List<Pictu> list;
        public Form1()
        {
            int x = 10, y = 10;
            InitializeComponent();
            list = new List<Pictu>();
            for (int i = 1; i <= 4; i++)
            {
                Pictu temp = new Pictu(x,y, (PictureBox)Controls.Find("pictureBox" + i, true)[0]);
                list.Add(temp);
                if (i == 1)
                    x *= -1;
                if (i == 2)
                {
                    x *= -1;
                    y *= -1;
                }
                if (i == 3)
                    x *= -1;
            }
        }

        public class Pictu
        {
            public int dx;
            public int dy;
            public PictureBox picture;
            public Pictu(int dx, int dy, PictureBox picture)
            {
                this.dx = dx;
                this.dy = dy;
                this.picture = picture;
            }

        }

        public void IsCollision(PictureBox temp, int k)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == k)
                    continue;
                if ((list[i].picture.Location.X >= temp.Location.X && list[i].picture.Location.X <= temp.Location.X + temp.Width) && (list[i].picture.Location.Y >= temp.Location.Y && list[i].picture.Location.Y <= temp.Location.Y + temp.Height))
                {
                    list[i].dx *= -1;
                    list[i].dy *= -1;
                    list[k].dx *= -1;
                    list[k].dy *= -1;
                }
            }
        }

        private void Move(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                IsCollision(list[i].picture, i);
                Point location = list[i].picture.Location;
                if (location.X + list[i].picture.Width > Width || location.X < 0)
                    list[i].dx *= -1;

                if (location.Y + list[i].picture.Height + 10> Height || location.Y < 10)
                    list[i].dy *= -1;

                location.X += list[i].dx;
                location.Y += list[i].dy;

                list[i].picture.Location = location;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}
