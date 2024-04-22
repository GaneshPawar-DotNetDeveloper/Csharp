using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  A a = new A();
            a.print();

            B be = new B();
            be.print();*/
            A bd= new B();
            bd.print();

            Console.ReadLine();
        }
    }
    public class A
    {
        public virtual void print()
        {
            Console.WriteLine("A");
        }
    }
    public class B :A
    {
        public override void print()
        {
            Console.WriteLine("B");
        }
    }
}
