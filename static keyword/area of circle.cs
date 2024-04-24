using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    internal class area_of_circle
    {

      public  int radius;
       public float pi = 3.24f;
        

    
    public void area()
    {
        Console.WriteLine($" area of circle is : {pi* radius* radius}");
    }

public static  string Circle()
        {
            return "circle";
        }


    }
}
