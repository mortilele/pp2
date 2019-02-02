using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Block(int depth) //n times space for sub directories
        {
            for (int i = 0; i < depth; i++)
                Console.Write("    ");
            Console.Write(" > ");
        }

        public static void BlockforFile(int depth) //n time space for files in sub directories
        {
            for (int i = 0; i < depth; i++)
                Console.Write("    ");
        }
        public static void explorer(string path, int depth)
        {
            DirectoryInfo dir = new DirectoryInfo(path); //init new directory from that path
            if (depth == 0) //out main directory
            {
                Console.WriteLine("Main directory: " + dir.Name);
            }
            FileInfo[] filelist = dir.GetFiles(); //collect files in directory in array
            DirectoryInfo[] dirlist = dir.GetDirectories(); //collect subdirectories in array
            foreach (FileInfo f in filelist) //at first out all files in directory
            {
                BlockforFile(depth+1);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dirlist) //then out all subdirectories
            {
                Block(depth+1);
                Console.WriteLine(d.Name);
                explorer(d.FullName, depth+2); //recall function for each subdirectory of main directory, while subdirectories exist

            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\Codi\acm"; //string path of directory
            explorer(path, 0); //call recursive function to operate
            Console.ReadKey();



        }
    }
}
