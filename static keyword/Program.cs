using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // static means single copy
            // ehenever there is class member which is not object specifier
            // static ke vajah se memory management ho jayega.
            // non - static field ko hum instance bhi bol sakate he.
            student s = new student("ganesh","pawar");
            s.print();
          //  Console.WriteLine(s.trainername);
            Console.WriteLine($"traner name is : {student.trainername}");
            student s2 = new student("mahesh", "pawar");
            s2.print();
           // Console.WriteLine(s2.trainername);
            Console.WriteLine(student.trainername);



            Console.WriteLine("------------------------------");
            area_of_circle v = new area_of_circle() { radius=12};
            v.area();
            Console.WriteLine(area_of_circle.Circle());

            Console.WriteLine("------------------------");
            static_constructor sc= new static_constructor(23);
            sc.printa();
           

            Console.ReadLine();

        }
    }
}
