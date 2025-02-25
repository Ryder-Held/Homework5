// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Vehical
    {
        // Variables
        private string make = "";
        private string model = "";
        private int year = -1;

        // Gets and sets
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // Constructors
        public Vehical():this("", "", -1)
        {
            // Empty constructor
        }

        public Vehical(string aMake, string aModel, int aYear)
        {
            // Full constructor
            this.Make = aMake;
            this.Model = aModel;
            this.Year = aYear;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Year} {this.Make} {this.Model}";
        }
    }
}
