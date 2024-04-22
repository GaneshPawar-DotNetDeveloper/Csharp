using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace method_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    
             different types of parameter
            1. pass by value 
            2. ref keyword(reference)
            3. out keyword (out keyword)
            4. params keyword(parameter arrays)
            ** using optional attributes
            1. pass by value:
             --  any change in called method it will not reflect in calling method. 
            2. ref keyword (reference parameter):
             -- Any changes in called method it will be reflect in called method. 
            -- in calling it is mandatory to initialize a value of variable.(int a=10;)
             -- not declaration(int a;)
            -- it is not mandatory to asign value in called method.
            3. out keyword:
              -- Any changes in called method it will be reflect in called method. 
             -- in calling method it is not mendatory to initialize a value of varible.
            -- it is mendatory to assign value in called method.
            4. params keyword:

   */

            // pass by value
            /*  int i = 10;
              print(i);
              Console.WriteLine(i);*/

            int a = 10;
            Program p=new Program();

            p.print(a);
            Console.WriteLine(a);
            // the ourput will be 10, beacuse called method will not refect in calling method
            // so that is pass by value.
            // hum called method ke parameter me jo bhi changes karenge vo called me refect nahi honge.
            // when we want change then we use ref keyword
            // ref keyword:
            int ab = 10; // it is mandatory for ref
                         //  int a; // its not currect in ref keyword
            printA(ref ab);
            Console.WriteLine(ab);
            // ref keyword parameter me hume ref word prameter + argument ke sath use karna padega.
            // out keyword:
            int b = 10; // it is not mendatory initialization
            printB(out b);

            //students s=new students();
            


            //Console.WriteLine(s.name);
            //s.name = "ganesh";

            //Console.WriteLine(s.name);



            students t = new students("priti");

            Console.WriteLine(t.name);
            //Console.WriteLine(students.email);

            Console.WriteLine(b);
            Console.ReadLine();
        }
         void print(int a)
        {
            a = 100;
        }
        static void printA(ref int ab)
        {
            //   ab = 100; // it is not mendatory for ref 
            ab = 23;
        }
        static void printB(out int b)
        {
            b = 100; // it is mendatory for out keyword
        }
    }



     public class  students
    {
        public  string name ;
        string gender;
       public  static string email;
        public students()
        {
            Console.WriteLine(name="Ganesh");
        }

        public students(string name)
        {
            this.name = name;
        }

        static students() {
           Console.WriteLine( email = "suraj");
        
        }


      // private students() { }


        //private students()
        //{
        //    name = "sonu";
        //}




    }

    public class collage
    {

        public void print() {


            //Console.WriteLine(name);
        }

    }
}
