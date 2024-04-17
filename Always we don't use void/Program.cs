using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Always_we_don_t_use_void
{        // ** void se hum value/data  return nahi kar sakate
    internal class Program
    {
        static void Main(string[] args)
        {
            //  firstname();
            // lastname();
            // ise karne se vo dega lekin alag alag dega 
            // so vo fullname nahi dega
            // iske liye hum called method me hum print n karake vaha se return lenge.
            string fn = firstname();
            string ln=lastname();
            string fullname = ("fullname is : " + fn +" "+ln);
            Console.WriteLine(fullname);

            Console.ReadLine();
        }
      /*  static void firstname()
        {
            string fn = "ganesh";
            Console.WriteLine(fn);
        }
        static void lastname()
        {
            string lname = "pawar";
            Console.WriteLine(lname);
        }*/

        static string firstname()
        {
            string fname = "ganesh";
            return fname;
        }
        static string lastname()
        {
            string lname = "pawar";
            return lname;
        }

    }


}
