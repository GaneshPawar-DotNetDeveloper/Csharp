using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodWithReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  print("null", "pawar");
            //print("ganesh","pawar");
            print("ganesh",null);

            Console.ReadLine();
        }
static void print(string s,string s1)
        {
            if (string.IsNullOrEmpty(s)){
                return;
            }
            Console.WriteLine($"you entered : {s} {s1}");
        }


    }
}
