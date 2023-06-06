using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class sampleClass
    {
        public string firstName;
        public sampleClass() : this ("Nami")
        {
            //constructor with no parms but chained with constructor below
        }

        //constructor with one param
        public sampleClass(string name)
        {
            firstName = name;
        }

    }
}
