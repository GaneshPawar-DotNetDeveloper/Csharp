using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_pillar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this keyword points a current instance
   student se= new student ("ganesh","pawar"); // we give parameter so there are mendatory to give value
                                               // in argument.
                                               // static ko hum this use nahi kar sakte
                                               // kyuki static ko object specific nahi hota

            se.print();


            Console.ReadLine();

        }
    }
    public class student
    {
      string firstname;
        string lastname;
     public   student(string firstname, string lastname)
        {
          this. firstname = firstname;
        this.  lastname = lastname;
        }
        public void print()
        {
            Console.WriteLine($"fullname : {firstname} {lastname}");
        }



    }
}

