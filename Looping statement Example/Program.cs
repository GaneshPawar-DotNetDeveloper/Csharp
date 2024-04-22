using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_statement_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. for loop ()
            for(int i=0; i <= 10; i++)
            {
               // Console.WriteLine(i);
             Console.Write(i);  
            }
            Console.WriteLine("------------------------------");

            // while loop :- if we know the number of iteration in advance 
            // do while :- ayleast one step if i want to execute the code without checking condition
            //2.
            for (int i = 1; i <= 10; i++)
            {
                int b = 2 * i;
                Console.WriteLine(b);
            }
            Console.WriteLine("--------------------------------");
//3.
            int num;
            for(int i= 1; i <= 10; i++) {
                for (int j = 2; j <= 10; j++)
                {
                    num =  j *i ;
                    Console.Write(num+ " ");
                }
                    Console.WriteLine();
            }
            Console.WriteLine("-------------------------");

            // 4.
            for (int ab = 1; ab <= 10; ab++) // -- that for loop for count rows
            {
                for (int b = 1; b <= ab; b++) // -- second for loop column count 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                Console.WriteLine("-----------------------------");
            // in for loop two condition are important 1. x axis 2. y axis , x for first for loop
             // y axis for second for loop (+  - that for x, | that for y)
             //5.
            Console.WriteLine("Enter how many rows you want to print");
            int row;
           int.TryParse(Console.ReadLine(), out row);
            for(int ac = 1; ac <= row; ac++)
            {
                for(int b = 1; b <= ac; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
            //6. pyramid code:
            for(int i = 0; i<20; i++)
            {
                for(int k=20-i; k > 1; k--)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine("-------------------");
            // 7. while loop
            int a = 1;
            while (a <= 10)
            {
                int b = 5 * a;
                Console.WriteLine(" " + b);
                a++;
            }
            Console.WriteLine("--------------------------------");
            //8.
            int x = 1;
            do
            {
                int y = 10 * x;
                Console.WriteLine(" " + y);
                x++;
            } while (x <= 10);
            Console.WriteLine("---------------");
            //9.infinite ex.
            /* int q = 10;
             while (q > 5)
             {
                 q += 10;
                 Console.WriteLine( q);
                 q++;
             }*/
            // Console.WriteLine("------------");
              //10.
               int w = 1;
               while (w <= 5)
               {
                   int e = w + 1;
                   Console.WriteLine(" " + e);
                   w++;
                     }
                   Console.WriteLine("--------------------------");

            // 11.
            int r = 1;
            do
            {
Console.WriteLine(" " + r);
                r++;
                
            }while(r <= 10);
            Console.WriteLine("--------------");
            //12.break 
            int d = 1;
            while(d <= 10)
            {
                if (d == 4)
                {
                    break;
                    //continue
                }
                Console.WriteLine(d);
                d++;
            }
            Console.WriteLine("--------------------");
            //13.























            Console.ReadLine();
        }
    }
}
