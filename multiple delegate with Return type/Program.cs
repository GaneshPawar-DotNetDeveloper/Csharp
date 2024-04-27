using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_delegate_with_Return_type
{

    public delegate string printDelagateMethod();
    internal class Program
    {
        static void Main(string[] args)
        {
            printDelagateMethod sc = printA;
            printDelagateMethod sc1 = printB;
            printDelagateMethod sc2 = printC;

            printDelagateMethod s = sc + sc1 + sc2;

            /*  string result = s();
              Console.WriteLine(s);
  */
            // so here problem is when we use multicast delegate woth return type that time it can return last value
            // so for that we can use getInvoctionList().
            delegate[] delegates = s.GetInvocationList();
            for (int i = 0; i < delegates.Length; i++)
            {
                var sol = ((printDelagateMethod)delegates[i]).Invoke(); // corrected the typo here
                Console.WriteLine(sol);
            }


            Console.ReadLine();
        }
        static string printA()
        {
            return "A";
        }
        static string printB()
        {

            return "B";
        } static string printC()
        {
            return "C";
        }
    }
}
