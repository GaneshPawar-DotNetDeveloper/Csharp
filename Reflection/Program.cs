using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* student student = new student();
             student.print("ganesh", "pawar");*/

            // so when  student type is not available at compile time then it 
            // not pissible to access that method.
            // for that we can use reflection 
            // refection all related classes are present in system.reflection namespace

        Assembly  as  =    Assembly.GetExecutingAssembly(); // it returns assembly object

            Console.ReadLine(); 
        }
    }
   /* // this is the early binding:

    public class student
    {
        public void print (string a , string b)
        {
            Console.WriteLine($"{a}  {b}");
        }
    }*/

    // but i want this type can available at runtime 
}
