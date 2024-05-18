using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myLiabraryproject;
namespace myClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 sc=new Class1();
            sc.printmethod();



            // but here i want to call myclient project-clientclass-printMethod call in myliabrary project which
            // as dll project file- class1 me call karana he to kaise kare?
            //--> by reference karane jayenge to vo hume circular dependency ka error dega.
            // so for that we use delegate.
            // so class1 me hum yek delegate add karenge.

            Console.ReadLine();



        }
    }
}
