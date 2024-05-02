using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student(); // this is the object/ instance of student class
            s.id = 1;
            s.name = "ganesh";
            s.age = 24;
            s.age = 12;
            Console.WriteLine(s);





            Console.ReadLine();
        }
    }
    class student  // student is type of class type
    {
        public int id;
        public string name;
        public int age;// these are the fields/members of the class
    }
}

