using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_exmples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // * 1. if else
            int a = 999;
            if (a <= 100)
            {
                Console.WriteLine("A= " + a);

            }
            else
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("rest of part");
            Console.WriteLine("----------------------------");

            // 2. if elese_if ladder :
             
            int mark = 65;
            if (mark < 50)
            {
                Console.WriteLine("you are  fail");

            }
            else if (mark>50 && mark < 60)
            {
                Console.WriteLine("you get D grade ");
            }
            else if(mark>60 && mark <70)
            {
                Console.WriteLine("you get 'C' grade");
            }
            else if(mark>70 && mark < 80)
            {
                Console.WriteLine("you get 'B' grade");
            }
            else if(mark>80 && mark < 90)
            {
                Console.WriteLine("you get 'A' grade ");

            }
            else if(mark>90 && mark < 100)
            {
                Console.WriteLine("you get 'A++' grade");
            }
            Console.WriteLine("------------------------------------");
            // 3. switch statement :
           Console.WriteLine("please put your age ");
            int age;
            int.TryParse(Console.ReadLine(), out age);


            if (age == 0 || age == 100) {
                switch (age) {
                    case 12:
                        Console.WriteLine("you are under 18");
                        break;
                    case 18:
                        Console.WriteLine("you are eligible for voting");
                        break;
                    case 55:
                        Console.WriteLine(" you are sinior citizen");
                        break;
                    default:
                        Console.WriteLine("Invalid data");
                        break;
                } }
            else
            {
                Console.WriteLine("i didin't get your data");
                }
            Console.WriteLine("--------------------");
            Console.WriteLine("please choose number between 1 to 7");
            int number;
            string colour;
            int.TryParse(Console.ReadLine(),out number);
            switch (number)
            {
                case 1:
                    Console.WriteLine("you select red colour ");
                    break;
                case 2:
                    Console.WriteLine("you select pink colour ");
                    break;
                case 3:
                    Console.WriteLine("you select yellow colour ");
                    break;
                case 4:
                    Console.WriteLine(" you select white colour");
                    break;
                    case 5:
                    Console.WriteLine("you select black colour");
                    break;
                case 6:
                    Console.WriteLine("you select blue colour ");
                    break;
                    case 7:
                    Console.WriteLine("you select green colour");
                    break;
                default:
                    Console.WriteLine("you select invalid colour ");
                    break;



            }
            

            












            Console.WriteLine("\n     thank you ");
            Console.ReadLine(); 
        }
    }
}
