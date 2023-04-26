using System;
using System.Collections.Generic;


class Program
  {
     static void Main(string[] args)
      {
        //Part one 
        //Create arrray of strings
        string[] names = { "Jess", "Jp", "Nami", "Sanji" };
        //Ask user to input text
        Console.WriteLine("Please enter a word:");
        string lastName = Console.ReadLine();
        //loop that iterates through each string and adds user text input
        for (int i = 0; i < names.Length; i++)
        {
            names[i] += lastName;
        }
        //loop that prints off each string
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        //Part two
        //create an infinite loop
        int x = 10;
        //infite loop condition was if x < 20 then print x-1, x will alwlays be less than 20 so it never ends.
        ////I changed the condition and ensured that x was increased by 1
        do
        {
            Console.WriteLine(x + 1);
            x++;
        }
        while (x < 15);


        //Part three
        //instantiate array and create loop using < operator
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 4)
            {
                Console.WriteLine(nums[i]);
            }
        }
        //instantiate array and create loop using <= operator
        int[] nums2 = { 12, 15, 27, 35, 56, 87};
        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums2[i] <= 35)
            {
                Console.WriteLine(nums2[i]);
            }
        }

        //Part four
        //create list of strings with unique values
        List<string> dogs = new List<string>() { "Aussie", "Dalmation", "Boxer", "Lab", "Scottie" };
        //ask user to input text top search for
        Console.WriteLine("Guess a dog breed in the list:");
        string breedGuess = Console.ReadLine();
        //loop checks list and displays the index of matching breed
        //initiate a variable to track the match
        int matchIndex = -1;
        for (int i = 0; i < dogs.Count; i++)
        {
            if (breedGuess == dogs[i])
            {
                matchIndex = i;
                break;
            }
        }
        //displays if there is a match
        if (matchIndex >= 0)
        {
            Console.WriteLine("Correct, that breed is at index:" +matchIndex);
        }
        else
        {
            Console.WriteLine("That name is not in the list.");
        }


        //Part five
        //list of strings with two identical strings and ask user for input
        List<string> cities = new List<string>() { "New York", "San Diego", "Los Angeles", "New York", "Seattle" };
        Console.WriteLine("Which city is the most popular?");
        string cityAnswer = Console.ReadLine();
        //loop that iterates and displays indices of items that match user text
        //use bool variable to track matches
        bool matchCity = false;
        for(int i = 0; i < cities.Count; i++)
        {
            if (cities[i] == cityAnswer)
            {
                matchCity = true;
                Console.WriteLine(cities[i] + " is at index: " + i);
            }
        }
        if (matchCity == false)
        {
            Console.WriteLine("That city is not listed");
        }

        //Part six
        //list with two identical strings
        List<string> fruits = new List<string>() { "apple", "banana", "cherry", "apple" };
        //create a list to track duplicates and uniques
        List<string> unique = new List<string>();
        List<string> duplicates = new List<string>();
        //foreach loop to check if the item is a duplicate or not and print answer
        foreach(string fruit in fruits)
        {
            if(!unique.Contains(fruit))
            {
                unique.Add(fruit);
                continue;
            }
            else
            {
                duplicates.Add(fruit);
            }

            foreach (string fruits1 in unique)
            {
                Console.WriteLine(fruits1 + " is unique.");
            }
            foreach (string fruits2 in duplicates)
            {
                Console.WriteLine(fruits2 + " is a duplicate.");
            }
        }


        Console.ReadLine();
      }
  }

