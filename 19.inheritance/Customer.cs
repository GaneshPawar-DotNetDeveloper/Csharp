using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.inheritance
{
   public class Customer // this is a parent class or in oops language this is base class 
    {
        public int ticketAmout;
        public Customer()
        {
            Console.WriteLine("customer constructor called");
        }
        public void Showtiming()
        {
            Console.WriteLine("## All todays timing");
        }
        public void GettiketAmout()
        {
            Console.WriteLine($"Ticket Amount is : {ticketAmout}");
        }
        
    }
}
