using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.inheritance
{
    public class PlatinumCustomer : Customer
    {
        public PlatinumCustomer() 
            {
            ticketAmout = 400;
            }
        public void PrintTicket()
        {
            Console.WriteLine("platinum ticket printed");
        }
    }
}
