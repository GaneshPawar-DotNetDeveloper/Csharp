using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Anomonous type : type without name.
            /*
             ?? a=10;    --> int
            ?? s="ganesh"; --> string
           ?? s= new student(){firstname="suraj",lastname="pawar"}; --> student
            ?? a= new {id=10,name="ganu"};  // here we can use object type 
                                           // but when we can call a.id then it give error   
                                           // becoase object is base type o uske method access karega
             // that is anominous type- type without name
            // so for that we can use var

             var a=new {id=10,name="ganesh"};

             so 
               var i=10;
               - after this line i type always  "int"
               i="ganesh";
                // so we can not store string value in i 
                // they give error we can not convert emplicitly int to string


             */
            var s = new student();
            s.print();
            // here it work var get type of student

            object s2= new student();
            //  here it works because object is base class for all datatypes
          //  s2.print();
            // but it can't call print method because print method is in student type.

            // var keyword checks complile time.






            
            
           
            Console.ReadLine();

        }
    }
    public class student
    {
        public string firstname;
        public string lastname;
        public void print()
        {
            Console.WriteLine("print method");
        }
    }
}
