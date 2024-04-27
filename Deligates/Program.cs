using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void DeligatesDelegate(string c);
    
   

    internal class Program
    {

        static void Main(string[] args)
        {
            /* Program.printA("ganesh");
             Program.printB("ganesh", "pawar");*/

            // so here we call delegate for that we create object of delegate
            DeligatesDelegate del = new DeligatesDelegate(printA);
            del("suraj pawar");
            // second way we can declare delegate.

            DeligatesDelegate dil = printA;
            dil("raj pawar");



            printA("ganesh");
            printB("ganesh", "pawar");

            // so here i wantto call PrintA method as a parameter 0f printB method.
            // so for that we can use deligate.

        }
            static void printA(string s)
            {
                Console.WriteLine(s);
            }
            static void printB(string A,string B)
            {
            Console.WriteLine($"{A}  {B}");
        }



        }
    
}
