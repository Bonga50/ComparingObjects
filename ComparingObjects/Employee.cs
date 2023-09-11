using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    internal class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double salary { get; set; }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            this.salary = salary;
        }

        public override string? ToString()
        {
            return $"{FirstName} {LastName} : {salary}";
        }
    }
}
