using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodDemo
{
    internal class Program
    {
        static void Main(string[] args)  // calling method
        {
            // method:
            /*
             - it is a block of code
            advantages:
            - readable
            -maintanable
            -scaleble
            -modular
            -reuseable
             ** signature
             *return type + method name+ parameter+{ }

             */
            /*   string fn = "ganesh";
               string ln = "pawar";
               Getfullname(fn, ln);*/
            // getfullname();
            Console.WriteLine("please enter your first name :");
            string fn = Console.ReadLine();
            Console.WriteLine("please enter your last name :");
            string ln = Console.ReadLine();

          //  getfullname(fn, ln);  // method call ke vakt ke parametr ko // method arguments
          string result= getfullname(fn, ln);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        /*static void Getfullname(string fnname,string lnname) 
        {
           // Console.WriteLine("fullname= {0}  {1}",fnname, lnname);
        }*/
        // ***** parameter likhana mendatory nahi he 
       
       /*    static void getfullname() // called method
        {
            Console.WriteLine("please enter your first name");
            string fn= Console.ReadLine();
            Console.WriteLine("plrse enter your last name");
            string ln= Console.ReadLine();
            Console.WriteLine("fullname={0} {1}" ,fn,ln);
        }*/
       //***** method [parameter and method argument]

    /* static  void getfullname (string fn,string ln) // method parameter
        {
            Console.WriteLine("fullname={0} {1}",fn,ln);
        } */
    static string getfullname(string fn, string ln)
        {
            return string.Format("fullname = {0} {1}",fn ,ln );
        }
    }
}
 // we can return with return type 
  // but it can return call to calling method
  // we use multiple different datatype in method parament but it same in both method and argument .
  // main method can always have void .