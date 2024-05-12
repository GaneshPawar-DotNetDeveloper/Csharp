using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student sc= new student();
            // sc.print();
          //  student.print();
           // student.print();

            student sc1 = new student();
            sc1.print();
            // sc1.printA();
            sc1.printA("hello");

            // here i want length of that string
            string s = "ganesh";
        int len=    s.mystringlength();
            Console.WriteLine(len);

            Console.ReadLine();
        }

       
    }
    public class student
    {
       // public void print()
        public  void print()
        {
            Console.WriteLine("print method called");
        }
    }

    // yaha muze student class me koi change n karate usme or frature add karane he ,
    // to uske liye me inheritnce use kar sakata hu,but jab student class sealed hoga to me vo nahi kar paunga,
    // so for that we use extension method.
   /* public static  class studentHelper
    {
        public static void printA(this student s)
        {
            Console.WriteLine("printA method called");
        }
    }*/
    public static  class studentHelper
    {
        public static void printA(this student s,string message)
        {
            Console.WriteLine("printA method called");
        }


        public static int mystringlength(this string s)
        {
          return  s.Length;
        }
    }

}
