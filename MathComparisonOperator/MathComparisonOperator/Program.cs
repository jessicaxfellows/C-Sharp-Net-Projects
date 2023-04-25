using System;


namespace MathComparisonOperator
{
    class Program
    {
        static void Main()
        {
            //Title
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //Person 1 input for salary comparison
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string persRate = Console.ReadLine();
            int persOneRate = Convert.ToInt32(persRate);
            Console.WriteLine("How many hours a week do you work?");
            string persHours = Console.ReadLine();
            int persOneHours = Convert.ToInt32(persHours);

            //Person 2 input for salary comparison
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string pers2Rate = Console.ReadLine();
            int persTwoRate = Convert.ToInt32(pers2Rate);
            Console.WriteLine("How many hours a week do you work?");
            string pers2Hours = Console.ReadLine();
            int persTwoHours = Convert.ToInt32(pers2Hours);

            //Print both salaries to the console
            int annualSalaryOne = persOneHours * persOneRate * 52;
            Console.WriteLine("Annual salary of Person 1: " + annualSalaryOne);
            int annualSalaryTwo = persTwoHours * persTwoRate * 52;
            Console.WriteLine("Annual salary of Person 2: " + annualSalaryTwo);
            bool compareSalary = annualSalaryOne > annualSalaryTwo;

            //Compare each salary
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compareSalary);


            Console.ReadLine();
        }
    }
}
