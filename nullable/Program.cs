using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                     nullable== absence of value 
                      - all value type are non-nullable 
                      - nullable type are bridge between sql type and c# type 

                        int =non nullable
                        int ? = nullable
                        int ?? = null coalease operator
                     nullable is also a class
             */
            //int i = null;
            int ? i2 = null;
           // DateTime d = null;
            DateTime ? d1= null;
            Nullable<DateTime> d2= null;


            /* int? a = null;
             int b = (int)a;
             Console.WriteLine(b);
            its give System.InvalidOperationException because a is nullable but b is nullable
            so for that we use ??
             */
            int? a = null;
            int b = a ?? 12;
            Console.WriteLine(b);

            int? c = 123;
            int d = c ?? 0;
            Console.WriteLine(d);

            //?. --> it prevent from null pointer exception
            /* string email = null;
             string emailInupper=email.ToUpper();
             Console.WriteLine($" {email}  {emailInupper}");
             // for that example they give System.NullReferenceException
             SortedDictionary for that we use ?. */
            string email = null;
            string emailInUpper= email?.ToUpper();
            Console.WriteLine($"{email} {emailInUpper}");








            Console.ReadLine();
        }
    }
}
