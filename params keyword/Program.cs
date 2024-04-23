using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parems_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // params keyword we can only use with array.
            // for calling a printsum method for that we create a array
            int[] numb = new int[] { 1, 2, 3, 4, 5, 6, };
            printsum(numb);

           Console.WriteLine("--------------------");

            // we can direct put object in method it also get
            printsum(new int[] { 12343,345654,3,3,4,3});
            Console.WriteLine("-----------------");
            int[] numb2 = null;
            printsum (numb2);
            Console.WriteLine("----------------");
            printsum( null );
            Console.WriteLine("-------------");
            printsum(new int[] { -12, 123, 1233, -23, -443 });
            Console.WriteLine("-----------");

            // in above all example we put value in method like printsum(new int[] { 12343,345654,3,3,4,3});
             // but we want put value like comma separeted (printsum(11,23,4,553)) and for null
             // we put empty method (printsum())
             // so for that we can use params keyword
             // params keyword we can use with method parameter
             // so we can put like that:
             printsum ();
            Console.WriteLine("with param empty method");
            printsum(12, 234, 234, 654,23);
            Console.WriteLine("direct put comma separeted values");
            // params keyword we can pass with only array paramerter
            // there are two benifits of params :
            // 1. we can put comma separeted value as a input
            // 2. input araay will bw optional. 


            Console.ReadLine(); 
        }
        static void printsum( params int[] numbers) {

            // when we have multiple parameters then params keyword should be apply on last parameter
            if (numbers != null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum = sum + numbers[i];
                }
                    Console.WriteLine("Addition : {0}", sum );
                
            }
            else
            {
                Console.WriteLine("empty array");
            } }
    }
}
