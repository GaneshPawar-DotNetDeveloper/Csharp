using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedKeyword
{
    // Use Of Sealed Keyword
    // To Restrict a Class For Inheritance
    // Sealed Keyword We Can Use With Class And Method.

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // Sealed Class :
    // No One Can Inherit This Class 
    // Rest Of Things Are Same.
 /* public  class A { }
  public sealed  class B : A{ }  // Class B can not inherited because of sealed
  // public class C : B { }  */ 


    // sealed method example:
   public class A
    {
      public virtual void print()
        {
            Console.WriteLine("A");
        }
    }
    public class B :A
    {
        public  sealed override void print()
        {
            Console.WriteLine("B");
        }
    }

    // here we wnat to not allowed overide to class c method
    // so for that we can declare method B as sealed.
    // but we can write sealed for class A method then it give error like you can not get sealed for print 
    // A method beacause it can not override.

    // So Sealed Method Cannot Be Override In Derived  Class
    // Sealed Keyword We Can Use Only With Override Method.


    public class C: B
    {
       /* public override void print()
        {
            base.print();
        }*/

    }

}
