using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    public class MarkList
    {
        public List<Mark> Marks;
        public MarkList()
        {
            Marks = new List<Mark>();
        }

        public void Save(MarkList M)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(MarkList));
            xs.Serialize(fs, M);
            fs.Close();
        }
        public void Show()
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(MarkList));
            MarkList M = xs.Deserialize(fs) as MarkList;
            for (int i = 0; i < M.Marks.Count; i++)
            {
                Console.WriteLine(M.Marks[i]);
            }
        }
    }
    public class Mark
    {
        public int Points;

        public Mark() { }
        public Mark(int Points)
        {
            this.Points = Points;
        }

        public string GetLetter()
        {
            if (Points >= 95)
                return "A";
            if (Points >= 90 && Points < 95)
                return "A-";
            if (Points >= 85 && Points < 90)
                return "B+";
            if (Points >= 80 && Points < 85)
                return "B";
            if (Points >= 75 && Points < 80)
                return "B-";
            if (Points >= 70 && Points < 75)
                return "C+";
            if (Points >= 65 && Points < 70)
                return "C";
            if (Points >= 60 && Points < 65)
                return "C-";
            if (Points >= 55 && Points < 60)
                return "D+";
            if (Points >= 50 && Points < 55)
                return "D";
            return "F";
        }
        public override string ToString()
        {
            return GetLetter();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mark m1 = new Mark(55);
            Mark m2 = new Mark(96);
            Mark m3 = new Mark(70);
            MarkList M = new MarkList();
            M.Marks.Add(m1);
            M.Marks.Add(m2);
            M.Marks.Add(m3);
            M.Save(M);
            M.Show();
            Console.ReadKey();
        }
    }
}
