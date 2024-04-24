using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Of_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print();
            //print("ganesh");
            Console.WriteLine();

            Console.ReadLine();
        }

        // 1.number of parameter:
        static void print(int i) { }

        static void print(int i, int j) { }

        // 2. type of parameter:
        static void print(string j) { }

        static void print(float j) { }

        // 3. order of parameter:
        static void print(string j, float s) { }

        static void print(float s, string j) { }

        // 4.kinds of parameter:
        // methods are separeted on the basis of ref and out keyword with input parameter.
        static void print(double j) { }

        static void print(ref double j) { }

        // when method overloading is not possible:
        //1. just on return Type
        //static int print() { return 10; }
        //static float print() { return 23; }

        // just on ref and out:
        //static void print(ref int i) { }
        //static void print(out int i) {  i= 23; }

        // just on params keyword:
        //static void print (int[] a){}
        //static void print (params int[] a){}
        
    }
}

