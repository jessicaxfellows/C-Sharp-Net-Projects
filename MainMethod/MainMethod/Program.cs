using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10; //create integer
            Maths firstClass = new Maths(); //instantiate a class
            Console.WriteLine(firstClass.methodOne(x)); //call first method, pass int and display result

            decimal y = 25.0m; //create decimal
            Maths secondClass = new Maths(); //instantiate class again
            Console.WriteLine(secondClass.methodOne(y)); //call second method, pass decimal and display result

            string z = "50"; //create string
            Maths thirdClass = new Maths(); //instantiate class again
            Console.WriteLine(thirdClass.methodOne(z)); //call third method, pass string and display result


            Console.ReadLine();
        }
    }
}
