using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.calculator;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*     // without generic
                 calculator sc = new calculator();
             //  bool ra=  sc.print(10, 10);
               bool ra=  sc.print(10, "ganesh"); // there is no meaning of that compare so here we want to use generic.
                 Console.WriteLine(ra);
                 Console.ReadLine();*/

            /*     // with generic
                 calculator sc= new calculator();
           //  bool sw=sc.print<int>(10, 10);
             bool sw=sc.print<string>("ganesh", 10);
                 Console.WriteLine(sw);
                 Console.ReadLine();*/

            calculators<int> sc = new calculators<int>();
            bool sr = sc.print(10, 24);
            Console.WriteLine(sr);
            Console.ReadLine();

              calculators<int> sc1 = new calculators<int>();
            bool sr1 = sc.print(10, 24);
            Console.WriteLine(sr1);
            Console.ReadLine();

        }
    }

    // without generic:
    /*  public class calculator
      {
          public bool print (object a,object b)
          {
              return a.Equals(b);
          }
      }*/


    public class calculator
    {
        public bool print<t>(t a, t b)
        {
            return a.Equals(b);
        }


        // class as a generic
        public class calculators<T>
        {
            public bool print(T a,  T b)
            {
                return a.Equals(b);
            }
        }
    }
}
