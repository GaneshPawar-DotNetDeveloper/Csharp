using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.inheritance
{
   public  class GoldCustomer : Customer
    {
      //  public int ticketAmout;

    public GoldCustomer()
        {
            ticketAmout = 250;
        }
        //public void Showtiming()
        //{
        //    Console.WriteLine("## All todays timing");
        //}
        //public void GettiketAmout () {
        //    Console.WriteLine($"Ticket Amount is : {ticketAmout}");
        //}
        public void PrintTicket()
        {
            Console.WriteLine("gold ticket printed\n");
        }
    }
}
