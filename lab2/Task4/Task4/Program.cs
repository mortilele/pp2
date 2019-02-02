using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path2 = @"C:\Users\User\Desktop\Codi\pp2\lab2\Task4\path2\input.txt"; //path where we have to move file
        string path = @"C:\Users\User\Desktop\Codi\pp2\lab2\Task4\input.txt"; //origin path
        File.Move(path, path2); //move the file from path to path 2
            Console.WriteLine("{0} was moved to {1}.", path, path2); //info
            File.Delete(path2); //delete from path2
            StreamWriter sw = File.CreateText(path); //create again in origin path
            Console.ReadKey();
            



    }
}