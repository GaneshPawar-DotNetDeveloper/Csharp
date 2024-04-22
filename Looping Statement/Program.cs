using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop statement
            //1.while loop
            //2.do while loop
            //3.for loop
            //4.for each loop
            // in looping statement there are three thing 
            // 1. initialization
            // 2. condotion
            // 3. updatation

            // 1. while loop:
            /* Console.WriteLine("mains start");
             int start = 1;   // initialization
             while (start < 5)  // condition
             {
                 Console.WriteLine("hello world");
                 start++;
             }
             Console.WriteLine("mains end");
 */
            // in while loop first check the initializtion then it check condition 
            // when condition is satisfy then it go to while body
            // if condition was false then it not run while body.

            // when we do not give updatation then it iterate infinite
            // because uski value hameshya 1 hi rahegi jo ki kabhi false nahi hogi
            /* Console.WriteLine("------");
             int a = 10;
             while (a <= 1)
             {
                 Console.WriteLine("hello ganesh");
                 a--;
                 Console.WriteLine("------");
             }
            isme condition false hone ki vajah se o hume garranty nahi deta ki o kitani bar 
            return hoga

 */
            /*  int i = 2;
              while (i <= 11)
              {
                  Console.WriteLine($"{i} hiiii");
                  i++;
              }*/
            // Do while loop 
            // syntax:
            //initialization + do { updatation} +condition

            /*  int i = 1;
              do
              {
                  Console.WriteLine("ganesh");
                  i++;
              }
              while (i <= 10);
  */
            /* int a= 1;
               do
               {
                   Console.WriteLine("***");
                   a++;
               }
               while (a <= 0);*/
            // in that example 
            // do while loop they check initialization  then it return do body
            // and then check condition 

            // means do while loop give guranty that it execute once even the condition 
            // is false

            // for loop:
            // syntax:
            // for (initialization + condition + updatation)
            /* for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine("hello world");
             }*/
            // in for loop we can write these three steps in one line code 


            /* Console.WriteLine("mains start"); 
             for(int a = 1; a <= 0; a++)
             {
                 Console.WriteLine("hello bhai");
             }
             Console.WriteLine("mains end");*/
            // break statement :
            // it can use for terminate the loop


            /*  Console.WriteLine("break example");
              for (int w = 1; w <= 5; w++)
              {
                  if (w == 3)
                  {
                      break;
                  }

                  Console.WriteLine($"number {w} ");
              }*/
            /*  Console.WriteLine("start");
  for(int i = 0; i < 10; i++)
              {
                  if (i == 6)
                  {
                      break;
                  }
  Console.WriteLine(i);
              }*/

            // Q. i want terminate loop without using loop 
            // --> assign increment value so condition will become false
            /*  for (int i = 1; i <= 10; i++)
             {
                 if (i == 6)
                 {
                     break;

                 }
                 Console.WriteLine(i);
             }
 *//*
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);

                if (i == 2)
                {
                    i = 5;
                }


            }*/
            // continue statement:
            // it is used to skip current iteration and it continues with
            // next iteration
            Console.WriteLine("--------------");
            for(int i = 0;i<=10;i++)
            {
                if (i == 6)
                {
                    // continue;
                    //break;
                    i = 11;
                
                
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();



        }
    }
}
