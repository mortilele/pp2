using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ClassPractice
{
    
    public class UserInfo
    {
        public int ID;
        public string name;
        public string email;
        public string address;

        public UserInfo() { }
        public UserInfo(int ID, string name, string email, string address)
        {
            this.ID = ID;
            this.name = name;
            this.email = email;
            this.address = address;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo User = new UserInfo(1, "Kymbatya", "kyma@utka.com", "Utka city");
            OrderDetails Order1 = new OrderDetails(1, 1, "RetakeCalc", 150, 1);
            OrderDetails Order2 = new OrderDetails(1, 2, "RetakePP", 200, 1);
            Booking Book = new Booking(User);
            Book.OrderList.Add(Order1);
            Book.OrderList.Add(Order2);

            UserInfo User2 = new UserInfo(2, "Alesha", "ali@utka.com", "Utka city");
            OrderDetails Order21 = new OrderDetails(2, 1, "ACM", 150, 1);
            OrderDetails Order22 = new OrderDetails(2, 2, "IBM", 200, 1);

            Booking Book2 = new Booking(User2);
            Book2.OrderList.Add(Order21);
            Book2.OrderList.Add(Order22);

            BookList Books = new BookList();
            Books.Books.Add(Book);
            Books.Books.Add(Book2);
            Books.SaveDB(Books);
            Books.Show();


            Console.ReadKey();
        }
    }
}
