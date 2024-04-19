using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a; == diclaration
             * int a=10; == declaration +initialization
             * a=11; == initialization
             * 
             * 
             * 
             * 
             * 
             * 
             * DataTypes is used to store variable value
             * types of datatypes 
             * 1.boolean datatypes -bool
             * 2.integer datatype - byte,short,int,long
             * 3.float datatype  - float,double,decimal
             * 4.string datatype - char,string
             * 5.object datatype 
             * 6.array datatype
             * 7.custom datatype
             for get size= console.write(sizeof(datatype_name);
            for get range=console.writeline(datatype.maxvalue);
                         = console.writeline(datatype.minvalue);
            -- in integer type bydefault value is int
            -- in floating type bydefault value is double
            int i; == that is a Declaration
            int i=10; == it is a Initialization
             
            * for finding a time ==Datetime.now   */

            int a = 23;
            byte b = 12;
            short c= 13;
            long d = 1234567890;
            float f = 123.23f;
            double g = 12345678909876543;
            decimal h = 123456789098765432123456789m;
            DateTime i= DateTime.Now;
            Console.WriteLine($" int value is {a}\n byte value is {b}\n shot value is {c}\n" +
                $" long value is {d}\n float value is {f}\n double value is {g}\n " +
                $"decimal value is {h}\n current time is {i}");
            Console.WriteLine($" size of short= {sizeof(short)}\n size of byte= {sizeof(byte)}\n" +
                $" size of int= {sizeof(int)}\n size of long= {sizeof(long)}\n" +
                $" size of float= {sizeof(float)}\n size of double= {sizeof(double)}\n" +
                $" size of decimal= {sizeof(decimal)}");
           // Console.WriteLine(sizeof(DateTime));
           Console.WriteLine($" range of int.min= {int.MinValue}\n rang of int.max= {int.MaxValue}\n" +
               $" range of double.min= {double.MinValue}\n range of double.max= {double.MaxValue}");
            Console.Write($" range of datetime.min= {DateTime.MinValue}\n" +
                $" range of datetime.max= {DateTime.MaxValue}"); 
            Console.ReadLine();


        }
    }
}
