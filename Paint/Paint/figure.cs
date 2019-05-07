using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class figure
    {
        public Point first;
        public Point second;
        public string type;
        public Pen pen;
        public bool NULL;
        public figure(Point first, Point second, string type, Pen pen)
        {
            this.first = first;
            this.second = second;
            this.type = type;
            this.pen = pen;
            this.NULL = false;
        }
        public figure()
        {
            NULL = true;
            first = new Point();
            second = new Point();
            type = null;
            pen = null;
        }
    }
}
