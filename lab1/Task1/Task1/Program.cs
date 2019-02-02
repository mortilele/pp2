using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool prime(int k)
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
            string a = Console.ReadLine(); //read n
            int n = int.Parse(a); //convert 
            string s = Console.ReadLine(); //input list of number
            string[] arr = s.Split(); //split each other by space
            int[] p = new int[n]; //create array of numbers
            List<int> list = new List<int>(); //create list, where hold prime num
            for (int i = 0; i < n; i++)
                p[i] = int.Parse(arr[i]); //convert each string into int
            for (int i = 0; i < n; i++)
            {
                if (prime(p[i]) == true) //check number to primarity
                {
                    list.Add(p[i]); //add to list prime numbers
                }

            }
            Console.WriteLine(list.Count); //print count of prime numbers
            for (int i = 0; i < list.Count; i++) //print list of prime numbers
                Console.Write(list[i] + " ");

            Console.ReadLine();
        }
    }
}
