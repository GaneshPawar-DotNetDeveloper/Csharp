using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   
                       conditional statement
                   1. if statement
                   2. if else statement  //6. nested if
                   3. if else_if else statement
                   4. ternary operators 
                   5. Switch statement

             */
            // 1. if statement :
            /*  Console.WriteLine("mains start here");
              Console.WriteLine("please entr first number");
              int first=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("you enterd :{0}", first);
              // bool codition= first>10 && first<20;
              //  Console.WriteLine(codition); 
              if (first == 10)
                  Console.WriteLine("TEN");
              else
                  Console.WriteLine("not ten");
              Console.WriteLine("mains end here");
              // in that case { } are options when we return single line of code execution

              // ternary opertor :
              // -- use to simplify if_else statement
              // syntax :- (? :)
             /* string result = (first == 10) ? "TEN" : "NOT TEN";
              Console.WriteLine(result);*/
            // in that examople we see that syntax:- (condition)?statement1:statement2;
            // jab condition true hogi to statement1 return kar varana statement2
            /*  int results = (first == 11) ? 11 : 20;
              Console.WriteLine(results);
              string ss = (first == 10) ? "true" : "false";
              Console.WriteLine($"the value is {ss}");
              // nested if:
              Console.WriteLine("lets start the nested if part");
              Console.WriteLine("please enter number");
               int value=int.Parse(Console.ReadLine());
              Console.WriteLine($"passed value is {value}");

              if (value > 10)
              {
                  Console.WriteLine("value is great than ten");

                  if (value > 20)
                  {
                      Console.WriteLine("value is greater than twenty");
                  }
                  else
                  {
                      Console.WriteLine("not greter than twenty");
                  }
                  if (value > 30)
                  { Console.WriteLine("value is greter than thirty"); }
                  else
                  {
                      Console.WriteLine("not greater than thirty");
                  }
              }
              else
              { Console.WriteLine("not greater than ten"); }
              */
            // nested ternary operator =
          /*  Console.WriteLine("hello user ");
            Console.WriteLine("please enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"your enterd number is {number}");*/
            /*   // string nn = (number > 10) ? "greater than 10" : "less than ten";
               *//* string nn = (number > 10) ? ((number > 20) ? "number is greter than 20" 
                    : "not greater than  20" ) :"not greater than 10";
                    Console.WriteLine(nn);
                */
            /*  if (number > 10)
              {
                  Console.WriteLine("number is greater than 10");
                  if (number > 20)
                  {
                      Console.WriteLine("number is greater than 20");
                  }
                  else
                  {
                      Console.WriteLine("number is not greater than 20");
                  }
                  if (number > 30)

                  {
                      Console.WriteLine("number is greater than 30");
                  }
                  else { Console.WriteLine("number is not greater than 30"); }
              }
              else
              {
                  Console.WriteLine("number is not greater than 10");*//*
              }
             // Console.WriteLine(number);
             // in that example they check all if condition and give returns so we want check 
             // only true condition and return that part then we use if else if ladder */
            //string ss = (number > 10) ?





            //
            //  string.  // regular expression

            /*  string qww = "ganesh@123";

          int specialCharIndex =  qww.IndexOf('@');

            Console.WriteLine("Special Char Index is "+specialCharIndex);


           string FinalOutput1 = qww.Substring(specialCharIndex+1);
            string FinalOutput2 = qww.Substring(0,specialCharIndex);

           
            

            char[] charArray = new char[] { 'g', 'a', 'n', 'e', 's', 'h'};

            qww.TrimStart('g', 'a', 'n', 'e', 's', 'h');


            Console.WriteLine("Final Output 1 "+ FinalOutput1);
            Console.WriteLine("Final Output 2 " + FinalOutput2);


            Console.WriteLine("-------------------------------------");

            string ex = "Akshay,Ganesh,Dhiraj";

           string[] names = ex.Split(',');

            foreach(string ga in names)
            {
                Console.WriteLine(ga);
            }*/




            // if else_if
          /*  if (number == 10)
            {
                Console.WriteLine("value is ten ");

            }
            else if (number == 20)
            {
                Console.WriteLine("value is 20");
            }
            else if (number == 30)
            {
                Console.WriteLine("number is 30");

            }
            else
                Console.WriteLine("number is not 10,20,30");
*/
          // switch statement :
          /* switch (number)
            {
                case 10:
                    Console.WriteLine("TEN");
                    break;
                    case 20:
                    Console.WriteLine("TWENTY");
                    break;
                    case 30:
                    Console.WriteLine("THIRTY");
                    break;
                    default:

                    Console.WriteLine("NOT 10,20,30");
                    break;*/
                    // break statement we can use for terminate switch block
                    // if one case match then not check to another case
                    // case is a condition


           // }
           // ex :
          /* Console.WriteLine("hello user");
            Console.WriteLine("please enter your name");
            string names = Console.ReadLine();
            *//* switch (names)*//*
             {
                 case "ganesh":
                     Console.WriteLine("solapur");
                     break;
                 case "kishor":
                     Console.WriteLine("dharashiv");
                     break;
                 case "ajay":
                     Console.WriteLine("madhya pradesh");
                     break;
                 default:
                     Console.WriteLine("maharashtra");
                     break;
                     Console.WriteLine(" !!! thank you visit again !!!");
             }
 */
            // we can merge the case statement 
          //  switch (names.ToUpper())
        /*  switch (names.ToLower())
            {
                case "GANESH":
                case "suraj":
                case "RAJ":
                    Console.WriteLine("solapur");
                    break;
                case "AKSHAY":
                case "ABHISHEK":
                case "SHUBHAM":
                    Console.WriteLine("pune");
                    break;
                default:
                    Console.WriteLine("latur");
                        break;
                    Console.WriteLine($"welcome to our club {names}");*//*
                    // this line can't because there are break statement 
                    // when we have some conditions then and then only we use statements

            }*/
            Console.WriteLine("please enter your number");
            int num;
            if (int.TryParse(Console.ReadLine(),out num))
            {
Console.WriteLine("conversion succefull");

            }
            else
            {
                Console.WriteLine("conversion faild");
            }



            object ss = 10;
            float a = (float)ss;    // exception inhandle 
            // we see in inheritance
            // here object is a parent and float is a child so parent to child is not possible 
            Console.WriteLine(a);


            Console.ReadLine();
        }
    }
}
