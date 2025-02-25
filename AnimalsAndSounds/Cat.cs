// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Cat:Animal
    {
        public Cat():this("")
        {
            // Empty constructor
        }

        public Cat(string aName)
        {
            this.Name = aName;
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
