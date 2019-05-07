using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Point cur;
        Point prev;
        Color color;
        Pen pen = new Pen(Color.Blue, 3);
        int[] x = new int[500];
        int[] y = new int[500];
        int dx, dy;
        int r = 25;
        int i = 0;
        int x0, y0;
        int t = 0;
        

        private void draw_area_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void draw_area_MouseDown(object sender, MouseEventArgs e)
        {
            x[i] = e.Location.X;
            y[i] = e.Location.Y;
            i++;
            //prev = e.Location;
        }

        public Form1()
        {
            InitializeComponent();
            
            bmp = new Bitmap(draw_area.Width, draw_area.Height);
            g = Graphics.FromImage(bmp);
            draw_area.Image = bmp;
        }

        private void draw_area_Paint(object sender, PaintEventArgs e)
        {
            for (int j = 0; j < i; j++)
             {
                 e.Graphics.FillEllipse(pen.Brush, x[j] - r, y[j] - r, 2 * r, 2 * r);
                 y[j] += 5;
             }
             
            //x0 = cur.X - dx * t;
            //y0 = cur.Y - dy * (t/2) + (t * t) ;
            //e.Graphics.FillEllipse(pen.Brush, x0- r, y0 - r, 2 * r, 2 * r);
            //t += 1;
        }

        private void draw_area_MouseUp(object sender, MouseEventArgs e)
        {
            //cur = e.Location;
            //dx = cur.X - prev.X;
            //dy = cur.Y - prev.Y;
            //timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            draw_area.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          //  e.Graphics.FillRectangle(pen.Brush, x1, y1, 50, 50);
        }
    }
}
