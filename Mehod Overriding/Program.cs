
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehod_Overriding
{

    // purpose of overriding :
    // base class object variable reference to dirived class object will called derived class method.
    // method overriding is a runtime polymorphism.(jab hum derived class me method nahi likhate tab
    //  compliler hume error nahi deta tab vo base class ki method call karata he so that is reason)
    //
    //  roles for method overriding:
    // 1. derived class method start with override keyword
    // 2. base class must start with 'virtual' or 'abstract' or 'override'
    internal class Program
    {
        static void  Main(string[] args)
        {
            /* Employee a = new Employee() { firstname = "suraj", lastname = "pawar" };
             a.Printfullname();
             Employee a1 = new FullTimeEmployee() { firstname = "ganesh", lastname = "pawar" };
             a1.Printfullname();
             FullTimeEmployee a2 = new FullTimeEmployee() { firstname = "raj", lastname = "pawar" };
             a2.Printfullname();
             PartTimeEmployee a3 = new PartTimeEmployee() { firstname = "dhiraj", lastname = "salunkhe" };
             a3.Printfullname();*/
            Employee a = new PartTimeEmployee() { firstname = "suraj", lastname = "pawar" };
            a.Printfullname();
            Employee a1 = new FullTimeEmployee() { firstname = "ganesh", lastname = "pawar" };
            a1.Printfullname();
            Employee a2 = new Contractor() { firstname = "dhiraj", lastname = "salunkhe" };
            a2.Printfullname();

            // so in that case they print base class method because of method overloading
            // but i want to print dirived class method so for that we can use method overriding.
            // so for that we need to mark that method as a override there.
            Console.ReadLine();

            // virtual keyword:
            // - virtual Keyword simply tells that this method can be override in derived class
            // - not memdatory that we need to override that method 
            // - virtual method body - virtual method is very simmiler to your normal method.
            // 
            // override keyword :
            // jab hamare pass multilevel hararchy inheritance ho , or usme hume method override karana
            // ho tab us base class ke method me override keyword likhana padata he.


        }
    }
    public class Employee
    {
        public string firstname;
        public string lastname;
        public virtual void  Printfullname()
        {
            Console.WriteLine($"fullname is: {firstname} {lastname}");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public int salary;
        public override void Printfullname()
        {
            Console.WriteLine($"fullname of fulltimeemployee is : {firstname} {lastname}");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public int hourlysalary;
        public  override void Printfullname()
        {
            Console.WriteLine($"fullname of parttimeemployee is : {firstname} {lastname}");
        } }
        public class Contractor : Employee
        {
            public int percentage;
            public new void Printfullname()
            {
                Console.WriteLine($"fullname of contractor is : {firstname} {lastname}");
            }
        }
    }

