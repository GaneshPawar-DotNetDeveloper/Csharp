using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             there are two way to write array 
              these are:
            1. using size:

             int [] num= new int[10];
            num[1] = 23;
            num [4]=1344;

             2. using initialization:
            string [] names= new string []{"ganesh","suraj","ramesh","pruthviraj","sachin"};
            console.writeline(names[3]);
                 or

             string [] names= {"ganesh","suraj","ramesh","pruthviraj","sachin"};


            -- so now wee see the two ways to write array:
            1. single diamensional array.
            2. multi diamensional array.

            
             */
            // single diamensional array:
           /* int[] rollnumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine(rollnumber[5]);
            // it as only one row
             for(int i = 0; i < 12; i++)
            {
                Console.Write(rollnumber[i]);
            }*/

            // 2 diamensional array:

            string[,] name = new string[2, 3]
            {
               {"ganesh","raju","mosin" },
               {"ramesh","suresh","shilesh" }

           };
            // so here i want get name like suresh
          /*  Console.WriteLine("\n");
            Console.WriteLine(name[1,1]);
            // i want to find length of first diamension and second diamension
            Console.WriteLine(name.GetLength(0));
            Console.WriteLine(name.GetLength(1));

            // i want to find kitane diamensional array he.
            Console.WriteLine(name.Rank); // rank is a property.

            // so now we can access the all element:
*/

            for (int i = 0; i < name.GetLength(0); i++)
            {
                for (int j = 0; j < name.GetLength(1); j++)
                {
                    Console.WriteLine(name[i, j] + " " +"\n");
                }
            }
            // i want data in tabular format

            for (int i = 0; i < name.GetLength(0); i++)
            {
                for (int j = 0; j < name.GetLength(1); j++)
                {
                    Console.Write(name[i, j] + " ");
                }
                Console.WriteLine(); // jab second for loop 3 value de kar complete jo jayega tab usake bad vo is line per ayaga or then first for loop 
                                     // chala jayega.

            }

            // with for each lopop:
         /*   foreach(string item in name)
            {
                Console.WriteLine(item);
            }*/

            // so this is sub point of 2 d diamension like rectanguar array :

            // 2. jagged array:

            int[][] numb = new int[3][];
            numb[0] = new []{0,1,2,4,5,56,67, };
            numb[1] = new[] { 1, 2, 4, 55, 6, 7, 8, 4543, 34543, 2343, 23 };
            numb[2] = new[] { 2, 4, 5, 3 };
            // here column size are not fixed.

            for (int i = 0; i < numb.GetLength(0); i++)
            {
                for (int j = 0; j < numb[i].Length; j++)
                {
                    Console.Write(numb[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("************************");

            // by using for each loop:
            foreach (int[] item in numb)
            {
                foreach (int i  in item)
                {
                    Console.WriteLine (i +" ");
                }
            }
                Console.ReadLine();
        }
    }
}
