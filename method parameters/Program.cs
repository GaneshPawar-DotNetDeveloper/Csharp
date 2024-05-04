using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_parameters
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a =10;
            printA(a);
            Console.WriteLine(a);
            printB(ref a);
            Console.WriteLine(a);
            int bc;
            printC(out bc);
            Console.WriteLine(bc);
            Console.ReadLine();     
        }
        //1. pass by value 
        static void printA(  int  ba)
        {
            ba = 100;
        }
        //2. pass by ref 
      static void printB (ref int b)
        {
           // b = 10000;
        }
        //3. out keyword
        static void printC( out int c)
        {
            c = 2344;
        }
    }
}
