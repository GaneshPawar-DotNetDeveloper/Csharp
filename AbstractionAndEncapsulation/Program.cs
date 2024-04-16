using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*     
          1. Abstraction: 
                - To show the information to the world (relevent Information)
                - its a design phase.(means imagine condition (factory) ) 
                - it gives what ? Question Answer. (what is expose)
                - ex: mobile me hum screen dekhate he to hume side me vol+,vol-,power ke button rahate he
                    or hum screen dekh sakate he that is abstraction.
                - abstraction is nothing without Encapsulation .
                - in code public and internal is Abstraction

            2.Encapsulation: 
              - To hide imformation for outside world(not relevent information)
              - its a impliment phase (means we create ex: showroom)
              - it give how ? Question Aswser (how its expose/working)
              - in code private is encapsulation
              - humne mobile screen and volume press ka example abstraction ke liye liya tha 
                usme uske bad jo inter logic work hota he vo Encapsulation hota he.
               - lodgic inside method.
               - ex: console.writeline (that method impliment in inner part )
              
            -- frontend is abstraction and backend is encapsulation
            -- hum hamri exe file share karenge to user use double click karake open karega to jo file 
hum share kar rahe he vo abstraction he , or jo uske under logic hoga vo encapsulation hoga .
        
  
 */
             Student student = new Student() { FirstName="ganesh",LastName="pawar"};
            student.Insert();
            //   student.IsValidData();
            student1 sc = new student1("ganesh","pawar");
            sc.PrintFullName();
          string s=  sc.GEtFirstName();
            Console.WriteLine(  s);
            // here GEtfirstName we can see so it is Abstraction 
            // and in that code how it process and how get logic that is encapsulation(vo kya dene vala he)

            // these are only oops piller we do not use separetly in code.
            Console.ReadLine();
        }
    }
    public class Student
    {
        public string FirstName;
        public string LastName;

     private bool IsValidData()
        {
            // logic that data if that data is valid or not
            return true;
        }
        public void Insert() // it is abstraction.

        {
            if (IsValidData()) // it is Encapsulation
            {
                //
            }
            else
            {
                //
            }
        }
    }


    public class student1
    {
        public string FirstName;
        public string LastName;
        public student1(string Fn,string ln)
        {
            FirstName = Fn;
            LastName = ln;
        }
        public void PrintFullName()
        {
            Console.WriteLine($"fullname : {FirstName} {LastName}");
        }
        public string GEtFirstName()
        {
            return FirstName;
        }
        // in that example we can return firstnaame value so that is Abstraction
        // but in that mwthod hidden logic is encapsulation 
        // we can call that method with call that method
    }
}
   // how to Achive Abstraction and Encapsulation:
/*
 * 
 for Ex: 1. A Method:
       Abstraction: return type ,method name,parameter
       Encapsulation: logic inside method
             means that logic was hidden (console.writeline())
2. A abstract class and A Interface
      Abstraction : interface and its method declaration
      Encapsulation: a class who is Actually implements that interface
                    - ho use inherite karake logic likh raha he.
3. TV Remote :
      abstraction: remote mute button
      Encapsulation : insid remote that chep  
     so without chep we can not accees mute button.
 
 
 
 */