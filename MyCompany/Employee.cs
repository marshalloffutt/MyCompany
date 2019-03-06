using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string employeeName, string jobTitle, DateTime startDate)
        {
            EmployeeName = employeeName;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
