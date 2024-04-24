using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    internal class student
    {

        string firstname;
        string lastname;
       public static string trainername ="vikul";
        public student(string fn,string ln) { 
         
            firstname = fn;
            lastname = ln;
        
        }
      public void print()
        {
            Console.WriteLine($" fullname : = {firstname} {lastname}");
        }
    }
}
