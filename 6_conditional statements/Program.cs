using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            condittional statement 

              - its control flow of program 
              - in conditional statement we have 

               1. if statement 
               2. if_else statement
               3. if_else if_else ladder
               4. ternary operator
               5. nested if statement
               6. switch statement 
    */
            // if statement
            int i = 11;
            // int i = 0;
            if (i == 10)
            {

                Console.WriteLine($"{i}: TEN");

            }
            // in that example when condition was wrong then output we be blank
            // so for that we use

            // if _else statement

            int ia = 12;
            if (ia == 10)
            {
                Console.WriteLine($"{ia} : TEN");

            }
            else
            {
                Console.WriteLine($"{ia}:NOT TEN");
            }

            // ternary operator
            // ?:
            // syntax- (condition) ? statement1 : statement2 ;

            int a = 12;
            string result = (a == 10) ? "TEN (10)" : "NOT TEN(!10)";
            Console.WriteLine($"{a}:{result}");


            /*  bool w = false;
              string as = (w == true) ? "not" : "yes";
              Console.WriteLine(as);
            why they not get as as variable
             */
            bool w = false;
            string aw = (w == true) ? "not" : "yes";
            Console.WriteLine(aw);

            // if_else if ladder
            a = 10;
            // a = 50;
            //a = 30;
            if (a == 10)
            {
                Console.WriteLine($"{a}:TEN");
            }

            else if (a == 20)
            {
                Console.WriteLine($"{a}: TWENTY");
            }
            else if (a == 30)
            {
                Console.WriteLine($"{a}: THIRTY");
            }
            else
            {
                Console.WriteLine($"{a} : not 10 20 or 30 ");
            }




            Console.ReadLine();

            // switch statement

            i = 10;
            switch (i)
            {
                case 10 :

                    Console.WriteLine($"{i}:TEN");
                    break;
                case 20:
                    Console.WriteLine($"{i}:TWENTY");
                    break;
                    case 30:
                    Console.WriteLine($"{i}:THIrty");
                    break;
                    default :
                    Console.WriteLine($"{i}: Not 10 20 ");
                    break;



            }




        }
    }
}
/*Console.WriteLine("please enter a frist number");
int frist = int.Parse(Console.ReadLine());
Console.WriteLine("please enter a second number");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("please inter operation : + or - or * or /");
char operation = char.Parse(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine($"Addition{frist}+{second}={frist + second}");
        break;
    case '-':
        Console.WriteLine($"substraction{frist}-{second}={frist - second}");
        break;
    case '*':
        Console.WriteLine($"multiplication{frist}*{second}={frist * second}");
        break;
    case '/':
        Console.WriteLine($"dividation{frist}/{second}={frist / second}");
        break;
    default:
        Console.WriteLine($"Invalid Operation");
        break;
}
Console.WriteLine("Thank you visit again !!!!");
Console.Read();



        }
    }
}
*/