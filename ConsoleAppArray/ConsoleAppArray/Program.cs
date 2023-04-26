using System;
using System.Collections.Generic;



 class Program
{
    static void Main()
    {
        //create an array of strings
        string[] names = { "Jess", "Jp", "Nami", "Sanji", "Jimbei", "Luffy" };
        //ask user to select index of array and then print to console
        Console.WriteLine("Choose a number between 0-5 to be assigned a name:");
        //take input and convert to int
        int nameChoice = Convert.ToInt32(Console.ReadLine());
        //print with the name from the choosen array number
        Console.WriteLine("Your choosen name is: " + names[nameChoice]);

        //create an array of intergers
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //ask user to select index of array and print to console
        Console.WriteLine("Pick an array index number:");
        //convert string to int
        int numChoice = Convert.ToInt32(Console.ReadLine());
        //if loop for picking the correct number and else loop for a number not in the array index
        if (numChoice <= 9) { 
        Console.WriteLine("The number at your choosen array number is: " + nums[numChoice]); ;
        }
        else
        {
            Console.WriteLine("That number is not within the array, please choose a number between 0-9.");
        }

        //create a list of strings
        List<string> dogs = new List<string>{ "Lab", "Scottie", "Aussie", "Dalmation", "Boxer" };
        //ask user to pick a number
        Console.WriteLine("Pick a number between 0-4 for your puppy:");
        //convert string to int
        int dogsChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your pupy choice is: " + dogs[dogsChoice]);

        Console.ReadLine();
     }
 }

