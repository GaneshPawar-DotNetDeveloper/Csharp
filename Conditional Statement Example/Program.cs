using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement_Example

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Print "Hello World" if x is greater than y
            //  int x=30, y=20;
            /* if (x > y)
             {
                 Console.WriteLine("hello world");
             }
             else
             {
                 Console.WriteLine("hello ganesh");
             }*/
            // with ternary operator:
            //string ss = (x > y) ? "hello world" : "hello ganesh";
            //Console.WriteLine(ss);
            //2. case statement
            /* Console.WriteLine("welcome to coding world");
             Console.WriteLine("please enter day number ");
             int day = Convert.ToInt32(Console.ReadLine());
             switch (day)
             {
                 case 1:
                     Console.WriteLine("Monday");
                     break;
                 case 2:
                     Console.WriteLine("Tuesday");
                     break;
                 case 3:
                     Console.WriteLine("Wednesday");
                     break;
                 case 4:
                     Console.WriteLine("Thursday");
                     break;
                 case 5:
                     Console.WriteLine("Friday");
                     break;
                 case 6:
                     Console.WriteLine("Saturday");
                     break;
                 case 7:
                     Console.WriteLine("Sunday");
                     break;
                 default: 
                     Console.WriteLine("you enter invalid number");
                     break;

             }*/
            // 3.
            /*   Console.WriteLine("welcome to ODD-EVEN WORLD");
               Console.WriteLine("please enter a num");


               int num;

               bool isNumber = int.TryParse(Console.ReadLine(), out num);

               if (isNumber)
               {



                   //int num = int.Parse(Console.ReadLine());
                   if (num % 2 == 0)
                   {
                       Console.WriteLine($"{num} is even number");

                   }
                   else
                   {
                       Console.WriteLine($"{num} is odd number");
                   }
                   Console.WriteLine("thank you ");
                   // when i put as a  xyz string value then it give format exception then how solve it
               }
               else
               {
                   Console.WriteLine("Please input numbers only");
               }*/
            // object can convert into derived type 
            // 
            // object dd = new {Name= "Akshay"};
            /*  object dd = 10;  
              byte b = Convert.ToByte(dd);
              Console.WriteLine(b);
              Console.ReadLine();*/

            Console.WriteLine("Enter a number to check grade:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }
        else
            {
                Console.WriteLine("invalid grade ");
            }
            Console.WriteLine("thank you");
            Console.ReadLine(); 

    
}
    }
}
