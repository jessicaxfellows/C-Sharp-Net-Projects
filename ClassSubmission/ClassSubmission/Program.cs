using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math example = new Math(); //instantiate class
            Console.WriteLine("Please enter a number: "); //ask for a number
            int num1 = Convert.ToInt32(Console.ReadLine());
            int quotient; //create a variable to hold result
            example.methodOne(num1, out quotient); //call mehtod on inputted number, out result
            Console.WriteLine("Your number divided by 2 is: " + quotient); //print result

            int addition; //variable to hold result of overloaded method
            example.methodOne(num1, 5, out addition); //3 params to use overloaded method
            Console.WriteLine("Your number plus by 5 is: " + addition); //print result

            Class2.showText(); //static class, dont have to instantiaite 

            Console.ReadLine();
        }
    }
}
