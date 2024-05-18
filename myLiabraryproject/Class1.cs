using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLiabraryproject
{


    public delegate void printdelegate();
    public class Class1
    {


        public void printmethod(printdelegate a )
        {
            a();
        }
    }
}
