using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jess";
            //string quote = "The man said, \"Hello\", Jess. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jess";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //name = name.ToUpper();
            //name = name.ToLower();

            //string Name = "Jesse";
            //Name = "Joe";

            //This is dynami and can be changed
            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");

            string first = "Jess ";
            string middle = " Lynn ";
            string last = " Fellows";
            //string concatenation
            string fullName = first + middle + last;
            Console.WriteLine(fullName);
            //make upper case
            first = first.ToUpper();
            Console.WriteLine(first);
            //use sb
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, world!\n");
            sb.Append("My name is Jess");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
