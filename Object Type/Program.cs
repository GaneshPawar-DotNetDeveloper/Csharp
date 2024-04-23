using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*         
                     Object type is base type for all types in dot.net

             -- there are commanly four methods in object type.
              1. Gettype - we can't get override , so it is not virtual
              2. ToString  - virtual
              3. Equals   - virtual
              4. GetHashCode - virtual

             ex:
            int i = 10;
            i.ToString();
           Console.WriteLine(i.ToString());
            i.Equals(10);
            i.GetType();
            i.GetHashCode();
            Console.WriteLine(i);
            student sc = new student();
            sc.Equals(sc);
            sc.ToString();
            sc.GetHashCode();
            sc.GetType();
            // so it is prve that object is base class for all type
            */
            // 1. GetType:
            // we can use this method to get information about type(namespace,name,type)
            // we can fetch more information of that type.
            // it give more information about that type.

            // Gettype ka return type "TYPE" he
            /*  int j= 10;
              Type i = j.GetType();
              Console.WriteLine(i);
              Console.WriteLine(i.Name);
              //            Console.WriteLine(i.Assembly);
                Console.WriteLine(i.Namespace);
              //          Console.WriteLine(i.Assembly.GetName().Version.ToString());
              //        Console.WriteLine(i.FullName);
             // Console.WriteLine("-----------------");
              string bs = "ganesh";
              Type k= bs.GetType();
              Console.WriteLine(k);
              Console.WriteLine(k.Name);
              Console.WriteLine(k.Namespace);
             // Console.WriteLine("-------------------------");

              student sw= new student();
            Type s2= sw.GetType();
              Console.WriteLine(s2.Name);
              Console.WriteLine(s2.Namespace);
              // 2. To string ():*/
            // we can use this method to get string representation of any type.
            // eg :- string i= 10;
            /* string f = "10.4";
             string b = "true";
             string f2 = "23.433f";
 */
            /* int  a= 10;
              string b= a.ToString();
              Console.WriteLine(b);
              // we cn represnt int a value as string value
              float f = 10.34f;
              string s2=f.ToString();
              Console.WriteLine(s2);

              student sc=new student("ganesh","pawar");
              string ss=sc.ToString();
              Console.WriteLine(ss);
              // so when we use tostring method with complex type then it give us fully qualified name
              // i.e namespace.typename
              // but if we want meaningful representation for complex type then we can override To string
              // method
              // we override for get meaning ful representation.

              // so for overide we go in student class and type override + to string method
  */
            // 3. equals:
            // equals method we can use for comparision 
            //( also we have "==" operator for comparision )

            int a = 10;
            int b = 10;
            //int b = a;
            if (b.Equals(a))
            {
                Console.WriteLine("a and b equal");

            }
            else
            {
                Console.WriteLine("not equal");
            }

            student sc = new student("ganu", "pawar");
            //  student sc1 = sc;
            student sc1 = new student("ganu", "pawar");
           // if (sc.Equals(sc1))
              if(sc1.GetHashCode()==sc.GetHashCode())
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }
            // here equal method checks for reference equality and not value equality
            // so if we want to check value equality then we need to overide equals method.





            Console.ReadLine();
        }
    }
    public class student
    {
        private string _firstName;
        private string _lastName;
        public student(string fn, string ln)
        {
            _firstName = fn;
            _lastName = ln;

        }
        public override string ToString()
        {
            // return base.ToString();
            return _firstName + " " + _lastName;
        }
        // for get meaningful representation for complex type then we can override the tostring method.
        // because ToString is virtual in object class. 
        public override bool Equals(object obj)
        {
            student s = (student)obj;
            return this._firstName.Equals(s._firstName) && this._lastName.Equals(s._lastName);
        }

        // when we override equals method, then it give warning you also override hashcode method
        // when we create reference then it allocate hashcode
        // it is used for get unique hash code for every value in memory.

        public override int GetHashCode()
        {
            return _firstName.GetHashCode() ^ _lastName.GetHashCode();
            // ^ = cab = combine
        }
    }
}
