using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Inhritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            course sr = new course() {studentfirstname="ganesh",studentlastname="pawar" };
            sr.printdetials();  
Console.ReadLine();
        }
    }
    public class course {
        public int id;

        public string studentfirstname;
        public string studentlastname;
        public string location;

        public void printdetials()
        {
            Console.WriteLine($"student full name is {studentfirstname} {studentlastname}\n" +
                $"student location is {location}");
        }


}
    public class dotNet {
        public string teachername;

    
    
    }
    public class java {
    public string teachername;
    }
}
