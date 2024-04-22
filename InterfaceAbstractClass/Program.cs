using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
    public interface IA
    {
        void printA();
    }
    public interface IB : IA
    {
        void printB();
    }
    public class C : IB // jab hum IA lete he to sirf PrintA method inpliment karana hoga but
                        // jab hum IB lete he tab dohno method ko Hume Impliment karana padega .

    {
        public void printA()
        {
            Console.WriteLine("A");
        }

        public void printB()
        {
            Console.WriteLine("B");
        }
    }

    public abstract class X
    {
        public abstract void printX();

    }
    public  abstract class Y : X { } // in that case we can use abastract keyword for without override

public class Z : Y  // yaha par hum inherite nahi kar sakate beacause X me method likha hua he 
                    // tab hume ise override karana padega 

    {
        public override void printX()
        {
            throw new NotImplementedException();
        }
    }

    // abstract class yek interface type ko inherite nahi kar sakata.
    // matalab yek bhikari dusare bhikari ko bhik nahi deta.
    public interface IP {
     void printP();
    
    }
    public abstract class Q : IP  // isme method implement karani padegi lekin ye abstract he
                                  // to use implement karake bhi kohi fayada nahi he.
    {
        public void printP()
        {
            throw new NotImplementedException();
        }
    }

}


