using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{

    public class developer
    {
      public  int studentid;
        public string firstname;
        public string lastname;
        public int passingyear;
        public string companyname;

        public void printdetails()
        {
            Console.WriteLine($" student id is {studentid}\n full name is :{firstname} {lastname}\n " +
                $"passing year is {passingyear}\n copamy mane is {companyname}");
        }


    }
    public class javadeveloper:developer
    {
        public int salary;
        public new  void printdetails()
        {
            Console.WriteLine($"full name is :{firstname} {lastname}\n " +
                $"passing year is {passingyear}\n copamy mane is {companyname}\n" +
                $"salary is : {salary}");
        }

    }
    public class pythondeveloper :developer
    {
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
                     we have base class and dirived class and in both classes we have same we have same methods,
                     same method means same signature. (return type , method name, parameters and body will be different)
                     when we write same method in dirived class then compiler gives warning that warning is our 
                     dirived class method hiding base class method 
            // so for that we can use "new keyword".
                it say that in our classes therre already that print method are then why yoy get repiated that method

                  */



           /* developer developer = new developer() { firstname = "ganesh", lastname = "pawar",companyname="V#",studentid=1 };
            developer.printdetails();

            javadeveloper de=new javadeveloper() { salary=112};
            Console.WriteLine($"salary of javaldeveloper is {de.salary}");


            javadeveloper ww = new javadeveloper() { firstname = "suraj ", lastname = "boss", salary = 12323123 };
           int value= ww.passingyear = 2020;
            Console.WriteLine($"the passing year is {value}");
            ww.printdetails();*/
           // base class variable of class developer can point to base class object
           developer a= new developer() { studentid=1,firstname="ganraj",lastname="pawar",passingyear=2021
           ,companyname="V# technology"};
            a.printdetails();
            Console.WriteLine("------------------");
            javadeveloper c= new javadeveloper(){studentid = 3,firstname = "ganraj",lastname = "pawar",passingyear = 2021
           ,companyname = "V# technology"};; ; ; ; ; ; ;
            c.printdetails();
            Console.WriteLine("----------------------");
            // 2.base class vareiable can point to derived class object
            developer b= new javadeveloper(){studentid = 2,firstname = "ganeshrao",lastname = "pawar",passingyear = 2021
           ,companyname = "V# technology"};
            b.printdetails();
            

            // in that example method hiding me jis type ka reference variable hoga
            // usi type ka method call hoga

/*
          base = base - base class reference vaiable can pointing to base type object
                          here call base class method
          derived = derived - derived class referece can pointing to derived class object
                          here call derived class method
          base=derived - base class referece variable can pointing to derived class object
                          here call base class method
          dreived =base - not possible
 
 
 
 */





        Console.ReadLine();


















        }
    }
}
