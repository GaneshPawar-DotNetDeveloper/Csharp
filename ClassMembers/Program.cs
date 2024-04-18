using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        ClassMembers members:
                 - feilds
                 - constructor
                 - method
                 - properties
                 - Indexer
                 - destructor - To clear the memory allocator
                              - Gc methos is get but some senario me hume destructor likhana hoga

           ** properties:
            -properties are used to encapsulate and protect the private fields.
            -properties syntax is similler to the methods.
            -but properties can be accessed as class fields.
            -before concept of property we use getyter and setter method. 
                        */

            // rollnumber can not be negative 
            // if name is null then show no name insted of blank
            // passmark can not should be changed.
        
        student sc=new student();
          //  sc.rollnumber = -1;
            //sc.SetRollnumber(-1);
            sc.Rollnumber = 1; // properties always access just like a field so we can not need call method
           // isme hume samj nahi ayega ki vo property he kya field he but property hogi to uske bahut logic 
           // likha hua hoga.

           // sc.name = "Ganesh";
            // here i want put null value
          sc.Name = null;
            // sc.passmark = "85%";
            // so we can not passmark beacause it is read only
            sc.city = "solapur";
            Console.WriteLine($"Rollnumber :{/*sc.rollnumber*/ /*sc.Getrollnumber()*/ sc.Rollnumber} " +
                $"name : {sc.Name} passmark : {sc.passmark} city :{sc.city}");
        Console.ReadLine();
        
            // it give exception
            // getter method means to retrive the value 
            // setter method means to assign the value.
        }
    }

    public class student
    {
        //  public int rollnumber;
        private int _rollnumber;
        //public string name;
        private string _name;
        // public string passmark;
       private int _passmark =35;
        private string _city;

        public int Getrollnumber()
        {
            return _rollnumber; // that is get method

        }

        public void SetRollnumber(int rollnumber)
        {
            if (rollnumber > 0)
            {
                _rollnumber = rollnumber;
            }
            else
            {
                throw new Exception("rollnumber can not negative");
            }
            // yaha humne yek field ke liye do method likhe hua he (getter-setter)
            // isme humne private feild ko get set karane ke liye ye methods likhe
            // and encapsulation logic in getter and setter method (how to get -set )
            // but isme hume her vakt do methos likhane padenge so it is privious thing
            // so we can replace getter-setter to property
            // property as two Access specifiers
            // 1. get
            // 2. set

        }
        // property syntax is very similler to method
        // property have return type (konse field ke liye likh rahe ho uska return type lenge )
        // property does not input parameters (method have parameter)
        // in property there are two Access Specifiers 1.get 2.set
        public int Rollnumber
        {
            get
            {
                return _rollnumber;
            }
            set
            {
                /*if (rollnumber > 0)
                {
                    _rollnumber = rollnumber;*/

                // property don't have a parameter then how we set the feild 
                // so for that in property have one special keyword value
                if (value > 0)
                {
                    _rollnumber = value;
                }


                else
                {
                    throw new Exception("rollnumber can not negative");
                }

            }


        }
        public string Name
        {
            get
                    {
                return string.IsNullOrEmpty(_name) ? "no name" : _name;
            }
            set
            {
                _name= value;

            }
        }

        public int passmark
        {
            get
            {
                return _passmark;
            }
        }
            // here we do not need set because we already put that field.
            // so it is read only 


            // types of property:
            // 1. Read only property
         /*     - which as only get access modifier.
          *   2. Write only property:
          *      - which as only set access modifier.
          *    3. Read-write property:
          *    - which as both get and set access modifeir.
          *    
              */
        /* public string city
        {
            get
            {
                return _city;
            }
            set 
            {
                _city= value;
            }*/

           // but here that is not need 
           // there is no logic to write get aand set body
           // so then we use Auto implemented property.
           public string city { get; set; }

        }
    }

