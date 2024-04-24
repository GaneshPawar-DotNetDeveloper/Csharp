using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    internal class static_constructor
    {
      public  int r;
     public  static  float pi ;

        public static_constructor(int r) {

             r=r;
            float pi = 3.14f;
        }
        public void print()
        {
            Console.WriteLine("radius is {0}",pi * r * r);
        }
          
    }
}
