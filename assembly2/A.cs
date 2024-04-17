using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembly2
{
    internal class A
    {
        public void print()
        {
            // hum is method ko similer type me hi sirf use kar sakte he 
            // hum uska access dusre class me nahi de sakate.

        }
        private void printA() { 
        
        print();
            // private Access spefifier me hum same class / type me access kar sakate he

        }
        protected void printB()
        {
           
        }

    }
}
