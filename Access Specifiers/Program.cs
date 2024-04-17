using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Access Specifer
            // -- it control of scope or acssecibility of type and type members
            // type- class, structure, enum , delegate
            // members- method is a type of member, feild is a type of member  


            // type of specifers :
            // 1. private
            //  -  Accesiblility containing within only that type(type)  
            // 2. protected
            // - - within containing type and derived type  (matlab child class ko)
            // 3. public
            // -- access everywhere or anywhere
            // 4. internal
            // -- whitin only  same assembaly ( matlab vo same aseembly me access hoga ,dusre
            //      assembly me access nahi hoga)
            // 5.  protected internal
            // it is  both combination of protected and internal  access specifier.

            // we can dreate constructor private and protected.
            // when we create private and protected constructor then it get not allowed to create object
            // it use to restrict user to create object of that class.

        }
    }
}
