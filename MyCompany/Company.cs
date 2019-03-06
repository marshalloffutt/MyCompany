using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        private List<Employee> myEmployees = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void addNewEmployee(Employee newEmployee)
        {
            myEmployees.Add(newEmployee);
        }

        // Create a method that allows external code to remove an employee
        public void removeEmployee(Employee employee)
        {
            myEmployees.Remove(employee);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        public void ListEmployees()
        {
            foreach (var employee in myEmployees)
            {
                Console.WriteLine($"{employee.EmployeeName} is a {employee.JobTitle}, and was hired on {employee.StartDate}.");
            }
        }
    }
}
