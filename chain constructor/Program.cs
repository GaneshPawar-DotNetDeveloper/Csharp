using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_constructor
{

    public class employee
    {
     //   public employee() { }// this is one way to write default constuctor explicitly.
        public employee(string  m) {

            Console.WriteLine("base class constructor");
        }
    }
    public class employee2 :employee
    {
        public employee2(string m):base(m) {

            Console.WriteLine("derived class constructor");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // employee s= new employee("hg");
            employee2 s2= new employee2("ganesh");

            // here derived class constructor get parametrized consructor without any issue but 
            // when we try to give base constructor as a parameterized then it give error
            // isme framework dekhata he ki base me default constructor parameterless he kya 
            // call karane ke liye vo mendataory he kyuki dirived constructor call karane par vo pahilye
            // base ka call kaarata he 
            // so isiliye hum yaha default constructor likh sakate he
            // or uske liye alternative chain constructor use kar akate he.

            Console.ReadLine();
        }
    }
}
