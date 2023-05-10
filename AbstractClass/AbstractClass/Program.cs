﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee class, assign first and last, call sayname method
            Employee example = new Employee();
            example.FirstName = "Sample";
            example.LastName = "Student";
            example.SayName();

            //create an object of type Iquit and call Quit() on it - interface thru employee class
            IQuittable example2 = new Employee();
            example2.Quit();

            //instantiate two objects of emp and assign values to props, then compare with overloaded 
            Employee example3 = new Employee();
            Employee example4 = new Employee();
            example3.ID = 123;
            example4.ID = 456;
            bool result = example3 == example4;


            Console.ReadLine();
        }
    }
}