using System;
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

            Console.ReadLine();
        }
    }
}
