using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_equal_to_operator_methodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            //  int j = i;
            int j = 10;
            if (i == j)
            {
                Console.WriteLine("i equal to j");
            }
            else
            {
                Console.WriteLine("i is not equal to j");
            }
            string s = "ganesh";
            //  string s2 = s;
            string s2 = "ganesh";
            if (s == s2)
            {
                Console.WriteLine("s is equal to s2");
            }
            else
            {
                Console.WriteLine("s is not equal to s2");

            }

            //  calculator c1= new calculator();
            // calculator c2 = c1; // c1 copy in c2
            calculator c1 = new calculator() { number1 = 10 ,number2=12};
            calculator c2 = new calculator() { number1 = 10 ,number2 = 12 };
            // when we run that condition  then it give that is not
            // equal 
            // jab hum c2=c1 bolate he tab uske liye yek hi memory allocate hoti he iske vajah se 
            // hume vo equal de deta he.
            // par jab hum new calculator likhate he tab vo everyone ke liye
            // naya memory allocate karata he
            // iske vajah se vo not equal to print karata he.

            if (c2 == c1)
            {
                Console.WriteLine("c1 and c2 is equal");

            }
            else
            {

                Console.WriteLine("c1 and c2 is not equal");
            }



            Console.ReadLine();
        }
    }
    public class calculator
    {
        public int number1;
        public int number2;
        public static calculator operator +(calculator c1, calculator c2)
        {
            calculator c = new calculator();        
            c.number1 = c1.number1 + c2.number1;

            c.number2 = c1.number2 + c2.number2;
            return c;
        }
        public static bool operator ==(calculator c1,  calculator c2)
        {
            return c1.number1 == c2.number1 && c1.number1 == c2.number1;
        }
        public static bool operator !=(calculator c1, calculator c2)
        {
            return c1.number1 != c2.number1 && c1.number1 != c2.number1;
        }
    }
}
