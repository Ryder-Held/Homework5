// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Dog:Animal
    {
        public Dog():this("")
        {
            // Empty constructor
        }

        public Dog(string aName)
        {
            // Full constructor
            this.Name = aName;
        }

        public override string MakeSound()
        {
            return "Bark";
        }
    }
}
