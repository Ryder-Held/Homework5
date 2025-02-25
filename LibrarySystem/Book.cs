// Creator: Ryder Held
// Date: 2/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        // Variables
        private string title = "";
        private string author = "";
        private int yearPublished = -1;

        // Gets and sets
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // Constructor
        public Book():this("", "", -1)
        {
            // Empty constructor
        }

        public Book(string aTitle, string aAuthor, int aYearPublished)
        {
            // Full constructor
            this.Title = aTitle;
            this.Author = aAuthor;
            this.YearPublished = aYearPublished;
        }

        // Methods
        public override string ToString()
        {
            return $"{this.Title} by {this.Author} ({this.YearPublished})";
        }
    }
}
