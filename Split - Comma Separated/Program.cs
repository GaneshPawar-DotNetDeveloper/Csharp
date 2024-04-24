using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split___Comma_Separated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("please enter your education in comma separareted value ");
             string value=Console.ReadLine();
           //  Console.WriteLine(value);
             string[] education=value.Split(new char[] { '-' }); // yaha hum konsi bhi char value de sakate he
            // Console.WriteLine(education);
             for(int i = 0; i < education.Length; i++)
             {
                 Console.WriteLine(education[i]);
             }*/
            // reverse sentance with split method
            Console.WriteLine("please enter your sentance");
          string value=Console.ReadLine();
          /*int value=int.Parse(Console.ReadLine());
            int[] words=value.Split(new char[] { ',', '.', ':', });*/
            string[] words = value.Split(new char []{',','.',':',});
            for (int i = words.Length-1;i>= 0;i--)
            {
                Console.WriteLine(words[i] +"  ");
            }




            Console.ReadLine();
        }
    }
}
