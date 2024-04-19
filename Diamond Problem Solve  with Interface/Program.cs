using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Problem_Solve__with_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C cs=new C();
            cs.printA();
            cs.printB();


            Console.ReadLine();  
           
        }
    }
  public   interface IA
    {
         void printA();
    }
  public  interface IB
    {
        void printB();
    }
    public class A : IA
    {
        public void printA()
        {
            Console.WriteLine("A");
        }

       
    }

    public class B : IB
    {
        public void printB()
        {
            Console.WriteLine("B");
        }

       
    }
    // here we can not inherite one class in multiple base class
    // we can use interface for that achivement.

    public class C : IA, IB
    {

        // hum yaha do field banayenge(a,b ka object banayenge)
        A a = new A();
        B b = new B();
        public void printA()
        {
            a.printA();
           
        }

        public void printB()
        {
            b.printB();
        }
    }
}
