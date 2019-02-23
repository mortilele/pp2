using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ClassPractice
{
    public class OrderDetails
    {
        public int OrderID;
        public int ItemID;
        public string ItemName;
        public int ItemUnit;
        public int Quantity;
        public int Total;

        public OrderDetails() { }
        public OrderDetails(int OrderID, int ItemID, string ItemName, int ItemUnit, int Quantity)
        {
            this.OrderID = OrderID;
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.ItemUnit = ItemUnit;
            this.Quantity = Quantity;
            this.Total = ItemUnit * Quantity;
        }
    }

    public class Booking
    {
        public UserInfo User;
        public List<OrderDetails> OrderList;

        public Booking() { }
        public Booking(UserInfo User)
        {
            this.User = User;
            OrderList = new List<OrderDetails>();
        }

        public void SaveDB(Booking Book)
        {
            FileStream fs = new FileStream("booking.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Booking));
            xs.Serialize(fs, Book);
            fs.Close();
        }

        public void Show()
        {
            FileStream fs = new FileStream("booking.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Booking));
            Booking book = xs.Deserialize(fs) as Booking;
            fs.Close();
            for (int i = 0; i < book.OrderList.Count; i++)
            {
                Console.WriteLine(book.OrderList[i].OrderID);
                Console.WriteLine(book.OrderList[i].ItemID);
                Console.WriteLine(book.OrderList[i].ItemName);
                Console.WriteLine(book.OrderList[i].Total);
            }
        }

    }

    public class BookList
    {
        public List<Booking> Books;
        public BookList()
        {
            Books = new List<Booking>();
        }

        public void SaveDB(BookList Books)
        {
            FileStream fs = new FileStream("bookings.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(BookList));
            xs.Serialize(fs, Books);
            fs.Close();
        }

        public void Show()
        {
            FileStream fs = new FileStream("bookings.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(BookList));
            BookList books = xs.Deserialize(fs) as BookList;
            fs.Close();
            for (int i = 0; i < books.Books.Count; i++)
            {
                Console.WriteLine("User {0}: ", i);
                for (int j = 0; j < books.Books[i].OrderList.Count; j++)
                {
                    Console.WriteLine(Books[i].OrderList[j].OrderID);
                    Console.WriteLine(Books[i].OrderList[j].ItemID);
                    Console.WriteLine(Books[i].OrderList[j].ItemName);
                    Console.WriteLine(Books[i].OrderList[j].Total);
                }
            }
        }
    }



    class DB
    {
    }
}
