using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Math
    {
        //void method with 2 integers as params
        public void methodOne(int num1, int num2)
        {
            Console.WriteLine("First integer plus 10 is: "+ (10 + num1)); ; //do math ops on first int
            Console.WriteLine("Second integer is: "+num2); //display second int
        }
    }
}
