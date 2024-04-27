using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyLiabrary
{
    public class company
    {
        public delegate bool promotedelegate(Employee employee);

        // so here one company have multiple employees
        // we create arrayx
         Employee[] _employees;

        // so now we create a parameterized constructor


        public company(Employee[] employees)
            {
               _employees = employees;
            }

            // so ye humne class liabray reate ki he to hum is laibrary ko kisi ko bhi share kar sakate he.

        //So now we can write a logic for pramote our employee:

        // jab hum ise method ko call karenge tab uske bande pramote ho jayenge.
        public void pramoteEmployee(promotedelegate del)
        {
            if(_employees != null && _employees.Length > 0)
            {
                for(int i = 0; i < _employees.Length; i++)
                {
                    if (del(_employees[i]))
                    {
                        Console.WriteLine($"{_employees[i].Name} is promoted");
                    }
                }
            }
            else
            {
                Console.WriteLine("there are no employee pramoted.");
            }

        }

        }
}
