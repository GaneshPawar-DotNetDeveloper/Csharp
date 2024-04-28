using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace String_Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // String type
            // collection of characters
            string name = "    Ganesh";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Trim());
            // Escepe sequence:
            // -- to remove special meaning of any character
            // we use \"____\"
            // \\____\\
            // \*___\*
            string nam = "/*ganesh/*";
            Console.WriteLine(nam);
            string names = "///pawar/***";
            Console.WriteLine(names);
            // we want to join two string value
            string Firstname = "ganesh";
            String lastname = "pawar";
            // 1.plus operator:
          string   fullname = Firstname+" " + lastname;  
            Console.WriteLine(fullname);
            // concat:
            // 1. plus operator:
            string firstName = "ganesh";
            string middleName = "Khanderao";
            string lastName = "pawar";
            fullname= firstName+" " + middleName;   
            Console.WriteLine(fullname);
            //2. concat:
            fullname=string.Concat(firstName," ",lastname);
            Console.WriteLine(fullname);
            //3. join 
            fullname= string.Join("    ",lastName,firstName);
            Console.WriteLine(fullname);
            fullname=string.Format(fullname,firstName);
            Console.WriteLine(fullname);
            















            Console.ReadLine();
        }
    }
}
