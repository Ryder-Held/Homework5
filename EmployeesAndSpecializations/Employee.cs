// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Employee
    {
        // Variables
        private string name = "";
        private double salary = -1.0;

        // Gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        // Constructor
        public Employee():this("", -1.0)
        {
            // Empty constructor
        }
        
        public Employee(string aName, double aSalary)
        {
            // Full constructor
            this.Name = aName;
            this.Salary = aSalary;
        }

        // Methods
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}";
        }
    }
}
