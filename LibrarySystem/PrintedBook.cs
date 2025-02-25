// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class PrintedBook:Book
    {
        // Variables
        private int pageCount = -1;

        // Gets and sets
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        // Constructor
        public PrintedBook() : this("", "", -1, -1)
        {
            // Empty constructor
        }

        public PrintedBook(string aTitle, string aAuthor, int aYearPublished, int aPageCount) : base(aTitle, aAuthor, aYearPublished)
        {
            // Full constructor
            this.PageCount = aPageCount;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Title} by {this.Author} ({this.YearPublished}) ({this.PageCount} Pages)";
        }
    }
}
