using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    public class Person
    {
        //two properties for name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //void method with no params, prints name 
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
