using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Titel { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string titel, string author)
        {
            Isbn = isbn;
            Titel = titel;
            Author = author;
        }

        public override string ToString()
        {
            return $"Isbn {Isbn} titel { Titel} author { Author} ";
        }
    }
}
