using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fulltimeEmployee e= new fulltimeEmployee();
            e.printB();
            // in that case it call its class method like fulltimeemployee's method but i want to print
            // employee's method so for that we use base keyword.
            // this keyword means usi class ka object 
            // base= base class points to current instatance of base class

            // call the constructor 
            fulltimeEmployee se= new fulltimeEmployee();
            // so when we call derived class constructor then it first call base class constructor then 
             // it run/called derived class constructor.



            Console.ReadLine();
        }
    }
    public class employee

    {
        public employee()
        {
            Console.WriteLine("base class constructor called");
        }
        public void printA()
        {
            Console.WriteLine("printA method called of employee");
        } 

    }
    public  class  fulltimeEmployee :employee {

        public fulltimeEmployee()
        {
            Console.WriteLine("derived class constructor called");
        }
        public new  void printA()
        {
            Console.WriteLine("printA method called of fulltimeemployee");
        }
        public void printB()
        {
            printA();
            // we want to call base class method so for that 
            base.printA();
        }
        
    }
}
