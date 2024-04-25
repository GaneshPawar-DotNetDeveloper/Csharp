using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Return_in_main_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = print("ganesh", "pawar");
            Console.WriteLine(res);
            // here pahile print method that value print kar raha tha
            // but ab print method vo value main method (res) ko de raha he
            //or main method value return kar raha he
            // means ruturn method value return kr raha he

            Console.ReadLine();
        }

        static string print(string s,string s1)
        {
            // return statement returning  datatype and value also
            string result = string.Format("you return : {0}{1}", s, s1);
            return result;
        }

    }
}
