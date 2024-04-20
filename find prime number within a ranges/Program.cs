using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_prime_number_within_a_ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("find prime numbers wthin two numbers");
            Console.WriteLine("please enter first number");
            int nu;
            bool firstnumber = int.TryParse(Console.ReadLine(), out nu);
            Console.WriteLine("please enter last number ");
            int num;
            bool lastnumber=int.TryParse(Console.ReadLine(),out num);
            Console.WriteLine("the prime mumbers between {0},{1} is :",nu,num);
            int number;
            for(number = nu; number <= num; number++)
            {
                int counter = 0;
                {
                    for(int i = 2; i <= number / 2; i++)
                    {
                        if(number%i== 0)
                        {
                            counter++;
                            break;
                         }
                    }
                    if(counter ==0 &&number!=1)
                    {
                        Console.Write
                            
                             (number);
                             

                    }







                    Console.ReadLine();



                }
            }

        }
    }
}
