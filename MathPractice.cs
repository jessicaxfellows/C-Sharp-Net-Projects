using System;


namespace Math_Practice
{
    class Program
    {
        static void Main()
        {
            //int x = 10;
            //int y = 5;
            //Console.WriteLine("X is equal to: " + x);
            //Console.WriteLine("Y is equal to: " + y);
            //int addNum = x + y;
            //Console.WriteLine("X + Y is equal to: " + addNum);
            //int subNum = x - y;
            //Console.WriteLine("X - Y is equal to: " + subNum);
            //int mulNum = x * y;
            //Console.WriteLine("X * Y is equal to: " + mulNum);
            //int divNum = x / y;
            //Console.WriteLine("X / Y is equal to: " + divNum);

            //string firstName = "Jess";
            //string lastName = "Fellows";
            //Console.WriteLine("My name is " + firstName + " " + lastName);

            //Video one
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined.ToString());

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());

            //int product = 10 * 5;
            //Console.WriteLine(product.ToString());

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);

            //double quotientNum = 100.0 / 17.0;
            //Console.WriteLine(quotientNum);

            //int remainder = 11 % 2 ;
            //Console.WriteLine(remainder);

            //Video 2
            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());

            //int roomTemperature = 70;
            //int currentTemperature = 68;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);

            Console.WriteLine("Enter a number:");
            string product = Console.ReadLine();
            int productNum = Convert.ToInt32(product);
            int productTotal = 50 * productNum;
            Console.WriteLine("Your number times 50 is: " + productTotal);

            Console.WriteLine("Enter a number:");
            string addition = Console.ReadLine();
            int addNum = Convert.ToInt32(addition);
            int addTotal = 25 + addNum;
            Console.WriteLine("Your number plus 25 is: " + addTotal);

            Console.WriteLine("Enter a number:");
            string division = Console.ReadLine();
            int divNum = Convert.ToInt32(division);
            double divTotal = divNum/12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + divTotal);

            Console.WriteLine("Enter a number:");
            string great = Console.ReadLine();
            int greatNum = Convert.ToInt32(great);
            bool greatTotal = greatNum > 50;
            Console.WriteLine("Is your number greater than 50: " + greatTotal);

            Console.WriteLine("Enter a number:");
            string divNumb = Console.ReadLine();
            int divNum1 = Convert.ToInt32(divNumb);
            int diviTotal =divNum1 % 7;
            Console.WriteLine("The remainder of your number after diving by 7 is: " + diviTotal);

            Console.ReadLine();
        }
    }
}
