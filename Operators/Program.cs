using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* operators
             *  == - equal to
             *  != - not equal to 
             *  <  - less than
             *  >  -  greater than
             *  <= - less than equal to 
             *  >= - greater than equal to
             *  && - and
             *  || - or (pipe)
             *  + - pluse
             *  - - minus
             *  * - into
             *  / - dividation
             *  % - reminder
             */


            int a = 10; int b = 10;
            int c = 10 + a;
            int d = 10 + b;
            int e = 10 + c;
            Console.WriteLine(e);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.WriteLine();
            //   Console.ReadLine();


            int i = 20, j = 30;
            Console.WriteLine(i);
            Console.WriteLine(j);

            int k = i + j;
            Console.WriteLine(k);

            int p = i - j;
            Console.WriteLine(p);

            int q = i * j;
            Console.WriteLine(q);

            int r = i / j;
            Console.WriteLine(r);

            i++; // it is a post increment
            Console.WriteLine(i);
            Console.WriteLine(i++);
            ++j; // it is a pre increment
            Console.WriteLine(j);
            Console.WriteLine(j++);
            //i + 23 = i;
            i = i + 34;
            Console.WriteLine(i);

            i += 12;
            j -= 23;
            Console.WriteLine(j);
            Console.WriteLine(i);

            bool result = i == j;
            Console.WriteLine(result);
            result = i < k;
            Console.WriteLine(result);
            int z = 12, o = 12, m = 32;
            result = z == o && o < m;
            Console.WriteLine(result);
            result = z == m || m == o;
            Console.WriteLine(result);

            Console.ReadLine();





















        }
    }
}
