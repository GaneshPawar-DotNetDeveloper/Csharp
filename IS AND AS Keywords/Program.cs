using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_AND_AS_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // type casting in case of reference type.

        IA a =new A();
            a.print();
            //  a.printA();  // here we need type conversion.
            A a1=(A)a;  // type casting
            a1.printA();
            // Or
            A a2 = a as A;
            a2.printA();

            C sc=new C();
          //  C c1 = (C)a; // here we can get type cast but it will give runtime error.
            //c1.printC();    
            // so can handle that exception by using 'is' and 'as' keyword.
            if( a is C)
            {
                C c2 = (C)a;
                c2.printC();
                // it will not give exception.
                Console.WriteLine("a is of type C");
             
            }
            else
            {
                Console.WriteLine("a is not of the type C");

            }
            // OR
            C c3 = a as C;
            if (c3 != null)
            {
                c3.printC();
            }
            else
            {
                Console.WriteLine("c3 is null");

            }






Console.ReadLine();
        }
    }

    interface IA { void print(); }
    class A : IA
    {
        public void print()
        {
            Console.WriteLine("print method");
        }
        public void printA()
        {
            Console.WriteLine("printA method");
        }
    }
    class B : IA
    {
        public void print()
        {
            Console.WriteLine("print method");
        }
        public void printB()
        {
            Console.WriteLine("printB method");
        }
    }
    class C {
    public void printC()
        {
            Console.WriteLine("printC method");
        }
    }
}
