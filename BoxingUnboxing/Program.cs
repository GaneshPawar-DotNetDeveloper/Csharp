using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = 10;
            //object type is a base type for all type in dot net 
            // it is a reference type
            Console.WriteLine(o);
            /*
             1.Boxing: conversion of value type to reference type 
             2.unboxing: conversion of refrence type to value type
             these both are not good for performance
            */
            int i = 10;
            object os = i; // int->object, value->reference == boxing
            Console.WriteLine(os);
            int j = (int)o; // object->int,reference->value ==unboxing
            Console.WriteLine(j);
            float u = 12.3f;
            j = (int)u; // float->int ,both are value type so there is no boxing-unboxing
            Console.WriteLine(u);
  
  
  
  
  
  
  












            Console.ReadLine();
        }
    }
}
