using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.setname("oop");
            book1.setauthur("Talha");
            book1.setprice(10); 
            book1.setyear(2001);

            Book book2 = new Book();
            book2.setname("Maths");
            book2.setauthur("ABC");
            book2.setprice(100);
            book2.setyear(2009);

            Library library1 = new Library();
            library1.addbook(book1);
            library1.addbook(book2);
            library1.listofbooks();
            library1.searchbook();


        }
    }
}
