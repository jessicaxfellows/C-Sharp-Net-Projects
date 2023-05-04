using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
     class Math
    {
        //create void method that outputs an int, method with output param
        public void methodOne(int num1, out int result)
        {
            result = num1 / 2;
        }

        //overload a method
        public void methodOne(int num1, int num2, out int result)
        {
            result = num1 + num2;
        }
    }
}
