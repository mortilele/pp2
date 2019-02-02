using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../input.txt"); //read file
            string s;
            while((s = sr.ReadLine())!=null) //read each line in file until not ending point
            {
                char[] chararray = s.ToCharArray(); //reload to char array
                Array.Reverse(chararray); //reverse char array
                string res = new string(chararray); //reload it to string
                if (res == s) //if reverse and origin string are equal, it's palindrome
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
		Console.ReadKey();
        }
    }
}
