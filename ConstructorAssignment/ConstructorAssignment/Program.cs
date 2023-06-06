using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const int number = 19;

            //create a var variable
            var name1 = "Jess";

            //create object with one varaible passed to the param
            sampleClass first = new sampleClass(name1);
            Console.WriteLine(first.firstName);

            //shows the first constrctor chained from the second and can print the name even without implementation 
            sampleClass second = new sampleClass();
            Console.WriteLine(second.firstName);

            Console.ReadLine();
        }
    }
}
