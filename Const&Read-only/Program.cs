using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Const_Read_only
{
    internal class Program
    { // kisi member/feild ka same value rakana he to hum const and read-only ka use karenge.

        static void Main(string[] args)
        {
            student sc = new student();
            sc.id = 1;
            sc.name = "ganesh";
            sc.age = 24;
            //   sc.College = "BVA,Ankoli";
            Console.WriteLine(sc.id);
            Console.WriteLine(sc.name);
            // Console.WriteLine(sc.college); // here we can't call const value bws it is a bydefault static.
            // so static value we call with class name.
            Console.WriteLine(student.College);

            // here we want to don't change college name so for that we can use const keyword.
            // Console.WriteLine(sc);
            Console.WriteLine(sc.teachername);
            //   Console.WriteLine(sc.principalname); // we can't call bws it is static
            Console.WriteLine(student.principalName);

            Console.ReadLine();
        }
    }
    class student
    {
        public int id;
        public string name;
        public int age;
        public const string College = "Wcs,solapur";// it is mandatory to initialize the value.

        // for read only there is not mendatory to value declaration.
        // so read-only is not bydefault static.
        public readonly string teachername;
        public readonly string staff = "11 th staff";
        public static readonly string principalName;

        // read-onlyfield can be initialize in constuctor only onece.
        public student()
        {
            teachername = "edd";

        }
        
    }
}
