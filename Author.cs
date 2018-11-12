using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author : Human
    {
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Author(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public Address Address { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}
