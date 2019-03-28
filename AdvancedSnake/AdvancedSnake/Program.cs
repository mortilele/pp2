using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvancedSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m.Start();
            Interface menu = new Interface();
            menu.Shtori();
        }
    }
}
