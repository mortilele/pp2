using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    enum Tool
    {
        Pencil,
        Line,
        Rectangle,
        Ellipse,
        Star,
        Triangle,
        Right_Triangle,
        Fill,
        Fill2
    }
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Point first_p;
        Point second_p;
        int size = 1;
        Color color = Color.Black;
        Pen pen = new Pen(Color.Black, 1);
        Tool activeTool = Tool.Star;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(draw_area.Width, draw_area.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            draw_area.Image = bitmap;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void draw_area_MouseDown(object sender, MouseEventArgs e)
        {
            first_p = e.Location;
            if (activeTool == Tool.Fill) //BFS lul
            {
                DummyFill dummyFill = new DummyFill();
                dummyFill.Fill(bitmap, e.Location, pen.Color);
                draw_area.Refresh();
            }
            else if (activeTool == Tool.Fill2) //seems more advanced and efficient
            {
                MapFill mapFill = new MapFill();
                mapFill.Fill(graphics, e.Location, pen.Color, ref bitmap);
                graphics = Graphics.FromImage(bitmap);
                draw_area.Image = bitmap;
            }

        }

        private void draw_area_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                second_p = e.Location;
                switch (activeTool)
                {
                    case Tool.Pencil:
                        graphics.DrawLine(pen, first_p, second_p);
                        first_p = second_p;
                        break;
                    default:
                        break;
                }
                draw_area.Refresh();
            }
        }

        private void color_picker_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                pen.Color = color;
            }
        }

        private void pencil_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pencil;
            pen.Color = color;
        }

        private void eraser_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pencil;
            pen = new Pen(Color.White, size);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(draw_area.Width, draw_area.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            draw_area.Image = bitmap;
        }

        private void line_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Line;
        }

        private void ellipse_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Ellipse;
        }

        private void rectangle_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Rectangle;
        }

        private void triangle_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Triangle;
        }

        private void right_triangle_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Right_Triangle;
        }

        private void star_pick_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Star;
        }

        Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle res = new Rectangle();
            res.X = Math.Min(p1.X, p2.X);
            res.Y = Math.Min(p1.Y, p2.Y);
            res.Width = Math.Abs(p1.X - p2.X);
            res.Height = Math.Abs(p1.Y - p2.Y);
            return res;
        }

        public Point[] Star() //Omagad that i had did, so sad :(
        {
            int dif = (first_p.Y + second_p.Y) / 8;
            Point p1 = new Point();
            p1.X = (first_p.X + second_p.X) / 2;
            p1.Y = (first_p.Y);
            Point p2 = new Point();
            p2.X = first_p.X;
            p2.Y = (first_p.Y + second_p.Y) / 2 - dif;
            Point p3 = new Point();
            p3.X = p1.X - dif;
            p3.Y = p2.Y;
            Point p4 = new Point();
            p4.X = first_p.X + (second_p.X-first_p.X) / 4;
            p4.Y = (first_p.Y + second_p.Y) / 2 + dif;
            Point p5 = new Point();
            p5.X = p4.X - dif;
            p5.Y = second_p.Y;
            Point p6 = new Point();
            p6.X = p1.X;
            p6.Y = first_p.Y+3*(second_p.Y-first_p.Y) / 4;
            Point p7 = new Point();
            p7.X = first_p.X + 3 * (second_p.X - first_p.X) / 4 + dif;
            p7.Y = second_p.Y;
            Point p8 = new Point();
            p8.X = first_p.X + 3*(second_p.X - first_p.X) / 4;
            p8.Y = p4.Y;
            Point p9 = new Point();
            p9.X = second_p.X;
            p9.Y = p2.Y;
            Point p10 = new Point();
            p10.X = p1.X + dif;
            p10.Y = p3.Y;
            Point[] points = new Point[10] {p1,p3,p2,p4,p5,p6,p7,p8,p9,p10};
            return points;
        }

        public Point[] Right_Triangle()
        {
            Point mid = new Point();
            mid.X = second_p.X;
            mid.Y = first_p.Y;
            Point[] points = new Point[3] { first_p, second_p, mid };
            return points;
        }

        public Point[] Triangle()
        {
            Point mid = new Point();
            mid.X = second_p.X + second_p.X - first_p.X;
            mid.Y = first_p.Y;
            Point[] points = new Point[3] { first_p, second_p, mid };
            return points;
        }

        private void draw_area_MouseUp(object sender, MouseEventArgs e)
        {
            switch (activeTool)
            {
                case Tool.Line:
                    second_p = e.Location;
                    graphics.DrawLine(pen, first_p, second_p);
                    draw_area.Refresh();
                    break;
                case Tool.Rectangle:
                    graphics.DrawRectangle(pen, GetRectangle(first_p, second_p));
                    break;
                case Tool.Ellipse:
                    graphics.DrawEllipse(pen, first_p.X, first_p.Y, second_p.X - first_p.X, second_p.Y - first_p.Y);
                    break;
                case Tool.Star:
                    graphics.DrawPolygon(pen, Star());
                    break;
                case Tool.Triangle:
                    graphics.DrawPolygon(pen, Triangle());
                    break;
                case Tool.Right_Triangle:
                    graphics.DrawPolygon(pen, Right_Triangle());
                    break;
                default:
                    break;
            }
        }

        private void draw_area_Paint(object sender, PaintEventArgs e)
        {
            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Line:
                    e.Graphics.DrawLine(pen, first_p, second_p);
                    break;
                case Tool.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(first_p, second_p));
                    break;
                case Tool.Ellipse:
                    e.Graphics.DrawEllipse(pen, first_p.X, first_p.Y, second_p.X - first_p.X, second_p.Y - first_p.Y);
                    break;
                case Tool.Star:
                    e.Graphics.DrawPolygon(pen, Star());
                    break;
                case Tool.Triangle:
                    e.Graphics.DrawPolygon(pen, Triangle());
                    break;
                case Tool.Right_Triangle:
                    e.Graphics.DrawPolygon(pen, Right_Triangle());
                    break;
                default:
                    break;
            }
        }

        private void size_pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = size_pick.SelectedIndex + 1;
            pen.Width = size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            bitmap.Save(filename + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            bitmap = new Bitmap(filename);
            graphics = Graphics.FromImage(bitmap);
            draw_area.Image = bitmap;
        }

        private void fill_click_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Fill2;
        }
    }
}
