
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataType_To_Static_Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
                // ArrayList arrayList = new ArrayList();
                //Console.WriteLine(arrayList);
                Console.ReadLine();
            }*/
           student sc= new student() {firstname="ganesh",lastname= "pawar" };
            sc.printfullname();
            student sc1 = new student(sc); // copy data from sc to sc1. 
             sc1.printfullname();
            Console.ReadLine(); 
        }
    }
    public class student
    {
        public string firstname;
        public string lastname;
        public student(student s) { 
           firstname=s.firstname;
            lastname=s.lastname;
        
        }
        public student() { }
        public void printfullname() 
        
        {

            Console.WriteLine($"fullname is : {firstname} {lastname}");
            }











    }
    }

