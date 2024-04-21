using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int[] age= new int[]{12,345,456543,3456543,234};
            // similer we create object of employee type array
            Employee[] employees = new Employee[] {

                new Employee(){Id = 1,Name="ganesh",Gender ="male" },
                new Employee(){Id = 2,Name="mahesh",Gender="male"},
                new Employee(){Id = 3,Name="radhika",Gender="female"}
            };

            Company tcs=new Company(employees);
         //  string s= tcs[3];
            // here we want to object as a tcs give value in array indexing.
            // so for that we use indexer.
            // indexer hume help karega ki class ke object ko index se access karane ke liye.
            // 

            Console.ReadLine();
        }

    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private Employee[] _employees;

        public Company(Employee[] employees)
        {
            _employees = employees;
        }

        // method for indexer 
       // public string name[]    // for indexer we write a method parameter in square bracket.
    
    }
}
