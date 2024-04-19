using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
   public class DataType_Categories
    {

        public void print()
        {


            /*                     datatypes 
                       1.value type: 
                         -- size are fix, ex: int,short,long,decimal,double...
                       2. reference type :
                        -- size are not fix ,ex: array,string,object,class,interface 

                        ** memory alocation:
                        * for value type:
                         - actual value store in stack area
            ex: int i=10;
                        * for reference type :
                         - actual value/object store in heap and there reference 
                            stored in stack
                           ex: customer sc= new customer () ;
                              here customer object store in heap memory but
                              its reference sc stored in stack memory
                         */
            /*
             2. memory deallocator:
                   i. for value type :
                       when value type variable  goes out of scope then it get removed from stack memory
                 ii. for reference type:
                      when reference type value goes out of scope then its reference vaeiable get removed
                       from stack memory.but
                        value or object still remain in heap memory .which get remove later by help of 
                        garbage collector (GC method)
               ex:
               int i=12;
             main (){
            customer sc= new customer
            }}       when main method get complete execution then we say out of scope

             // jis value/object ko kohi refer nahi kar raha use hum garbage bolenge or
                 usko remove garbage collector karega
             --gc is feature of CLR (.net fundamental)
                     * object type:

                       - it is a base type for all types in dot net  */

            /*object o = 10;
            Console.WriteLine(o);
*/






            Console.WriteLine();





            Console.ReadLine();
        }
    }
}

