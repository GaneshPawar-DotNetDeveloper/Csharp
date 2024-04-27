using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using companyLiabrary;
using static companyLiabrary.company;

namespace companyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){Id=1,Name="suraj",gender="male",exprience=4},
                new Employee(){Id=2,Name="ganesh",gender="male",exprience=3},
                new Employee(){Id=3,Name="pruthvi",gender="male",exprience=2},
                new Employee(){Id=4,Name="raj",gender="male",exprience=3},
                new Employee(){Id=5,Name="udaysingh",gender="male",exprience=6},
                new Employee(){Id=6,Name="padmsingh",gender="male",exprience=7},
                new Employee(){Id=7,Name="bhavika",gender="female",exprience=1}
            };
            company sc = new company(employees);

            promotedelegate del = promotelogic;
            sc.pramoteEmployee(del);
            Console.ReadLine();

        }
        static bool promotelogic (Employee employee)
        {

            // here user can write multiple logic 
           return employee.gender.Equals("female");
           // return employee.Name.StartsWith("w");
          //  return employee.exprience.CompareTo(employee.exprience) == 3;
        }
    }
}
