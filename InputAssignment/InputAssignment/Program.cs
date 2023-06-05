using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //added system IO 

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for a number
            Console.WriteLine("Please input a number: ");
            string number = Console.ReadLine();
            //log that number to a text file 
            File.WriteAllText(@"C:\Users\jessi\OneDrive\Documents\JessicaFellow.txt", number);
            //print the text from the file back to the user
            string numberFile = File.ReadAllText(@"C:\Users\jessi\OneDrive\Documents\JessicaFellow.txt");
            Console.WriteLine("This is the text being read back from the file: " + numberFile);

            Console.ReadLine();
        }
    }
}
