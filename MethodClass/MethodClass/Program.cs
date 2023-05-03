using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math example = new Math(); //instantiate class
            int num1 = 15;
            int num2 = 5;
            example.methodOne(num1, num2); //call method and pass 2 numbers
            example.methodOne(num1: 15, num2: 5); //call method by the params name

            Console.ReadLine();
        }
    }
}
