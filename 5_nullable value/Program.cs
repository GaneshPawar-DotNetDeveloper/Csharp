using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_nullable_value
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* string name = "ganesh" + "   "
                  + "pawar ";
             Console.WriteLine(name);
 */
            string names = null;
            Console.WriteLine(names);

            //int age = null;
            // Console.WriteLine(age);

            // that values are non nullable values 
            // so to make that value as a nullable so we use ?
            // 1. ?
            int? age = null;
            Console.WriteLine(age);

            // nullable is also a class so we use 
            Nullable<int> ab = null;
            Console.WriteLine(ab);

            int? c = 10;
            int b = (int)c;
            Console.WriteLine($"c: {c} b : {b}");

            // 2. ??
            int? a = null;
            // int? a= 10;
            //int d=a ?? 0;
            int d = a ?? 10;
            Console.WriteLine($"a: {a} d : {d}");

            // 3.  ?.


            string mailids = "ganeshkp@gmail.com";
            Console.WriteLine(mailids);

            /*  string mailid = null;
              string mailInUpper= mailid.ToUpper();
              Console.WriteLine($"mail: {mailid}/n mail in Upper: {mailInUpper}");*/
            // it not get mailid as a null so for that we can use ?.

            string mailid = null;
            string mailInUpper = mailid?.ToUpper();
            Console.WriteLine($"mail: {mailid}\n mail in Upper: {mailInUpper}");

            string mailide = "ganesh.pawar@gmail.com";
            string mailsInUpper = mailide.ToUpper();
            Console.WriteLine($"mail:{mailide}\n mail in Upper:{mailInUpper}");

            // bool b= true/false
            // bool? b= true/false/null


            Console.ReadLine();
        }
    }
}
