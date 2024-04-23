using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Optional_method_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ** optional method parameter: jisko argument pass karane ki jarurat nahi he.
            // when we don't want to pass value for a parameter mean we want that parameter will be optional
            // means in main method we wanr run only print() method
            // there are two optional parameters 
            // 1. using default value:
            //  print(); // when we don't parameter value then it get error
            print();  // when we get parameter value as a default value then it get run
            print(20);
            print(30);
            print(123, 123, 123);
            // but we want pass value for a and c then we use named parameter:
            print(a: 23, c: 1234); // it get b value as default value.
            printB();

            Console.ReadLine();
        }
        static void print(int a = 10, int b = 20, int c = 30)
        // optional parameter for default parameter should be last in parameter list.
        // mean don't do that (int a=10,int b);  // it get error
        // we do like (int a,int b= 123);
        {
            Console.WriteLine(a + b + c);
        }
        // 2. using optional atrribute:
        // it use when we don't know default value 
        static void printB([Optional] int j, [Optional]int e, int d=2,int f=23,int g=23)
        {
            Console.WriteLine(d+e+f+g);


            /* ( [Optional] int k,int d=23,int z =12);

             OR

             (int z, [Optional] int k, int d = 23);*/

            //  in first example default value should be last // so it run the code
            // In second example we need to mention argument
            // When we don't do that then we need that value as a optional
















        }
    }
}
