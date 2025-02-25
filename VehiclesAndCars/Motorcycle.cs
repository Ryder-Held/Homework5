// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Motorcycle:Vehical
    {
        // Variables
        private bool hasSidecar = false;

        // Gets and sets
        public bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }
        
        // Constructors
        public Motorcycle():this("", "", -1, false)
        {
            // Empty constructor
        }

        public Motorcycle(string aMake, string aModel, int aYear, bool aHasSidecar):base(aMake, aModel, aYear)
        {
            // Full constructor
            this.HasSidecar = aHasSidecar;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Year} {this.Make} {this.Model} (Has Sidecar: {this.HasSidecar})";
        }
    }
}
