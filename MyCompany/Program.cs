using System;
using System.Collections.Generic;

namespace MyCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new company
            var theBeatlesCo = new Company("The Beatles Company", new DateTime());

            //Instantiate 4 new employees
            var john = new Employee("John", "Sr. Software Developer", new DateTime());
            var paul = new Employee("Paul", "Data Analyst", new DateTime());
            var george = new Employee("George", "Project Manager", new DateTime());
            var ringo = new Employee("Ringo", "Junior Developer", new DateTime());

            //Add new employees to list
            theBeatlesCo.addNewEmployee(john);
            theBeatlesCo.addNewEmployee(paul);
            theBeatlesCo.addNewEmployee(george);
            theBeatlesCo.addNewEmployee(ringo);

            //Remove john from list because of yoko :(
            theBeatlesCo.removeEmployee(john);

            //List the employees
            theBeatlesCo.ListEmployees();

            Console.ReadKey();
        }
    }

}
