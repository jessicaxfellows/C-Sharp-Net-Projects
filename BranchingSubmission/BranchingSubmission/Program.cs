using System;


namespace BranchingSubmission
{
    class Program
    {
        static void Main()
        {
            //Title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Ask and record package weight
            Console.WriteLine("How much does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            //check if the weight is too heavy to ship
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            else
            {
                //Ask and record package width, height, and length
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                //Checks if the dimensions are still under capacity to ship
                int size = length + width + height;
                int dimensions = length * width * height;
                int total = dimensions * weight;
                int quote = total / 100;

                if (size > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                }
            }

            Console.ReadLine();
        }
    }
}
