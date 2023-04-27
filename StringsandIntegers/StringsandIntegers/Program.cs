using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //create list of integers
                List<int> nums = new List<int>() { 10, 25, 50, 100 };
                //ask for input
                Console.WriteLine("Enter a number:");
                int divNum = Convert.ToInt32(Console.ReadLine());
                //loop to divide each number by the user input from the list and print the result
                foreach (int numbers in nums)
                {
                    int quotient = numbers / divNum;
                    Console.WriteLine(numbers + " divided by " + divNum + " equals " + quotient);
                }
                Console.ReadLine();
            }
            //catch for wrong format of inputted value
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            //catch for dividing by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("The program is outside of the try/catch block.");
            }
            
            Console.ReadLine();
        }
    }
}
