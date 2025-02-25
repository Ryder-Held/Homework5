// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Animal
    {
        // Variables
        private string name = "";

        // Gets and sets
        public string Name
        { 
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructors
        public Animal():this("")
        {
            // Empty constructor
        }

        public Animal(string aName)
        {
            // Full constructor
            this.Name = aName;
        }

        // Methods
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }

        public override string ToString()
        {
            return $"Animal: {this.Name}, Sound: {MakeSound()}";
        }
    }
}
