using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    internal class Employee :IComparable<Employee>              
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

        public int CompareTo(Employee? other)
        {
            int result = this.LastName.CompareTo(other.LastName);
            if (result==0)
            {
                result = this.FirstName.CompareTo(other.FirstName);
            }
            return result;
        }
    }
}
