using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee 
    {
        //declare props 
        public int ID;
        public string FirstName;
        public string LastName;

        //create constructor
        public Employee(int id, string firstname, string lastlame)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastlame;
        }
    }
}
