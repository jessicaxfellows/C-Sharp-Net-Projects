using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //Title
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            //Ask student questions and record replies
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything ? Please answer “true” or “false.");
            string needHelp = Console.ReadLine();
            bool neededHelp = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursTotal = Convert.ToInt32(studyHours);


            //Thank you - end 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();
        }
    }
}
