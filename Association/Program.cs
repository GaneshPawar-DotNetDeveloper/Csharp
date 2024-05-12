using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            department s= new department();
            employee sw= new employee(d);

            Console.ReadLine();
        }
    }
    public class department
    {

    }
    public class employee {
    public department dept { get; set; } // agreegation
    
        public employee(department d) {  // composition
        
       dept = d;
        }

    }
}
