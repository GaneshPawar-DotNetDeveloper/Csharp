using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_String_type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "ganesh";
            Console.WriteLine(name);

            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Count());
            //    Console.WriteLine(name.Replace(  "gkp"));
            // remove etra space
            string value = "         gkp";
            Console.WriteLine(value);
            Console.WriteLine(value.Trim());
            Console.WriteLine(value.TrimStart());
            Console.ReadLine(); 













        }
    }
}
