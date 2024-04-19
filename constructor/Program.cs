 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace constructor 
{
    public class Program
    {
        static void Main(string[] args)
        {

            // constructor is a special type of member function(method,function ,retrun type body ,parameter)
            // constructor is like a method
            // constructor name is like class name
            // constructor does not have return type remaing same as method
            // purpose of constructor is to  initialize class feild.
            //(matlab class feild ke value initialize karane ke liye use karate he)
            /*    
                     *   different types of constructor we can write inside a class 
                      1. parameterless constructor (default constructor):
                       (jab hum class me constructor nahi likhate tab framework by default parameterless contructor \
                         run karata he)(par jab hum explicitly kohi parametrized constructor provide karate
                              tab framework default constructor provide nahi karata)
                      - jab hum object create karenge tab hamara condtructor automatically call hota he
                     2. parameterized constructor:
                        - it is a constructor having a parameters.
                     3. copy constructor:
                        - a constructor which has a parameter of same type like class
                        - perpose of copy constructor is to copy all data from one object to another object.
                     4. static constructor:
                     - purpose is to initialize staic field.
                     5. private or protected constructor:
                      purpose to restrict creating object of the class from outside.

             */

            /*  parameterlessConstructor ss = new parameterlessConstructor();
              parameterlessConstructor sq = new parameterlessConstructor();
              parameterlessConstructor se = new parameterlessConstructor();
              parameterlessConstructor sr = new parameterlessConstructor();

              parameterizedConstructor p = new parameterizedConstructor("ganesh");
              parameterizedConstructor p1 = new parameterizedConstructor("dinesh");
              parameterizedConstructor p2 = new parameterizedConstructor("shailesh");*/
            //student s = new student(10);
            //student s2 = new student();
            ////  s.data("ganesh");
            //teacher d = new teacher();
            //d.print();
            //teacher d1 = new teacher();
            //d.print();
            ////  teachers d2 = new teacher();
            //teachers t= new teachers("suhas","bhosale");
            //t.printA();

            Student s1 = new Student(); 
            s1.Rollnumber = 1;
            s1.Name = "Ganesh Pawar";
            s1.Subject = "Mathematics";

            s1.PrintStudentDetails();


            Console.WriteLine("-------------");

            Student s2 = new Student();
            s2.Rollnumber = 1;
            s2.Name = "Ganesh Pawar";
            s2.Subject = "Mathematics";

            s2.PrintStudentDetails();

            Console.WriteLine("----- using Copy ctor --------");

            Student s3 = new Student(s2);

            s3.PrintStudentDetails();

            Console.ReadLine();
        }

        #region MySpace
        public class student
        {  // fields
            public int id;
            public string name;
            public student()
            {
                Console.WriteLine("parameterless constuctor");
            }
            public student(int a)
            {
                Console.WriteLine($"parameterized constructor{a}");
                id = a;

            }


            public void data(string w)
            {
                Console.WriteLine("i am boss and my id is {0}", id);
            }
        }
        public class teacher
        {
            public int id;
            public string name;

            public teacher()
            {
                id = 1;
                name = "vikul";
            }

            public void print()
            {
                Console.WriteLine($" info.  is : {id} {name} ");
            } }

        public class teachers
        {
            public string firstname;
            public string lastname;

            public teachers(string fn, string ln)
            {
                firstname = fn;
                lastname = ln;
            }

            public void printA()
            {
                Console.WriteLine($" fullnmae is  : {firstname} {lastname} ");



            }
        }

        #endregion MySpace
    }

    public class Student
    {
        public int Rollnumber;
        public string Name;
        public string Gender = "Male";
        public string Subject;

        public Student()
        {
            Console.WriteLine("Normal Paramterless ctor");
        }

        public Student(Student s)
        {
            Console.WriteLine("Copy ctor");
            Rollnumber = s.Rollnumber;
            Name = s.Name;
            Gender = s.Gender;
            Subject = s.Subject;
        } 


        public void PrintStudentDetails()
        {
            Console.WriteLine("Student Details is "+ Rollnumber+" "+Name+" "+Gender+" "+Subject);
        }
    }

}
