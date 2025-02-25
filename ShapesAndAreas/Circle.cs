// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Circle:Shape
    {
        // Variables
        private double radius = -1;

        // Gets and sets
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        // Constructors
        public Circle():this("", -1)
        {
            // Empty constructor
        }

        public Circle(string aColor, double aRadius):base(aColor)
        {
            // Full constructor
            this.Radius = aRadius;
        }

        // Methods
        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override string ToString()
        {
            return $"This {this.Color} circle has a radius of {this.Radius} and a total area of {GetArea()}";
        }
    }
}
