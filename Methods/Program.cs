using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)  // calling method
        {
            printA();
            printB("ganesh"); // ganesh is argument
            string village = "Ankoli";
            printB(village);
            printC("ganesh", "pawar");
            string firstname = "suraj", lastname = "pawar";
            printC(firstname, lastname);
            string result=printD("raj","pawar");
            Console.WriteLine($"printD : fullName = {result}");
            printE(true);
            Console.ReadLine();
        }
        // method without return without parameter
        static void printA() // called method 
        {
            Console.WriteLine("printA : method called");

        }
        //2. method without return with parameter
        static void printB(string name) // name is method parameter
        {
            Console.WriteLine($"printB : hello:{name}");
        }
        //3. without return with multiple parameter
        static void printC(string fn,string ln)
        {
            Console.WriteLine($"printC : fullName= {fn} {ln}");
        } 
        //4.with return with parameter
        static string printD (string fn,string ln)
        {
            return fn+" "+ln;
        }
        // why we use return statement with void return type

        static void printE(bool isconfirmed)
        {
            if (!isconfirmed)
            {
                return;
            }
            Console.WriteLine($"printE : {isconfirmed} : session allowed");
        }
    }
    }
