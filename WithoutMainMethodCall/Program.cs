using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutMainMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first name");
            string fn = Console.ReadLine();
            Console.WriteLine("please enter your middle name");
            string ml = Console.ReadLine();
            Console.WriteLine("please enter your last name ");
            string ln = Console.ReadLine();
            string result = GetFullName(fn, ml, ln);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static string GetFullName(string fn, string ml, string ln)
        {
            string fullname = string.Format($"FullName = {fn} {ml} {ln}");
            string result = NameToUpper(fullname);
            return result;

        }
        static string NameToUpper(string name)
        {
            return name.ToUpper();
        }

    }// in that case nametoupper method we call in getfullname which as no main method.
}
