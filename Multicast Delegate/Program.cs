using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Multicast_Delegate
{


    public delegate void printdelegate();
    internal class Program
    {
        static void Main(string[] args)
        {

            printdelegate del = printA;
         
            printdelegate del2 = printB;
          
            printdelegate del3 = printC;

            printdelegate d= del + del2+ del3;

            d();
            printdelegate d2= d- del;
            d2();



            Console.ReadLine();

        }

        static void printA()
        {
            Console.WriteLine("A");
        }
        static void printB()
        {
            Console.WriteLine("B");

        }
        static void printC()
        {
            Console.WriteLine("C");
        }
    }
}
