using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CLASS
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            //Student s1 = new Student("Akshay");
            //s1.Method_StudentDetails();

            string name = null;

            int salary = 600000;

            Console.WriteLine(salary);

            //s1.id = 101;
            //s1.name = "ganesh pawar";
            //Console.WriteLine(s1.id);
            //Console.WriteLine(s1.name);


            

            //simple sw = new simple();
          //  sw.Main1();

            //static void Main(string[] args)
            //{
            //    int id = 23;
            //    string name = "ganesh";
            //    // string age = "23";
            //    Console.WriteLine(id);

            //    Program s1 = new Program();
            //        s1.id = 101;
            //        s1.name = "ganesh pawar";
            //        Console.WriteLine(s1.id);
            //        Console.WriteLine(s1.name);

            Console.ReadLine();
        }
    }

    class Student  // Class
    {

        // ------- Fields

        public int id;
        public string name;

        // ------- Constructor -----

        // Automatically get called whenever you create the instance/Object of the class
        // Constructor is having same name as of CLASS name
        // Ctor - is used to initialize class fields.

        //public Student()
        //{
        //    Console.WriteLine("Ctor get called automatically");
        //}

        //public Student(string name)
        //{
        //    this.name = name;
        //}

        //------------- Method -------

        //public void Method_StudentDetails()
        //{
        //    Console.WriteLine("Student Name is " + this.name);
        //}

        // --------- Property ----------

        // public int Id { get; set; }

        //----------------- Indexer ---------

        //public string this[int id]
        //{
        //    get
        //    {
        //        return "Akshay";
        //    }
        //}

        //--------- Destructor --------

        //~Student() { }




    }
}


