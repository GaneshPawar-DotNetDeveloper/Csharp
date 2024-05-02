using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.inheritance
{
    // this child class / derived class
    public class SilverCustomer : Customer // this is a class
    {
       // public int tiketAmout;// this is feild

        public SilverCustomer() // this is a constructor
        {
            ticketAmout = 150;
        }

        //public void ShowsTiming() // method 1
        //{
        //    Console.WriteLine($"@@ all todays shows");
        //}
        //public void GetTiketAmout() // method 2
        //{
        //    Console.WriteLine($"the total tiket amout is {tiketAmout}");
        //}

        public void Printtiket() // method 3
        {
            Console.WriteLine("silver tiket prented\n");
        }
    }
}
