using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    
    public class parent
    {
        public virtual void print()
        {
            Console.WriteLine("this is parent class method");
        }
    }
    public class child : parent
    {
        public  override void print()
        {
            Console.WriteLine("this is child class method");
        }
    }
    
    
    
    
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {

parent p= new parent();

p.print();
            parent c= new child();
            c.print();



Console.ReadLine();
        }
    }
}
