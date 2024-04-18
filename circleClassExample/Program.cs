using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace circleClassExample
{



    class circle
    {
        public static float pi = 3.14f;
        public int radius;

        public circle(int radius1)
        {
            radius = radius1;
            Console.WriteLine("instance constructor call");

        }
        // that is static constructor
        // no parameter to static constructor
        // purpose of static constructor to initialize static field.
        // ststic constructor sabse pahile call hota he or bad me instance constructor call hota he 
        // static constructor yek hi bar execute hota he or instance constructor jitane bar humane 
        // object create kiya utani bar run hota he.
        // static constructor get called when we created object
        // static constructor get called when we access any static member
        static circle()
        {
            pi = 3.14f;
            Console.WriteLine("static constructor call");
        }
        public float calculateArea()
        {
            Console.WriteLine("calculation of area := {0}", pi * radius * radius);
            return pi * radius * radius;
        }
    }
    public class sample
    {
        public static string message;
        public sample()
        {
            Console.WriteLine("instance static constructor called  ");
        }
        static sample()
        {
            message = "hello static world";

            Console.WriteLine("static constructor called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            circle se = new circle(20);
            se.calculateArea();
            //  Console.WriteLine(se);
            circle s1 = new circle(30);
            s1.calculateArea();
            circle s3 = new circle(20);
            s3.calculateArea();
            circle s4 = new circle(20);
            s4.calculateArea();

            Console.WriteLine("--------------------------");

            /*sample sw = new sample();
            sample sq = new sample();
            sample swc = new sample();
            sample swf = new sample();
            sample swm = new sample();
            sample swd = new sample();*/
            Console.WriteLine(sample.message);
            sample dd = new sample(); 

            // instance member can access instance as well as staic  members.
            // static member can access only static members 
            // agar hume non static field ko main method me call karana hoga to hume object crate karana
            // hoga.









            Console.ReadLine();
        }
    }
}
