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
            ////instantiate employee class, assign first and last, call sayname method
            //Employee example = new Employee();
            //example.FirstName = "Sample";
            //example.LastName = "Student";
            //example.SayName();

            ////create an object of type Iquit and call Quit() on it - interface thru employee class
            //IQuittable example2 = new Employee();
            //example2.Quit();

            ////instantiate two objects of emp and assign values to props, then compare with overloaded 
            //Employee example3 = new Employee();
            //Employee example4 = new Employee();
            //example3.ID = 123;
            //example4.ID = 456;
            //bool result = example3 == example4;

            //instantiate emp obj with string as it's generic param
            Employee<string> strings = new Employee<string>();
            strings.things = new List<string> { "Jess", "Jp", "Nami" };
            //instantiate emp obj with int as it's generic param
            Employee<int> numbers = new Employee<int>();
            numbers.things = new List<int> { 1, 2, 3, 4 };
            for (int i = 0; i < strings.things.Count; i++ )
            {
                Console.WriteLine(strings.things[i]);
            }
            for (int i = 0; i < numbers.things.Count; i++)
            {
                Console.WriteLine(numbers.things[i]);
            }

            Console.ReadLine();
        }
    }
}
