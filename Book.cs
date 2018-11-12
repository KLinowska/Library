using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public Book(string title, long isbn)
        {
            Title = title;
            ISBN = isbn;
        }

        public Book(string title, long isbn, string publisher)
        {
            Title = title;
            ISBN = isbn;
            AddPublisher(publisher);
        }

        public string Title { get; set; }
        public long ISBN { get; set; }
        public Publisher Publisher { get; set; } = new Publisher();

        public void AddPublisher(string name)
        {
            Publisher.Name = name;
        }
    }
}
