using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // here i is the variable of int type 
            student s1; // here s1 is a variable of student type 
            // so s1 ia reference type
             student s2 = new student();
            s2.rollnumber = 1;
            s2.name = "suraj";
            s2.age = 25;
            s2.print();
            student s3 = new student();
            s3.rollnumber = 2;
            s3.name = "ganesh";
            s3.age = 24;
            s3.print();
            student.courseName="C#";
            student s4 = new student(); 
            s4.rollnumber = 3;
           // s4.name = "mahesh";
            s4.print();
           // s4.age = 250;
           // student.courseName;
          //  s3.create();
           

           Console.ReadLine();
        }
        class student  // this is class 
        {
          public   int rollnumber;
          public  string name;
          public  int age;// these are fields
            public static string courseName = ".net" ;


         public   void print() // this is method

            {
                Console.WriteLine($"rollnumber is: {rollnumber}\n name is : {name}\n " +
                    $"age is : {age}\n course nameis : {courseName}");

            }
public void create (int rn,string name,int age, string cn)
            {
                rollnumber = rn;
                name = name;
                age = age;
                courseName = cn;
            }
        

        } }
}






