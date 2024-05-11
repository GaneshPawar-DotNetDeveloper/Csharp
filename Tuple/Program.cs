using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tuple<int,int,int,int,int> temp=new Tuple<int, int, int, int, int> (1,2,3,4,5);
            //Console.WriteLine (temp);
            Console.WriteLine(temp.Item4);

            Tuple < int,string,char,byte,int,string,int, Tuple< int,int,int,int,int>> www= new
                 Tuple<int, string, char, byte, int, string, int, Tuple<int, int, int, int, int>>(11, "ddjfhf", 'A'
                 , 1, 43, "dhfegff", 23,temp);
            Console.WriteLine(www);
            Console.WriteLine(www.Item5);
            Console.WriteLine(www.Rest.Item1);



            //   Tuple<int, string, string> student = getstudent();
            var student = getstudent();











            Console.ReadLine ();


        }
        static Tuple<int, string, string> getstudent()
        {
            Tuple<int,string,string> student = new Tuple<int, string, string>(1, "ganesh", "male");
            return student;
        }
    }
}
