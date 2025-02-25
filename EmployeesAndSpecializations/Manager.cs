// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Manager:Employee
    {
        // Variables
        private int numberOfEmployeesManaged = -1;

        // Gets and sets
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        // Constructors
        public Manager():this("", -1.0, -1)
        {
            // Empty constructor
        }

        public Manager(string aName, double aSalary, int aNumberOfEmployeesManaged):base(aName, aSalary)
        {
            // Full constructor
            this.NumberOfEmployeesManaged = aNumberOfEmployeesManaged;
        }

        // Methods
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}, Manages: {this.NumberOfEmployeesManaged} employees";
        }
    }
}
