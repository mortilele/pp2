using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{
    public class Complex
    {
        public decimal a; //real
        public decimal b; //imaginary
        public Complex() { }

        public Complex(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return a + "+" + b + "i";
        }

        public void Save(Complex num)
        {
            FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, num);
            fs.Close();
        }

        public void Show()
        {
            FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex num = xs.Deserialize(fs) as Complex;
            fs.Close();
            Console.WriteLine(num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(4, 2);
            complex.Save(complex);
            complex.Show();
            Console.ReadKey();
        }
    }
}
