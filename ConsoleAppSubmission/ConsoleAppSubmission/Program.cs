using System;


namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main()
        {
            //initiate a variable
            int i = 1;
            //while i is less than 5 print i to the console
            while (i<5)
            {
                Console.WriteLine(i); //print i
                i++; //increase i by 1
            }

            //initiate another variable
            int x = 10;
            //do this loop while the condition below is still being met
            do
            {
                Console.WriteLine(x); //print x
                x++; //x increase by 1 every loop
            }
            while (x>10 && x<15); //while x is greater than 10 and less than 15

            Console.ReadLine();
        }
    }
}
