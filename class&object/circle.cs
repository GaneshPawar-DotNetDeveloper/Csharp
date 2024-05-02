using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    internal class circle
    {
        public int radius;
        public float pi;

        public void area()
        {
            Console.WriteLine($"area of circle is ={pi * radius * radius}");
        }
    }

}
