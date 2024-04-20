using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSubmissionAppliction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // is example me hume na pahile humne mobile number dala then we enter adhar number so when
            // we enter wrong adhar number then it repeate all proccess from start 
            // so we want do while work from recent wrong part .

            Console.WriteLine(" \n\n             ***HELLO OFFICER ***\n\r");
            Console.WriteLine("        Welcome to UPSC LOGIN\n");
            Console.WriteLine("please enter your registered mobile number ");
            int num; int word; int sum;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num.ToString().Length == 10)
                {


                    Console.WriteLine("you enter correct mobile number ");
                    Console.WriteLine("This question is for testing whether or not you" +
                        " are a human visitor and t=o prevent automated spam submissions.\r\n\r\n");
                    Console.WriteLine("maths Question : 10+20=  ");
                    Console.WriteLine("Solve this simple math problem and enter" +
                        " the result. E.g. for 1+3, enter 4.\r\n\r\n");
                    sum = int.Parse(Console.ReadLine());
                    if (sum == 30)
                    {
                        Console.WriteLine("confirmed you are not robot");
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong answer");
                    }
                }
            }
            else
            {
                Console.WriteLine("you enter wrong mobile number");
            }














            Console.ReadLine();
        }
    }
}

           


        
