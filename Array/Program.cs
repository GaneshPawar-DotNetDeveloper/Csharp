using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // when we add 50 student rollnumber or some data then we do like
            /* rohan = 12;
             raj = 123;
             mahesh = 143;
             sam = 154;
             rahul = 654;
             but  it is not good for practice so we can use array*/
            // A. using size
            int[] ages = new int[3];
            // int []== declare array
            // ages== variable
            // new== for array initialize/declare
            // int[3]== kitane size ka array banana he.(means kitane student ka age likhana he)
            ages[0] = 11;
            ages[1] = 12;
            ages[2] = 13;
            // ages[3]= 14; when we add that extra element then it gives System.IndexOutOfRangeException.
            // these are accesing element
            // so i want second ages element then
            Console.WriteLine(ages[2]);
            // B. using Array Initializer syntax
            int[] agess = new int[] { 1, 2, 3 };// isme hume size dene ki jagah direct unko initialize kiya
            Console.WriteLine(agess[2]);

            // print length of array
            Console.WriteLine(agess.Length);

            // we want print all value/element of array
            int i;
            for (i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
            int a;
            for (a = 0; a < 3; a++)
            {
                Console.WriteLine(agess[a]);
            }
            // new = array ka size fix nahi hota ho uski memory new keyword heap me allocate karegi
            // limitation of array:
            // 1. arrays size is fix
            // 2. we can not save two datatype in a single array
            string[] names = new string[] { "ganesh", "suraj", "raj", "pruthviraj" };
            Console.WriteLine(names.Length);
            //   names[4] = "mahesh";
            // Console.WriteLine(names.Length);
            for (a = 0; a < names.Length; a++)
            {
                Console.WriteLine(names[a]);

            }
            int[] workers = new int[5];
            workers[0] = 1;
            workers[1] = 2;
            workers[2] = 3;
            Console.WriteLine(workers.Length);

            char[] division = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine(division.Length);
            Console.WriteLine(division[0]);
            int[] rollnumber = new int[6544];
            rollnumber[0] = 1;
            rollnumber[34] = 1344;
            rollnumber[6000] = 232113;
            Console.WriteLine(rollnumber.Length);
            Console.WriteLine(rollnumber[5456]);
            Console.WriteLine(rollnumber[2345]);
            Console.WriteLine(rollnumber[6000]);

            Console.WriteLine("---------------------------------");

            // reverse direction
            //1.
            string[] name = new string[] { "suraj", "ganesh", "pruthviraj" };
            int z;
            for (z = name.Length - 1; z >= 0; z--)
            {
                Console.WriteLine(name[z]);
            }
            //2.
            /*  int[] num = new int[] { 12, 123, 1234, 12345, 23456 };
              for(int w = 1; w < num.Length; w++)
              {
                  Console.WriteLine(num[w]);

              }*/
            //3.
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            for (int e = num.Length - 1; e >= 0; e--)
            {
                Console.WriteLine(num[e]);
            }
            //4. find highest number
            int[] numb = new int[] { 12, 34, 46, 356, 3456, 345, 234, 7765, 234565, 567765, 456654, };
            int highest = 0;
            for (int ia = 0; ia < numb.Length; ia++)
            {
                for(int j = ia + 1; j < numb.Length; j++)
                {
                    if (numb[j]>highest)
                    {
                        highest = numb[j];
                    }
                }
                
            }
            Console.WriteLine($" the highest number is {highest}");

            // 5. 
            // reverse input string
            Console.WriteLine("please enter your name");
            string nam=Console.ReadLine();
            string reverseName = string.Empty;
            for(int s=nam.Length - 1; s >= 0; s--)
            {
                reverseName += nam[s];
            }
            Console.WriteLine($"reverse name is :{reverseName}");
            //6.reverse word in sentence
            Console.WriteLine("please enter your sentence");
            string sentence=Console.ReadLine();
          //  int t;
            string[] words = sentence.Split(new char[]{' '});
            for(int s=words.Length - 1;s>=0;s--)
            {
                Console.WriteLine(words[s]);
            }
            Console.WriteLine("---------------------------");
            // 7. multidiamentional array:
            int[,] ganesh = new int[3, 3];
            for (int f = 1; f < ganesh.Length; f++)
            {
                for (int g = 1; g < ganesh.Length; g++)
                {
                    Console.Write($"{f},{g}");
                }
                Console.WriteLine();
            }


             




            Console.ReadLine();
        }
    }
}
