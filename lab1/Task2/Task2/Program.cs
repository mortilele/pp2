using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class Student
        {
            string name;
            string id;
            int year = 0;

            public Student(string name, string id)
            {
                this.name = name;
                this.id = id;
            }

            public void print()
            {
                Console.WriteLine("Name of student: {0}", name);
                Console.WriteLine("Id of student: " + id);
            }

            public void incr()
            {
                year++;
                Console.WriteLine("Year of student increased by one, now is {0}", year);
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Alik", "18BD12312");
            s1.print();
            s1.incr();
            Console.ReadLine();
        }
    }
}
