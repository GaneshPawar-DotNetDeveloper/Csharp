using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEx
{




    class Employee
    {
        int[] age = new int[5];  // here class members bydefault private hote he.
        // is age ko kohi directly dusari class access nahi kar sakati .
        // so for that we can create a indexer.
        // for create indexer type indexer +double tab

        public int this[int index] // here hum jo value denge vo index through milegi
        {
            set
            {
                if (index >= 0 && index < age.Length)
                {
                    if (value > 0)
                    {
                        age[index] = value;
                        // hum jo index value dalenge vo value me store ho jayegi.
                    }
                    else
                    {
                        Console.WriteLine("invalid age");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index");
                }


            }
            get
            {

                return age[index];
            }
            // here that property without name and feild as a private then how we access in another class

        }
        // ew can overload indexer but parameter should be difference
        public int this[int index,int i]
        {
            
            set { 
            
                age[index] = value+i;
            }
            get
            {
                return (age[index]);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Encapsulation me hum field ko private banate he or property through hum kis type ka data 
            usme jayaga ye logic batate he.
            or uske bad hum variable asign karate he.
            but hume variable ki jagah kisi array / list collection ko encapsulate karana ho to hum indexer 
            use karenge.
            -- isase hum array ke under ka data check kar sakate he 
          
             */

            Employee employee = new Employee();
            employee[0] = - 5; // this similer like age[index] = value;
            // that we set the value
            Console.WriteLine(employee[0]); // that is we get the value.

            // but here we can restrict two things
            // 1. age could not be nigative.
            // employee[0] = -5;
            // 2. and we can not give value in out of index
            // employee[4] = 5;

       Employee wee=new Employee();
         wee [0,5] = 7;
            // here that method have two method overloads.

            Console.WriteLine(wee[0, 5]);








            Console.ReadLine();

        }
    }
}
