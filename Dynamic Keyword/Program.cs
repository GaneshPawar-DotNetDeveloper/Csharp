using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            Console.WriteLine(a);
            object a2 = 10;
            Console.WriteLine(a2);
            var a3 = 10;
            Console.WriteLine(a3);
            dynamic a4 = 10;    
            Console.WriteLine(a4);



            student s = new student();
            s.print();
            object s2=new student();
           // s2.print(); // here object type can access its type 
            // so here we need to cast
            ((student)s2).print();
            
            var s3=new student();
            s3.print();
        //    s3.ganesh(); // we can not do that because ganesh nam ki method he hi nahi.


            dynamic s4= new student();
            s4.print();
            s4.ganesh(); // its nat give error , because its check run time.its throe error at runtime.

            // dynamic use: when we don't know which type of that value we get then dyanamic give at
            // runtime.
            // hume malum nahi he ki o variable kis time ki value dega tab hum check karane ke liye 
            // dynamic use kar sakate he.








            Console.ReadLine();
        }
    }
    public class student
    {
        public void print()
        {
            Console.WriteLine("print method");
        }
    }
}
