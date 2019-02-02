using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool prime(int k) //function to check is number prime
        {
            if (k == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../input.txt"); //read input
            StreamWriter sw = new StreamWriter("output.txt"); //location where out data
            string[] s = sr.ReadLine().Split(); //read line and split by space
            foreach (string k in s) //for each element in string
            {
                if (prime(int.Parse(k))) //convert string to int and then check is number prime
                   {
                    sw.Write(k + " "); //if prime write to output txt
                }
            }

            sr.Close(); //close
            sw.Close();

        }
    }
}
