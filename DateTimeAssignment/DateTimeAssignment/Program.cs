using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //print current date and time to console
            DateTime now = DateTime.Now; //create a datetime obj and access now
            Console.WriteLine("Current date and time is: " + now);

            //ask user for a number
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            //create new date time and use "add hours" 
            DateTime nowPlus = now.AddHours(number);

            //print what time it will be in ^ the number of hours the user inputs
            Console.WriteLine("In {0} hours, it will be: {1}", number, nowPlus);
            Console.ReadLine();
        }
    }
}
