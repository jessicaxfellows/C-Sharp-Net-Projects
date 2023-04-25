using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statemetns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number:");
            //string num = Console.ReadLine();
            //int numOne = Convert.ToInt32(num);

            //if (numOne >= 10)
            //{
            //    Console.WriteLine("Your number is greater than or = to 10!");
            //}
            //else if (numOne <= 10)
            //{
            //    Console.WriteLine("Your number is less than or equal to 10!");
            //}
            //else if (numOne == 10) {
            //    Console.WriteLine("Your number is 10!");
            //}
            //else
            //{
            //    Console.WriteLine("There was an error.");
            //}

            //int x = 3;
            //int y = 10;
            //string result = x > y ? "x is greater than y" : "x is not greater than y";
            //Console.WriteLine(result);

            Console.WriteLine("What is your favorite number?");
            int favorite = Convert.ToInt32(Console.ReadLine());

            string result = favorite == 19 ? "you have an awesome fave number" : "you do not have an awesome favorite  number";
            Console.WriteLine(result);


            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());
            
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong.");
            //}

            //int currentTemp = 80;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "it is room temp" : "it is not room temp";
            //Console.WriteLine(comparisonResult);
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temp is greater than current temp.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp.");
            //}

            Console.ReadLine();
        }
    }
}
