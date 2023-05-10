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

        public int ID { get; set; } //add ID prop

        //overload == (and it's pair)
        public static bool operator ==(Employee newEmp1, Employee newEmp2)
        {
            if (newEmp1.ID == newEmp2.ID)
            {
                Console.WriteLine("The IDs are equal.");
                return true;
            }
            else
            {
                Console.WriteLine("The IDs are not equal.");
                return false;
            }
        }

        public static bool operator !=(Employee newEmp1, Employee newEmp2)
        {
            if (newEmp1.ID != newEmp2.ID)
            {
                Console.WriteLine("The IDs are not equal.");
                return false;
            }
            else
            {
                Console.WriteLine("The IDs are equal.");
                return true;
            }


        }
    }
    }
