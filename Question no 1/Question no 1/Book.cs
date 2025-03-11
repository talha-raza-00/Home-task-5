using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Question_no_1
{
    internal class Book
    {
        private string authur;
        private string name;
        private int year;
        private int price;

        //Default constructor
        public Book()
        {
            authur = "Null";
            name = "Null";
            price = 0;
            year = 0;
        }

        //setter functions 
        public void setauthur(string authur)
        {
            this.authur = authur;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setprice(int price)
        {
            this.price = price;
        }
        public void setyear(int year)
        {
            this.year = year;
        }

        //Getter functions 
        public int getyear()
        {
            return this.year;
        }
        public string getname()
        {
            return this.name;
        }
        public string getauthur()
        {
            return this.authur;
        }
        public int getprice()
        {
            return this.price;
        }



    }
}
