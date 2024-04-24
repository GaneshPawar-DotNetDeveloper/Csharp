using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions__Answer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. hume yek method return karana he jo ki array return kare
            //  GetNotnetstudent(); // we can not do that becuse we have a multiple value 
            // so for we ceate a variable and iterate it with hepl of for loop
            /* string[] names = GetNotnetstudent();
             // string[] namesss = names.split(new char[] {','});
              for (int i = 0;  i < names.Length;i++)
              {
                  Console.WriteLine(names[i]);
              }*/

            // ref recall:
            string cname = "dotnet";
            updatecourse(ref  cname);
            Console.WriteLine(cname);
            Console.ReadLine(); 

        }
        /*static string[] GetNotnetstudent()
        {
            string[] names = new string[] { "ganesh", "suraj", "raj", "uday", "padam" }; // it not need 
            // we assume it come from database
            return names;
        }*/
         static void updatecourse(ref string coursenames)
        {
            bool hascoursechange = true;    // from database
            if (hascoursechange)
            {
                coursenames = "python";
            }

        }
    }
}
