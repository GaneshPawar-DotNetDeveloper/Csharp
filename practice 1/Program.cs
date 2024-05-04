using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    internal class Program
    {
        private static string s;

        static void Main(string[] args)
        {
            //          Console.WriteLine("hello world");
            //        //  Console.ReadLine();
            //          int a = 12;
            //          Console.WriteLine(a);
            //          Console.WriteLine();
            //          //  Console.ReadLine();
            //          bool b = true;
            //          int c = 12, d = 12;
            //Console.WriteLine($" value of a=:{a}\t,\n value of b=:{b}\t,\n value of c=:{c}\t,\n" +
            //              $" value of d=:{d}");
            //          // Console.ReadLine();
            //          Console.WriteLine($"{a},: {sizeof(byte)} ");
            //          Console.ReadLine

            //            Console.WriteLine("hello vidhyadevi");
            ////object console = null;
            //         //  Console.ReadLine();
            //            Console.WriteLine(DateTime.Now);
            //            Console.ReadLine();

            //for (int j = 20; j <= 80; j++)
            //{

            //   j % 2 == 0;


            //    Console.WriteLine(i);


            //}
            //Console.ReadLine();

            //  int k = 10;
            //  k++;
            //  Console.WriteLine(k++);
            //  Console.WriteLine(k);
            //  k += 5;
            //  k -= 20;
            //  Console.WriteLine(k);
            //  Console.WriteLine(sizeof(byte));
            //  Console.WriteLine(sizeof (short));
            //  Console.WriteLine(sizeof (ushort));
            //  Console.WriteLine(sizeof (decimal));
            //  //
            //  //Console.ReadLine();
            //  string name = "          ganesh_pawar";
            //  Console.WriteLine(name.Length);
            // //Console.ReadLine();
            // Console.WriteLine(name);
            //  Console.WriteLine(name.Trim());

            // // Console.ReadLine();
            // Console.WriteLine(name.ToLower());
            //  Console.WriteLine(name.ToUpper());
            //  //Console.ReadLine();
            //  string names = "\'ganesh\'";
            //  Console.WriteLine(names.Length);
            //  Console.WriteLine(names);
            //  //
            //  //Console.ReadLine();
            //  Console.WriteLine($"{$" names"}");
            //  // Console.ReadLine();
            //  Console.WriteLine("ganesh\tpawar");
            //  Console.WriteLine("ganesh\npawar");
            ////  Console.ReadLine();
            //  string nam = @"ganesh pawar";
            //  Console.WriteLine(nam);
            // Console.ReadLine();
            // concatation  == its used for join two or more string values
            // 1. plus operator
            // 2. concat operator
            // 3. join operator
            // 4. placeholder operator 
            // 5. string interpolation operator 
            //string first_name = "Ganesh";
            //   string middle_name = " khanderao ";
            //   string last_name = "pawar";
            //   string fullname;
            // 1. plus operator (space)
            //string    fullname = first_name +  last_name;
            // Console.WriteLine(fullname);
            // // Console.ReadLine();
            // //string fullnames =first_name +"  \n     "+ middle_name;
            // //Console.WriteLine(fullnames);
            // //Console.ReadLine();
            // string fullnames = first_name + "  " + middle_name;
            // Console.WriteLine(fullnames);
            // Console.ReadLine();

            // 2. concat
            //fullname = string.Concat(first_name, " \t   \n ",middle_name) ;  
            //Console.WriteLine( fullname );
            //Console.ReadLine();
            //fullname=string.Concat(first_name, middle_name, last_name);
            //Console.WriteLine(fullname);
            //Console.WriteLine($"first name is : {first_name}\nmiddle name is :{middle_name}\n" +
            //  $"last name is : {last_name}");
            //Console.ReadLine(); 
            // string fullnamee = string.Concat(first_name + middle_name+last_name);
            //Console.WriteLine(fullnamee);
            //Console.ReadLine();

            // 3. join operator
            // fullname=string.Join(" ",first_name,middle_name,last_name);
            //Console.WriteLine(fullname);
            //Console.ReadLine();
            //fullname = string.Join("", "fullname  ",": ",first_name,middle_name,last_name);
            //Console.WriteLine(fullname);
            //Console.ReadLine();
            // 4. spaceholder syntax
            //fullname=string.Format("fullname:{0}{1}{2}",first_name,middle_name,last_name);
            //Console.WriteLine(fullname);
            //Console.ReadLine();

            // 5. string interpolation 
            //fullname = $"fullname : {first_name}\t{last_name}";
            //Console.WriteLine( fullname );
            //Console.ReadLine();
            //string w=$"my name is : {first_name}";
            //Console.WriteLine(w);
            //Console.ReadLine();

            //// datatype  conversion
            // there are two conversion methods 
            //    1. implicit conversion 
            //    2. explicit conversion 
            //1. implicit conversion:
            //   - Automatically done by compiler .
            //   - Implicit conversion done only if -
            //a. when there is no loss of data 
            //b. when there is no chances on runtime error.

            //int i=10, j=20, k=30;
            //            int h= i+j, m= j+k;
            //            Console.WriteLine($"{h}:{k}");
            //            string a=i.ToString();   // 
            //            string b=j.ToString();
            //            string c=k.ToString();
            //            Console.WriteLine(a+b+c);
            //            Console.ReadLine();

            // 2. explicit conversion

            // there are two type of explicit conversion 
            //1. casting type
            //2. class method
            //3. parse() method
            //4. tryparse() method
            //        float f1=10;
            //// example 1
            //int i1 = (int)f1;
            //        Console.WriteLine(i1);
            //        // Console.ReadLine(); 

            //        //2.
            //        string s = "100";
            //        // i1 = (int)s;

            //        // when we try to convert string value in int type then it is not possible
            //        // so for that we use class method
            //        // 2. convert class method 

            //        i1 = Convert.ToInt32(s);
            //        Console.WriteLine(i1);
            //        //Console.ReadLine();
            //        // string s1 = "ABCD";
            //        // i1 = Convert.ToInt32(s1);
            //        //i1 = Convert.ToChar(s1);
            //        // Console.WriteLine(i1);


            //        //We can convert string value in boolean type
            //        s = "true";
            //        bool bb=Convert.ToBoolean(s);
            //        Console.WriteLine(bb);
            //        Console.ReadLine();
            //        // when we can convert string to another any type then we can use 
            //        // 3. parse() and try parse () method 
            //   int i12 = 0;

            //string ss = "100";
            //i12= int.Parse(ss);
            //Console.WriteLine(i12);
            //Console.ReadLine();

            //string a = "A";
            //i12=char.Parse(a);
            //Console.WriteLine(i12);
            //Console.ReadLine();
            //string s = "xys";
            //i12=int.Parse(s);
            //Console.WriteLine(i12);
            //Console.ReadLine();
            //for that we can use try parse () method
            // its handle the run time error
            //          s = "1000";
            //bb=int.TryParse(s, out i12);

            //** nullable type
            //null means absence of value
            //int age=null; --it is non-nullable value
            // bool indian=null; --it is non-nullable value
            // so what is nullable type 
            //--- it is brigde between sql and C# type(means that in sql int value is null but
            //in C# their value is not null)
            // so it is bridge between SQL andC# type
            // int = non-nullable
            // int?= nullable
            //int? age = null;
            //bool? @bool = null;
            //Nullable<int> bb = null;
            //Console.WriteLine(age);
            //Console.WriteLine(@bool);
            //Console.WriteLine(bb);
            // Console.ReadLine();


            // ? -> its stands for to make type nullable
            //??->  its stands for to convert nullable type to non nullable type
            //?== nullable value
            //??== null colease operation
            // syntax for ?? is 
            // datatype + variable=nullable variable ?? 0;
            // Example:
            //int? a = 10;
            //int b = (int)a;
            //Console.WriteLine($"A:{a}\n B :{b}");
            //Console.ReadLine();
            //int ? a= null;
            //int b = a ?? 0;
            //Console.WriteLine($"a:{a}\n b:{b}");
            //Console.ReadLine();
            //int ? a= null;
            //int b = a ?? 1000;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();


            // ?. -> it helps to prevent null reference exception (run time exception)

            //string Email = null;
            //string EmailInUpper = Email.ToUpper();
            //Console.WriteLine($"Email:{Email}\n EmailInUpper : {EmailInUpper}");
            //Console.ReadLine(); 

            // its give null reference exception
            // so for avoid that run time exception we can use ?.
            //string email = null;
            //string emailInUpper = email?.ToUpper();
            //Console.WriteLine($"Email is: {email} \n EmailINUpper is : {emailInUpper}");

            //string emaill = "ganesh.pawar@gmail.com";
            //string emaillInUpper= email?.ToUpper();
            //Console.WriteLine($"Email is: {emaill} \n EmailINUpper is : {emaillInUpper}");
            //Console.ReadLine();


            // conditional statements :
            // its control the flow of programming
            // In Conditional statement we have see
            //1. if statement 
            //2. if_else statement 
            //3. if_else_if else ladder
            //4. nested if statement
            //5. switch statement
            //6. ternary operator

            // 1. if statement 
            // --- if condition was true then return if statement
            // Example:
            //int i = 10;
            //if (i == 10)
            //{
            //    Console.WriteLine($"If condition is true then return {i}");

            //}
            //Console.ReadLine() ;
            // 2. if_else statement:
            // when condition was true then it return if part
            // when condition was false then it return else part
            //int i = 13;
            //if(i == 13) 

            //    Console.WriteLine($"{i}: true");


            //else
            //{
            //    Console.WriteLine($"{i}: false");
            //}
            //Console.ReadLine();

            //3.ternary operator
            // ternary operator means that it is simplified way to write if_else block
            // syntax:
            //  (condition)?statement1:statement2
            // when condition was true then it return statement1 
            // and when condition was false then it returns statement2
            //int i = 10;
            //string result = (i == 11) ? "TEN" : "NOT TEN";
            //Console.WriteLine($"result is {result}");
            //Console.ReadLine();


            // when we have more than two condition then we can use if_else ladder
            //4. if else_if else ladder

            //int i = 12;
            //if (i == 10)
            //{
            //    Console.WriteLine($"{i}:TEN");

            //}
            //else if(i==20) 
            //{
            //    Console.WriteLine($"{i}:TWENTY");

            //}
            //else if (i == 30)
            //{
            //    Console.WriteLine($"{i}:THIRTY");
            //}
            //else
            //{
            //    Console.WriteLine($"{i}: not match" );
            //}
            //Console.ReadLine();

            // Switch statement:
            // it is alternate of if-else statement
            // in switch statement we can need give the switching parameter == switch(i)
            // example:
            //int i = 12;
            //switch (i)
            //{
            //    case 10:
            //        Console.WriteLine($"{i}: TEN");
            //        break;
            //    case 20:
            //        Console.WriteLine($"{i}:TWENTY");
            //        break;
            //    case 30:
            //        Console.WriteLine($"{i}:THIRTY");
            //        break;
            //    default:
            //        Console.WriteLine($"{i}: NOT match 10 ,20,30");
            //        break;
            //}
            //Console.ReadLine();

            // comparission if else statement 
            // neasted if statement :1
          //  Console.WriteLine("please enter first number");
          //  int first = int.Parse(Console.ReadLine());
          //  Console.WriteLine("please enter second number ");
          //  int second = int.Parse(Console.ReadLine());
          //  Console.WriteLine("please enter third number");
          //  int third = int.Parse(Console.ReadLine());
          //  Console.WriteLine($"you enterd {first},{second},{third}");
          ////   Console.ReadLine();

          //  if (first > second)
          //  {
          //      if (first > third)
          //      {
          //          Console.WriteLine($"{first} is grater number");
          //      }

          //      else
          //      {
          //          Console.WriteLine($"{third}is greater number");
          //      } }

          //              else if (second > first)
          //  {
          //      if (second > third)
          //      { Console.WriteLine($"{second} is greater number");
          //      }

          //      else
          //      {
          //          Console.WriteLine($"{third} is greater number");
          //      } }
                   
          //  else 
          //  {
          //      if (first > third) {
          //          Console.WriteLine($"{first},{second} are greater number");
          //      }
          //      else
          //      {
          //          Console.WriteLine($"{third} is grater number");
          //      }
          //  }
           
           // int number = (first>)


















            Console.ReadLine();
















            


























































        }
    }
}
