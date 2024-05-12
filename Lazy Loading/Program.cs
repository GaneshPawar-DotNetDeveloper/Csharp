using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Loading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coustomer sc= new coustomer();
            Console.WriteLine(sc.name);
            /*foreach (order item in sc.orders)
            {
                Console.WriteLine($"{item.orderid}-  {item.orderdescription}");
            }*/

            foreach (order item in sc.orders.Value)
            {
                Console.WriteLine($"{item.orderid}-{item.orderdescription}");
            }

            // so here when we open that application that time i don't show that order bcs when i go to order 
            // option that time it go for all orders, but now i want to create order as laxy.
            // so for we can make which property item mqake laxy so give prifex laxy word.

            Console.ReadLine();

        }
    }

    public class order
    {
        public int orderid { get; set; }
        public string orderdescription { get; set; }
    }


    public class coustomer {
          public string name {  get; set; }
        public Lazy<List<order>> orders { get; set; }

        public coustomer() {

            /* name = "ganesh";
             orders = GetOrders();*/

            name = "pawar";
            Func<List<order>> func = GetOrders;
            orders= new Lazy<List<order>>(func);

        }
        public List<order> GetOrders()
        {
            List<order> orders = new List<order>()
            {

                // this retuen in database now we temporary provide hardcoded.
                new order(){  orderid=1,orderdescription="puma shoes" },
                new order(){  orderid=2,orderdescription="puma sandel" },
                new order(){  orderid=3,orderdescription="puma chappal" },
                new order(){  orderid=4,orderdescription="puma socks" },
            };
            return orders;

        }


    
    }


}
