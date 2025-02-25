// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class EBook:Book
    {
        // Variables
        private double fileSizeMB = -1.0;

        // Gets and sets
        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        // Constructor
        public EBook():this("", "", -1, -1)
        {
            // Empty constructor
        }

        public EBook(string aTitle, string aAuthor, int aYearPublished, double aFileSizeMB):base(aTitle, aAuthor, aYearPublished)
        {
            // Full constructor
            this.FileSizeMB = aFileSizeMB;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Title} by {this.Author} ({this.YearPublished}) ({this.FileSizeMB} MB)";
        }
    }
}
