using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of employee objects and add 10 people
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1, "James", "Innocent"));
            empList.Add(new Employee(2, "Nami", "Jones"));
            empList.Add(new Employee(3, "Jp", "Fellows"));
            empList.Add(new Employee(4, "Jess", "Innocent"));
            empList.Add(new Employee(5, "Robin", "Peters"));
            empList.Add(new Employee(6, "Joe", "Reid"));
            empList.Add(new Employee(7, "Joe", "Anderson"));
            empList.Add(new Employee(8, "Jeff", "Fellows"));
            empList.Add(new Employee(9, "Chris", "Fellows"));
            empList.Add(new Employee(10, "Valerie", "Johnson"));

            //Create empty list for "Joe" names
            List<Employee> joeNames = new List<Employee>();

            //for each employee object, if first name = joe, add to new joe list
            foreach (Employee employee in empList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeNames.Add(employee);
                }
            }
            //for each employee on the joe list, print the first name   
            foreach (Employee emp in joeNames)
                {
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }

            //create a second list to hold lambda joe expression joes then lambda expression, adding where joes are first name
            List<Employee> joeNames2 = empList.Where(x => x.FirstName == "Joe").ToList();
            //foreach to print new Joe List
            foreach(Employee emp in joeNames2)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            //create a third list where employee ID is > 5 with lambda then print list
            List<Employee> idList = empList.Where(y => y.ID > 5).ToList();
            foreach (Employee emp in idList)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.ID);
            }


            Console.ReadLine();

        }
    }
}
