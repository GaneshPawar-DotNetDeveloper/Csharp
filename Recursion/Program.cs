using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // int result = factorial(10);
            int result = factorial2(10);
            Console.WriteLine(result); ;




            Console.ReadLine(); 

        }
        /*static int factorial(int num) // for loop
        {
            int fact = 1;
            for(int i=  1; i <= num; i++)
            {
              fact=  fact *= i;
            }
            return fact;
        }*/

        // using recursion:

        static int factorial2(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num*factorial2(num-1);
        }


    }
}