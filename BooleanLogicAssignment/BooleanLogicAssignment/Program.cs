using System;


namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {   //Title
            Console.WriteLine("Insurance Application");
            
            //Asking and storing age variable
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);

            //Asking and storing DUI variable
            Console.WriteLine("Have you ever had a DUI? (True or False)");
            string dui = Console.ReadLine();
            bool duiNum = Boolean.Parse(dui);

            //Asking and storing ticket variable
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsNum = Convert.ToInt32(tickets);

            //Logic to determine if they qualify
            bool qualify = (ageNum > 15 && duiNum == false && ticketsNum <= 3);
            Console.WriteLine("Do you qualify for insurance? Answer: " +qualify);

            Console.ReadLine();


        }
    }
}
