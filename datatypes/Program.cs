using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            int b = 1244;
            byte c = 23;
            short d = 234;
            int e = 122344445;
            long f = 1234567890;
            float g = 12.6f;
            double h = 122667.234556767798654333;
            decimal i = 122.1234567890m;
            char j = 'A';
            string k = "GANESH PAWAR";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            // Console.WriteLine(A);
            // Console.WriteLine(A);
            Console.WriteLine(j);
            Console.WriteLine(k);

            // Console.ReadLine();
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(decimal));

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(a);

            float p = 123.23F;
            Console.WriteLine(p);


            double q = 123.34578765;
            Console.WriteLine(q);

            decimal r = 12344.345663234566677m;
            Console.WriteLine(r);

            // for finding time 
            DateTime dob = DateTime.Now;
            Console.WriteLine(dob);

            // for string value

            string name = "ganesh" +
                "pawar ";
            Console.WriteLine(name);

            string print = "dot net framework";
            Console.WriteLine(print);

            //  Console.ReadLine();

            int z = 234;
            Console.WriteLine(b);
            //  Console.ReadLine();

            // Datatypes
            // 1. boolean datatype 

            bool b1 = true;
            Console.WriteLine(b1);
            Console.WriteLine(sizeof(bool));

            //2. integral datatype:
            // a. byte
            // b. short
            // c. int
            // d. long
            //  byte / short / int / long values = 2;
            // it get bydefault value as a int 
            int value = 2;
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(value);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine($"{a}:{b},{c}@ {d}#{value}' {short.MinValue}:{e}");
            Console.WriteLine($"{a}:{short.MaxValue}:{short.MinValue}:{int.MinValue}");
            Console.WriteLine($"{d}:{float.NaN}:{float.MinValue}{d}{f}{e}{g}{h},string as a get value,(dwhfiwdw)");
            //  Console.ReadLine();
            // 3 .floating type

            //  a.float
            //  b.double
            //  c. decimal
            // it get bydefault value as a double 

            float ie = 10.55f;
            Console.WriteLine(ie);

            double pq = 12234.3453;
            Console.WriteLine(pq);

            decimal jq = 1234.123m;
            Console.WriteLine(jq);
            //Console.ReadLine();

            // string type 
            // 1. char
            // 2. string
            char division = 'A';
            Console.WriteLine(division);
            string ab = "ganesh pawar";
            Console.WriteLine(ab);
            string www = "health is wealth";
            Console.WriteLine(www);
            char number = '+';
            Console.WriteLine(number);
            char vv = '*';
            Console.WriteLine(vv);
            char DD = ';';
            Console.WriteLine(DD);
            Console.WriteLine(char.MaxValue);
            Console.ReadLine();










        }
    }
}
