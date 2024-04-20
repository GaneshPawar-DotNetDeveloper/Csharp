using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // factorial means  6! = 6*5*4*3*2*1 = 720   

           // int i, fact = 1, number;
            Console.Write(" please Enter any Number:\n ");
         double  number = int.Parse(Console.ReadLine());
           double fact =1;
            for (long i = 1; i <= number; i++)
            {
                
                fact =   fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
            Console.ReadLine();
        }

    }
    }

