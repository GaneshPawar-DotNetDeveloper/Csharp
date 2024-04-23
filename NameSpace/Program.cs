
using house;
using house.ganesh.pawar;
using house.school;
using System;

namespace NameSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*   
             when we open visual studio then we create
            * first we create
            * 1.solution
            * 2.project
            * 3.assembly -- jo project ka nam hota he vahi assembly ka nam hota he
            * 4.NameSpace
                and in the name space there are class,enum,interface present
            ** NAMESPACE :
             -- Its a container which contain another namespace or type like class,
                interface,deligate,enum
             */
            people e = new people();
            hall h = new hall();
            house.garden s = new house.garden();
            //house.student  = new h ouse.student();
            house.school.student sc = new house.school.student();
            smart ew = new smart();
            ew.gkp();       
            //Console.WriteLine(ew);
            //  Console.ReadLine();
        }
    }
}
namespace house
{
    public class hall { }




    public class garden { }
    public class people { }

    namespace school
    {
        public class student { }
        public class halls { }
        public class teacher { }
    }
    namespace ganesh
    {
        namespace pawar
        {
            public class smart
            {
                public void gkp()
                {
                    Console.WriteLine("hello ganesh pawar");
                    //Console.ReadLine();
                }

            }
        }
    }
}

