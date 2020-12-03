using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_POP_Nativel
{
  public  class Address
    {
       public int number;
       public string street;
       public string city;
      public  string country;
     public   Address(int number, string street,string city, string country)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.country = country;
        }
        public void ToString()
        {
            Console.WriteLine(country + " " + city + " " + street + " " + number);
        }
    }
}
