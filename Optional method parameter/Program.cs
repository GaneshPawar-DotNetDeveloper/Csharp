using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Optional_method_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(12, 34);
            add(23);
            add();
            sub(23, 45);
            sub(10);
            sub();
            sum(12,12,12);
            //sum(12, 12);
            sum(a: 12, c: 12);
            Console.ReadLine();
        }
        static void add(int a =27, int b=92) 
        { 
        Console.WriteLine($"Addition {a}+{b}= {a + b}");
        } 
        //2. optional atrribute parameter
        static void sub([Optional]int a, [Optional] int b)
        { 
        Console.WriteLine($"Substraction : {a}-{b}={a-b}");
        }
        //3.named parameter
        static void sum (int a,[Optional]int b,int c)
        {
            Console.WriteLine($"sum is {a}+{b}+{c}={a+b+c}");
        }
            }
        }
