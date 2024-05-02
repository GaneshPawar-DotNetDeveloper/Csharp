using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18.constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
             student student = new student();
            student.detail();
            student s1 = new student();
            s1.rollnumber = 1;  
            s1.firstname = "Test"; 
            s1.lastname = "drive";
            s1.detail();
            // object initilization syntax
            student s=new student()
            {
                rollnumber = 13,
                firstname="chaitanya",
                lastname="chavan"
            };
            student s3 = new student();
            s3.Initialization(12, "raj", "pawar");
            s3.detail();
            student s4 = new student();
            student s5 = new student();

            Console.ReadLine(); 



        }
    }
}
