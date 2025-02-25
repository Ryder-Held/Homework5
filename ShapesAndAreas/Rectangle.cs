// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Rectangle:Shape
    {
        // Variables
        private double width = -1;
        private double height = -1;

        // Gets and sets
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // Constructors
        public Rectangle():this("", -1, -1)
        {
            // Empty constructor
        }

        public Rectangle(string aColor, double aWidth, double aHeight):base(aColor)
        {
            // Full constructor
            this.Width = aWidth;
            this.Height = aHeight;
        }

        // Methods
        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return $"This {this.Color} rectangle has a width of {this.Width}, a height of {this.Height}, and a total area of {GetArea()}";
        }
    }
}
