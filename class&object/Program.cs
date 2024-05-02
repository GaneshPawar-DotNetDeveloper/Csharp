using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student(); // this is the object/ instance of student class
            s.id = 1;
            s.name = "ganesh";
            s.age = 24;// s.name = "ganu";
           // s.age = 12;
           // s.age = 233;
            Console.WriteLine($" id is {s.id}\n name is {s.name}\n" +
                $" age is {s.age} ");
            s.ss();
            student s2=new student();
            s2.name = "ganu";
            s2.age = 12;
            s2.id = 2;
            Console.WriteLine(s2.id); Console.WriteLine(s2.age); Console.WriteLine(s2.name);
            Console.WriteLine(s2.age);
            s2.ss();
            circle cc = new circle();
            cc.radius = 10;
            cc.pi = 3.14f;
            cc.area();

            cc.radius = 5;
            cc.area();


            Console.ReadLine();
        }
    }
    class student  // student is type of class type
    {
        public int id;
        public string name;
        public int age;// these are the fields/members of the class

        // inside the class we can write a member functions/methods
        public void ss()
        {
            Console.WriteLine($"{id} {name} {age}");
        }
    }
}

