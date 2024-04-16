using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_And_Encapsulation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // so we can create object of Employee class 
            // Access Sallary method without see its implimentation

            Employee cs= new Employee(1,"ganesh",33333);
            cs.showEmployeeDetails();
            Console.ReadLine();
            // here we access calculatesallary() as without implimentation.

        } }
            class Employee
        {
            int EId;
            String Ename;
            Double EGrosspay;
        double TaxDeduction = 0.1;  // = 10%
        double grossnet;

        public Employee(int id, string name, double Grosspay)
        {
            this.EId = id;
            this.Ename = name;
            this.EGrosspay = Grosspay;
        }
            void CalculateSallary()
            {
               if(EGrosspay >= 30000)
                {
                    grossnet = EGrosspay - (TaxDeduction * EGrosspay);
                    Console.WriteLine($"totalsallary is :{grossnet}");
                }
               else
                {
                    Console.WriteLine($"salary is {grossnet}");
                }
               

            }
            public  void showEmployeeDetails()
        {
           this. CalculateSallary();
        }

        // so here we hide the all functonality of calculatorSallary method and we call method in another method.
        // is calculatorsallary method ka uske implimentation ke sath kuch bhi vasata nahi he , yaha hum sirf usko
        // access kar rahe he.










        }
        }





        
    

