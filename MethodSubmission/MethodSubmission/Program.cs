using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math newMath = new Math(); //instantiate class

            Console.WriteLine("Enter a number:"); //ask user for first number
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number, this is optional (hit enter either way):"); //ask user for first number
            int num2; //create a variable for second number if it's inputted

            if(int.TryParse(Console.ReadLine(), out num2)) //check if they inputted a second number 
            {
                Console.WriteLine(newMath.methodOne(num1, num2)); //if they did, print result with both numbers
            }
            else
            {
                Console.WriteLine(newMath.methodOne(num1)); //if not, then print result with only the first number entered
            }


            Console.ReadLine();
        }
    }
}
