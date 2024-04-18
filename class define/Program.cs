using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_define
{
    internal class Program
    {
/*
   - we write/declare a class in the namespace.
-   class create with class keyword */
  // class is a template, blue print 
 
        static void Main(string[] args)
        {
            // when we call/use  the class for that we need to create object / instance of that class
            student s1=new student(); // object /instance
            s1.firstname = "ganesh";
            s1.lastname = "pawar";
            s1.printmethod();
            student s2=new  student();
            s2.firstname = "suraj";
            s2.lastname = "pawar";
            s2.printmethod();

            // object initializer syntax:
            student s3 = new student() { firstname = "pruthviraj ", lastname = "pawar" };
            s3.printmethod();

            /*  // without object varible we cant call a method (means without student ke class kis kam ka )
                   student = which type of that variable
                    s1= reference variable because class is reference type
                     new = memory allocator
                   student() = type/value of object means heap memory me kis type kaobject banega, usme kon konse 
                                type ke object rahenge
                     we use dot(.) operator for asign the value for variable


             */

            students s4 = new students()
            {
                firstname = "dhirraj",
                lastname = "salunkhe",
                age = 13,
                city = "solapur"
            };

            s4.printfirstname("ganesh");
            s4.printlastname("pawar");
             





            s4.printstudentdetail();
            Console.WriteLine("====================================");
          //  printFullName("");
            string fn = s4.printfirstname("ganesh");
            Console.WriteLine(fn);









            Console.ReadLine();
        }
    }

    // we create a class 
    public class student
    {
        // in the class there are methods and feild are present 

        // feild 
        public string firstname;
        public string lastname;
        
        // methods 
        public void printmethod()
        {
            Console.WriteLine("FullName =: {0} {1}",firstname,lastname );
        }







    }
}
