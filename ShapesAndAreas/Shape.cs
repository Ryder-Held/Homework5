// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public abstract class Shape
    {
        // Variables
        private string color = "";

        // Gets and sets
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        // Constructors
        public Shape():this("")
        {
            // Empty constructor
        }

        public Shape(string aColor)
        {
            // Full constructor
            this.Color = aColor;
        }

        // Methods
        public abstract double GetArea();

        public override string ToString()
        {
            return $"{this.Color} Shape";
        }
    }
}
