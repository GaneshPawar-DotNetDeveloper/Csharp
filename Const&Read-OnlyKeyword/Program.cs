using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Read_OnlyKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student sc= new student();
            sc.Firstname = "ganesh";
            sc.Lastname = "pawar";
            //  sc.institute = "ABC";
            // here institute name will be change 
            // but we need to commom indstitute
            // then for that we can use const keyword 
            // const= No one can change its value.
            //  Console.WriteLine(sc.institute); // it give error because we don't need to call const
            //  value because it's bydefault static.
            // so static feild call karane ke liye hume class name se call karana padega.
            Console.WriteLine(student.institute);


            teacher ss= new teacher();

            ss.Firstname = "suraj";
            ss.Lastname = "pawar";
            //  student.institute; // it give error because readonly is not bydefault static
            //  so we can make static or can access by variable.
            Console.WriteLine( ss.institute); 


            Console.ReadLine();
        }
    }
    public class student
    {
        public string Firstname;
        public string Lastname;
       // public string institute = "V# Tech";
     //   public const string institute; // it is menndatory to declare const value.

       public const string institute = "V# Tech";
    } 
    public class teacher
    {
        public string Firstname;
        public string Lastname;
        public readonly string institute;
        // in readonly there are declaration is not mendatory.

    }
}
