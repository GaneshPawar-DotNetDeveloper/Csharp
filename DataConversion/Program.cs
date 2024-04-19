using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number");
            // int number=Console.ReadLine();
            // when we try to do this then they give error becouse readline written in
            // string type so in that case we convert string--> int
            /*        
             so there are data conversion
               1. implicit conversion:
             -- it atomatically done by compliler
               -- compliler do not coversion when 1. loss of data 2. when chance of runtime error
              2. explicit conversion:
              -- when compiler do not conversion then we get explicit conversion
                i.type cast conversion
                ii.covert class function
                iii.parse and try parse method
                iv. is and as keyword  
             */

            short s = 10;    // short  -->  int  // done by compliler 
            int s1 = s;                        // beacouse there size and range adjusted
            Console.WriteLine(s);

            int i = 10;   // int--> long
            long i2= i;
            Console.WriteLine(i);

           /* long j = i2;
            int j2 = j;*/
           // isme hum long ko int me convert kar rehe he to ye error dega kyuki there are
           // chance of data loss and chance to get runtime error
           // so for that we use implicit conversion like type cast conversion
           long j= i2;
            int a= (int)j;
            Console.WriteLine(a);
            float f = 12.34f;
            int c=(int)f;
            Console.WriteLine(c);

            // type cast can't convert string value in int 
            /* string aes = "123";
             int xv = (int)aes;
             Console.WriteLine(xv);*/
            // so for tht we can use convert class function:
            // convert method se almost all type hum convert kar sakate he
            // in that method we use like 
            string qwe = "123";
            int ij = Convert.ToInt32(qwe);
            Console.WriteLine(ij);

           string ws = "true";
            bool cn= Convert.ToBoolean(ws);
            Console.WriteLine(cn);
            // but we convert out of range then it get System.OverflowException.
            /*string mobile = "90115425750";
            int ds=Convert.ToInt32(mobile);
            Console.WriteLine(ds);*/

            // we change there type then it gives the System.FormatException. 
            /* string wq = "ABCD";
             int adf= Convert.ToInt32(wq);
             Console.WriteLine(adf);*/

            // so for that we use parse and try parse meth od
            //1. parse ():
            // parse method give same overflow and format error
            string number = "9011542575";
           // int z= int.Parse(number);
            long z= long.Parse(number);
            Console.WriteLine(z);
            // 2. try parse ()
            // it handle the runtime error 
            // try parse return boolean value
            // syntax: int.tryparse (input parameter, out ,)
            // string jh = "ABCD";
            string jh = "10";
            int isd;
            bool hh = int.TryParse(jh,out isd);
            Console.WriteLine(hh);
            Console.WriteLine(isd);

            // in that example  int isd is a declared variable 
            // so  jh is a input parameter and isd is a output parameter
            // so tryparse boolean return karata he 
            // 1. agar convwesion succefull ho gaya to apana status/result true aa jaye ga
            // or output parameter value return ho jaye gi
            // 2. or exception ke karan o false hua to false return karega or output parameter
            // me default value aa jaye gi.
            //  tryparse is very usefull method beacouse it not give exception

            // tryparse(i out j) == i is a string value & j is which type we want convert
               // so out keyword work i into j (string into int,double,float,etc...)
            string ww = "12365478900";
            int w1;
           Boolean w2=int.TryParse(ww,out w1);
            Console.WriteLine(w2);
            Console.WriteLine(w1);
            // isme w2 ke liye hume bool hi lena padega 
            string q1 = "8845296595696";
            long q2;
            bool q3= long.TryParse(q1,out q2);
            Console.WriteLine(q3);
            Console.WriteLine(q2);

            string r1 = "4521956.455451";
            decimal r2;
            bool r3= decimal.TryParse(r1,out r2);
            Console.WriteLine(r3);
            Console.WriteLine(r2);
            string b1 = "false";
            bool n=Convert.ToBoolean(b1);
            Console.WriteLine(n);
            bool n1;
            bool n2 = bool.TryParse(b1, out n1);
            Console.WriteLine(n2);
            Console.WriteLine(n1);


            // user input example:
           /* Console.WriteLine("please enter your first number");
            int first= int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your second number");
          int   second = Convert.ToInt32(Console.ReadLine());
            int addition = first+second;  
    string result = string.Format("{0} + {1}= {2}",first,second,addition);
            Console.WriteLine(result);*/
            //Console.WriteLine($" total addition is {addition}");

            Console.WriteLine("please enter your first number");

            int first;

            if (int.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("please enter your second number");

                int second;
                // = Convert.ToInt32(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out second))
                {
                    int.TryParse(Console.ReadLine(), out second);

                    int addition = first + second;
                    string result = string.Format("{0} + {1}= {2}", first, second, addition);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("please enter second valid number");
                }
            }
            else
            {
                Console.WriteLine("please enter first valid number");
            }

            Console.WriteLine();






            Console.ReadLine();

        }
    }
}
