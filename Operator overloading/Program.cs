using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 140;
            int k = i + j; 
            // + is a operator && i,j is a operands 
            Console.WriteLine(k);

            string s = "ganesh";
            string l = "pawar";
            string r = s+l;
            // yaha humne in-built oprand ke sath operator use kiya he.
            // iske vajah se hum directly usi type me kar sakate he 

            Console.WriteLine(r);
            // but we have custom type/complex type/class

            calculator c1= new calculator() { number1=10, number2=12};
            calculator c2= new calculator() { number1=20, number2 = 12 };
            calculator c3 = c1 + c2; // +-> operator,c1,c2->operands
            // here it give compile time error because + operator can't understand how to add calculator
            // variables, because in class calculators there as multiple feilds,members.
            // so for these reason/ purpose we can overload + operator.
            
           Console.WriteLine(c3.number1);
            Console.WriteLine(c3.number2);
            // withot create method we can get output 

            /* calculator c4 = new calculator();
             c4.number1 = c1.number1 + c2.number1;
             Console.WriteLine(c4.number1);*/

            // but we have 50 object and suddenly we want to add or change another value then 
            // we go for create another 50 objects
            // so for that we can create opertor overload.
            /* calculator c6 = new calculator() { number2 = 1034 };
             calculator c7 = new calculator() { number2 = 133 };
             calculator c8 = c6 + c7;*/
            // Console.WriteLine(c8.number2);
            Console.ReadLine();
        }
    }
    public  class calculator
    {
        public int number1;
        public int number2;
        public static calculator operator + (calculator c1,calculator c2)
        { 
            calculator c= new calculator();
             c.number1=c1.number1 + c2.number1;
             c.number2= c1.number2 + c2.number2;
            return c;
        }

    }
}
