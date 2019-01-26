using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = n-i; j <= n; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}
