using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEx
{



    public class Person
    {
        /*public string name;
        public int age; */
       //  string name;
      //  int age;
        // here feilds bydefault private hi hote he.
        // so that feild aceess karane ke liye hum unka get and set method create kar lete he.
        /* public void Setname(string name)
         {
             this.name=name;
         }
         public void GetName()
         {
             Console.WriteLine($"the given name is :{name}");
         }
         public void SetAge(int age)
         {
             this.age = age;
         }
         public void GetAge()
         {
             Console.WriteLine($"the given age is :{age}");
         }*/
        string name;
        int age;

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("name is required");
            }
            else
            {
                this.name= name;    
            }
        }
        public void GetName()
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                
            }
            else
            {
                Console.WriteLine($"the name is : {name}");
            }
        }
        public void SetAge(int age)
        {
            if(age > 0)
            {
                this.age=age;
            }
            else
            {
                Console.WriteLine("age is not a nigative or zero \n");
            }
        }
        public void GetAge()
        {
            if (age > 0)
            {
                Console.WriteLine($" the reqire age is : {age}");
            }
            else
            {

            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           /* person s= new person();
            s.name = "ganesh";
            s.age= 10;

            // but here when user give invalid data means
            s.name = "";
            s.age = -20;
            // then it can give that values but they are invalid means age always not in negative and
            //  name not should be null so for that we can use Ecapsulation 
            // so first we make field as a private.
            Console.WriteLine(s.name);
            Console.WriteLine(s.age);*/
          /* person sc= new person();
            sc.Setname("ganesh");
            sc.GetName();
            sc.SetAge(10);
            sc.GetAge();*/
            // when we weite invalid data then it also get so for restrict that then we can write 
            // a condition in get and set method.

            Person sw= new Person();
           /* sw.SetName("gp");
            sw.GetName();
            sw.SetAge(1);   
            sw.GetAge();*/
            sw.SetName("");
            sw.GetName();
            sw.SetAge(-1);   
            sw.GetAge();

            Console.ReadLine();
        }
    }
}

/*
   In the Encapsulation, the variable of the class will be hidden from other classes, and can be accessed  
   only through the method and properties of their current class, therefore it also known the data hiding.

- in different way Encapsulation is a protective sheild that prevents that data from being accessed  by the 
 by the code outside this sheild.
- Encapsulation is the procedure Encapsuluting data and function in single unit(called class )
 
 how achive Encapsulation :

1. declare variable of the class(property) as a private
2.provide public getter and setter methods or property to mosify the value of variable

benifits:
1. the feild of the class can be made read-only and write-only.
2.A class can have total control over what is stored in its feild.

read only= get data 
write only = set data only

NEED OF ENCAPSULATION is to protect and private the code (data ) from Accidental curruption due to the 
silly little errors that we are all prone to make(prone = galati se).


 
 */
