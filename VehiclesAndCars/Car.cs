// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Car:Vehical
    {
        // Variables
        private int numberOfDoors = -1;

        // Gets and sets
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }
        }

        // Constructors
        public Car():this("", "", -1, -1)
        {
            // Empty constructor
        }

        public Car(string aMake, string aModel, int aYear, int aNumberOfDoors):base(aMake, aModel, aYear)
        {
            // Full constructor
            this.NumberOfDoors = aNumberOfDoors;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Year} {this.Make} {this.Model} with {this.NumberOfDoors} doors";
        }
    }
}
