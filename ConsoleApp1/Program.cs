using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student sc=new student();
            sc.id = 1;
            sc.name = "ganesh";
            sc.gender = gender.male;


            student sc2= new student();
            sc.id=2; sc2.name = "suraj";
            sc2.gender = gender.male;

            student sc3= new student();
            sc3.id=3; sc3.name = "raj";
            sc3.gender = gender.male;

            Console.WriteLine($"the rollnumber is :{sc.id}\n  name is {sc.name}\n gender is {sc.gender}\n");
            Console.WriteLine($"the rollnumber is :{sc2.id}\n  name is {sc2.name}\n gender is {sc2.gender}\n");
            Console.WriteLine($"the rollnumber is :{sc3.id}\n  name is {sc3.name}\n gender is {sc3.gender}\n");
            Console.WriteLine(Enum.GetUnderlyingType(typeof(gender)));

           string[] name= Enum.GetNames(typeof(gender));

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

           int[] names= (int[])Enum.GetValues(typeof(gender));
            for (int i = 0;i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }



            Console.ReadLine();
        
        }
    }
    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public gender gender { get; set; }
    }
    public enum gender  { 
      male,
      female
    }
  /*  public enum gender  :byte{ 
      male,
      female
    }*/
}
