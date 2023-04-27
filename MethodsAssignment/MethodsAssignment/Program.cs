using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input, convert input to int
            Console.WriteLine("What number would you like to perform math operations on?");
            int number = Convert.ToInt32(Console.ReadLine());

            
            Math results = new Math(); //instatiate Math class called results
            Console.WriteLine(results.methodOne(number));  //call each method and print result
            Console.WriteLine(results.methodTwo(number));
            Console.WriteLine(results.methodThree(number));

            Console.ReadLine();
        }
    }
}
