using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //read size of array
            List<int> a = new List<int>();//create array of size n
            string[] ss = Console.ReadLine().Split(); //split sequence
            for (int i = 0; i < n; i++)
            {
                a.Add(int.Parse(ss[i])); //from string to int each element 
                a.Add(int.Parse(ss[i])); //two times
            }
            for (int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i] + " "); //double output each element of array
            }
            Console.ReadLine();
        }
    }
}
