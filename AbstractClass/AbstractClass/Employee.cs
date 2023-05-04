using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //inherit from person class and IQuit interface
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        //implement quit method 
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
