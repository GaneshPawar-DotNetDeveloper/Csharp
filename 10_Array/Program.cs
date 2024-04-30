using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _10_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region print 
            //int i = 10;
            //    for (i = 1; i <= 10; i++ )
            //{
            //    Console.Write("*");
            //}
            //    Console.ReadLine();
            #endregion print
            #region aray
            // int[] arr = new int[5];//creating array  
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write($"{i}");
            //}

            #endregion aray 
            #region bb
            // for llop convert into while loop

            //int ia = 1;
            //    for (; ia < 6;)
            //{ 
            //Console.WriteLine($"{ia}");
            //    ia++;
            //}

            //Console.ReadLine();
            //for (int j = 0; j < 5; j++)
            //{
            //    break;
            //}
            #endregion bb
            #region break
            //for (int i = 1; i <= 10; i++)

            //{
            //    if (i == 5 && i == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion break
            #region break
            //for (int ia = 1; ia <= 10; ia++)
            //{
            //    if (ia == 5 || ia == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(ia);
            //}
            #endregion break
            #region aa
            for (int ab = 1; ab <= 10; ab++)
            {
                continue;
            }
            #endregion aa
            #region continue+break
            //for (int j = 1; j <= 5; j++)
            //{
            //    if (j == 4)
            //    {
            //        continue;
            //    }
            //    if (j == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(j);

            //    Console.ReadLine();
            //}
            #endregion continue+break



            // Array
            // Collection of similer dtatype items
            // when we want declir multiple variables then we use array

            // how to declair array
            // 1. first way:
            int[] gkp = new int[10];

            gkp[0] = 1234;
            gkp[2] = 1234545;
            gkp[3] = 5432;


            // new keyword use to allocate the memory 
            Console.WriteLine($" length of gkp is: {gkp.Length}");



            for (int i = 1; i <= gkp.Length - 1; i++)
            {
                Console.Write($"{gkp[i]} ");
                //  Console.WriteLine();
            }
            // Console.ReadLine();
            // second way 
            //Array initializer syntax
            int[] a = new int[0];
            Console.WriteLine(a);
            //Console.ReadLine ();
            #region reverse_name
            string[] names = new string[] { "ganesh", "kishor", "rahul" };
            Console.WriteLine($"/n reverse name");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.Write($"i");
            }
            #endregion reverse_name
             #region highest number


          int []  numbers =new int[] {12,43,344,2342,34323,11,1,098};
            int highest = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++) 
                {
                    if (numbers[j] > highest)  
                    {
                        highest = numbers[j];
                    }
                }

            }

            Console.WriteLine($"/nhighest number : {highest}");


            #endregion highest number


            student s1 = new student();

            s1.rollno= 1;
            s1.name = "ajay";
            Console.WriteLine(s1.name);



            Console.ReadLine();














        }
    }
    class student
    {
       public int rollno;
       public string name;
    }
}




