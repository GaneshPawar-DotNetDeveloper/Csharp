using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatination
{
    internal class Program
    {
      static  string firstname = "Ganesh";
       static string lastname = "pawar";

        static void Main(string[] args)
        {
            /* // 1. plus operator
             string fullname = firstname +" ++ " + lastname;
             Console.WriteLine(fullname);
             // concat
             fullname = string.Concat(firstname, "concat", lastname);
             Console.WriteLine(fullname);
             //join
             fullname = string.Join("join", firstname, lastname);
             Console.WriteLine(fullname);
             //spaceholder
             fullname = string.Format("{o}{1}" );*/
            /*string d = "ganesh \bpawar";
            Console.WriteLine(d);   
            */
            /* string firstname = "ganesh";
             string lastname = "pawar";
             string fullname = firstname + " " + lastname;
           Console.WriteLine(fullname);
             string meranam = string.Concat(firstname, " ",lastname);
             Console.WriteLine(meranam);
             string mazenav=string.Join(" ",firstname,lastname);
             Console.WriteLine(mazenav);
             string myname = string.Format("{0}{1}",firstname,lastname);
             Console.WriteLine(myname);
             string name = "suraj\b\n\tpawar";
             Console.WriteLine(name);
             // string interpolation
             string fullyName = $"fullname is: {firstname}\t{lastname}";
             Console.WriteLine(fullyName);*/
            ConsoleUserInput sc=new ConsoleUserInput();
            sc.print();
            sc.news();





            Console.ReadLine();
        }
    }
}
