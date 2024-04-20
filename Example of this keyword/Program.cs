using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_this_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee sc=new Employee(1,"ganesh",999999.34f);
            sc.display();
            Console.ReadLine();

        }
    }
    public class Employee
    {
        public int id;
        public String name;
        public float salary;
        public Employee(int id, String name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
}
