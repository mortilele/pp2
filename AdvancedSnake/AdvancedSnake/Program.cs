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
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetWindowSize(70, 27);
            Console.SetBufferSize(70, 27);
            Interface menu = new Interface();
            menu.Shtori();
        }
    }
}
