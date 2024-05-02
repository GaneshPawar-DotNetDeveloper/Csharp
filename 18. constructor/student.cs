using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.constructor
{
    public class student
    {
         public int rollnumber;
        public string firstname;
        public string lastname;

        public void detail()
        {
            Console.WriteLine($"rollnumber is :{rollnumber} first name is : {firstname} " +
                $" last name is :{lastname}");
        }
        public void Initialization(int rn,string fn,string ln)
        {
            int rollnumber=rn;
            firstname=fn;
            lastname=ln;
        }
        public student()
        {
            Console.WriteLine("student() constructor called");  
        }
    }
}
