// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAndSpecializations
{
    public class Engineer:Employee
    {
        // Variables
        private string specialization = "";

        // Gets and sets
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        // Constructors
        public Engineer():this("", -1.0, "")
        {
            // Empty constructor
        }

        public Engineer(string aName, double aSalary, string aSpecialization):base(aName, aSalary)
        {
            // Full constructor
            this.Specialization = aSpecialization;
        }

        // Methods
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}, Specializes In: {this.Specialization}";
        }
    }
}
