using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Maths
    {
        //in a created class, create method that takes in and returns integer after math ops
        public int methodOne(int input)
        {
            return input + 10;
        }

        //create a second method with same name (overload) take in decimal, math ops and return an int
        public int methodOne(decimal input)
        {
            return decimal.ToInt32(input * 5);
        }

        //create a third method with the same name that will take in string, convert to int and return int
        public int methodOne(string input)
        {
            return Convert.ToInt32(input)/2;
        }
    }
}
