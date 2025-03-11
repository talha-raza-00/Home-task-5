using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int counter;

        public void addbook(Book book1)
        {
            books[counter++] = book1;
        }
       
        public void listofbooks()
        {
            Console.WriteLine("\n\tAll books ");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("\nTitle = {0}", books[i].getname());
                Console.WriteLine("Authur = {0}", books[i].getauthur());
                Console.WriteLine("Price = " + books[i].getprice());    
                Console.WriteLine("Year = "+ books[i].getyear());
            }
        }

        public void searchbook()
        {
            Console.Write("\nEnter the name or Authur of book : ");
            string var = Console.ReadLine();
            for (int i = 0; i < counter; i++)
            {
                if (var == books[i].getname() || var == books[i].getauthur())
                {
                    Console.WriteLine("\nTitle = {0}", books[i].getname());
                    Console.WriteLine("Authur = {0}", books[i].getauthur());
                    Console.WriteLine("Price = " + books[i].getprice());
                    Console.WriteLine("Year = " + books[i].getyear());
                }

            }
        }



    }
}
