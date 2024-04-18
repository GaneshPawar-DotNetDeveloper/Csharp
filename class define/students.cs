using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_define
{
    internal class students
    {    // feilds
        //public string fullname;
        public string firstname;
        public string lastname;
        public int age ;
        public string city;




        public void printstudentdetail()
        {
            Console.WriteLine("----------student detail---------");
            Console.WriteLine("student first name={0}", firstname);
            Console.WriteLine("student last name={0}", lastname);
            Console.WriteLine("student age is :{0}", age);
            Console.WriteLine("student city is :{0}", city);

        }
        public void printFullName()
        {
            Console.WriteLine($"Fullname is: {firstname} {lastname}");
        }
        public string printfirstname( string firstname )
        {
            return firstname;
        }
        public string printlastname(string lastname)
        {
            return lastname;
        }

    }
}
