using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number example;
            example.Amount = 12.45m;
            Console.WriteLine(example.Amount);

            Console.ReadLine();
        }
    }
}
