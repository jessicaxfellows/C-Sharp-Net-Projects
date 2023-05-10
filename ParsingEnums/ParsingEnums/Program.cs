using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        //create enum for days of the way
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //ask user for a day of the week and store in string 
            Console.WriteLine("Please enter a day of the week:");
            string value = Console.ReadLine();

            //try catch to throw error if they enter something incorrect
            try
            {
                //Convert string entered to an enum
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine("That is a day of the week!");

            }
            //if they dont enter a matching value
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex);
            }

            Console.ReadLine();

        }
    }
}
