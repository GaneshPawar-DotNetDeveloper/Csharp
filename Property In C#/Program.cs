using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student s=new student();
          //  s.id = 1;    // its give set method
            Console.WriteLine(s.id); // its give get method
            // but here user give invalid value so for that we write a condition in set method
            s.id = -1;


            student s2=new student();
            s2.name = "";
            Console.WriteLine(s2.name);

            student s3= new student();
            s3.age = -10;
            Console.WriteLine(s3.age);





            Console.ReadLine();
        }
    }
    public class student
    {
         int _id;
       string _name;
        int _age;

        // here we give filed as _id because we understand the difference between feilds and property.
       
        public int id
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("you enter invalid id\n");
                }
                else
                {
                    this._id = value;
                }
            }
            get
            {
                return _id; 
            }
        }
        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(_name) == true)
                {
                    Console.WriteLine("pelase enter the name");
                }
                else
                {
                    _name = value;

                }
            }
            get
            {
                return _name;
            }
        }
        public int age
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("that is invalid age");

                }
                else
                {
                    this._age = value;
                }
                
            }
            get
            {
                return _age;
            }
        }

    }

}
