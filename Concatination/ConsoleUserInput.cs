using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatination
{
  public class ConsoleUserInput
    {
        public void print()
        {
            Console.WriteLine("please Enter your FirstName");
            string firstname = Console.ReadLine();
            Console.WriteLine("please Enter your lastName");
            string lastname = Console.ReadLine();
            string fullname = $"full name is : {firstname} {lastname}";
            Console.WriteLine(fullname);
            fullname = "ful name " + firstname + " " + lastname;
            Console.WriteLine(fullname);
            fullname = string.Format("full name is :: {0},{1}", firstname, lastname);
            Console.WriteLine(fullname);
            fullname = string.Join(" ", firstname, lastname);
            Console.WriteLine(fullname);
            fullname = string.Concat(firstname, " ", lastname);
            Console.WriteLine(fullname);

        }
        public void news () 
            {
            Console.WriteLine("please enter your input ");
            string input = Console.ReadLine();
        Console.WriteLine("welcome to new world "+ input);
            

        }
        
    }
}
