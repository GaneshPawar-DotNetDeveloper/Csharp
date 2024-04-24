using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
/* 
             there are four types of property.
            1.Read only property:
             - which has only get access modifier
            2. write only property: 
             - which has only set access modifier
            3. read-write property:
             - which as both get and set access modifier.
            4.Auto Implimented property:
              - we do not need to create separate private field if there is no logic to write inside property.
              syntax:- public string city{get;set;}
 

            simple difine:
             - agar muze koi private field dusare class me use karani he to hum simply use 
           property se access kar sakate he
 */
            

       student s= new student();
            //  s.totalofmarks = 50;
            Console.WriteLine(s.totalofmarks);

teacher sw= new teacher();
            sw.id = 1;
         //   Console.WriteLine(sw.id); // here we can not get value because we use only set

School sc=new School();
            sc.Mazenav = "ganesh";
            Console.WriteLine(sc.Mazenav);

            FullName fn= new FullName();
            fn.firstName = "ganesh";
            fn.lastname = "pawar";
            Console.WriteLine($"fullname is {fn.firstName} {fn.lastname}");


Employee ew= new Employee("ganesh","pawar");
            Console.WriteLine(ew.firstname);
            Console.WriteLine(ew.lastname);

            // here that get set methods are public so any one can change/access that employee detail
          /*  ew.firstname = "suraj";
            ew.lastname = "pawar";
            Console.WriteLine(ew.firstname);
            Console.WriteLine(ew.lastname);*/
            // so for that we can make set property as a private
            // so when we make set as a private then updation give error



            Console.ReadLine();


        }
    }

    // 1. read only= get only
    public class student
    {
         int _id;
         string _name;
            int _marks;
        int _totalofmarks = 100; // exam paper marks fix hote he isliye
        
        public int totalofmarks
        {
            // here set ki jarurat nahi kyu ki use humne allready set kiya hua he
            // so jab hum main method me object create karake vaha iski value set kaene ki koshish 
            // karenge to error aa jayega.

            get { return _totalofmarks; }
        }
    }
    // 2. write property = set only
         public class teacher
    {
        int _id;
        string _name;
        int _marks;
        int _totalofmarks = 100; // exam paper marks fix hote he isliye

        public int id
        {
            set
            {
              this._id = value;
            }
        }

    }
    // read-write property:

    public class School
    {
        int _id;
        string _name;
        int _marks;

        public string Mazenav
        {
            set
            {
                if (string.IsNullOrEmpty(_name) == true)
                {
                    Console.WriteLine("please enter name");
                }
                else
                {
                    this.Mazenav = value;
                }

                
            }
            get
            {
                return this._name;
            }
        }
    }
    // 4. Auto implimentated property:
    // shortcut for create property is prop
   public class FullName
    {
       public string firstName { get; set; }
        public string lastname { get; set; }
        // so when we created auto implimented then we can access that feild in main method/another class method

    }

    // benefit of AutoImplimentation:

  public class Employee
    {
        public string firstname { get;  private set; }
        public string lastname { get;  private set; }

        public Employee(string fn, string ln)
        {
           this.firstname=fn;
            this.lastname=ln;
        }
    }


}
