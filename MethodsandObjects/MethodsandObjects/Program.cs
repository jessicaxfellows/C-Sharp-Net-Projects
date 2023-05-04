using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee class object with name
            Employee example = new Employee();
            example.FirstName = "Sample"; //assign first name and last name to emp object
            example.LastName = "Student";
            example.SayName(); //call superclass method
            Console.ReadLine();
        }
    }
}
