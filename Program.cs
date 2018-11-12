using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author1 = CreateAuthor("James", "Jones");
            Book book1 = CreateBook("From Here To Eternity", 8497898745, "Ksiaznica");
            List<Book> books1 = new List<Book>();
            Book book2 = CreateBook("Tajemna Historia", 9788324027415);
            Book book3 = CreateBook("Szczygieł", 9788324026524);
            Book book4 = CreateBook("Mały przyjaciel", 9788324035571);
            books1.Add(book2);
            books1.Add(book3);
            books1.Add(book4);
            Author author2 = CreateAuthorWithBooks("Donna", "Tartt", books1, "Znak");

            WriteAuthor(author2);
            WriteBooks(author2);
            Console.ReadLine();
        }

        private static void WriteAuthor(Author author)
        {
            Console.WriteLine($"{author.FirstName} {author.LastName}");
        }

        private static void WriteAddress(Author author)
        {
            if (author.Address.AddressApartmentNumber != null)
                Console.WriteLine($"{author.Address.AddressStreet} {author.Address.AddressStreetNumber}/{author.Address.AddressApartmentNumber}");
            else
                Console.WriteLine($"{author.Address.AddressStreet} {author.Address.AddressStreetNumber}");
            Console.WriteLine($"{author.Address.AddressPostCode} {author.Address.AddressCity}");
        }

        public static void WriteBooks(Author author)
        {
            foreach (Book book in author.Books)
            {
                Console.WriteLine($"Title: {book.Title} ISBN: {book.ISBN} Publisher: {book.Publisher.Name}");
            }
        }

        private static Author CreateAuthor(string firstName, string lastName)
        {
            Author author = new Author(firstName, lastName);
            return author;
        }

        private static Author CreateAuthor(string firstName, string lastName, Address address)
        {
            Author author = new Author(firstName, lastName, address);
            return author;
        }

        private static Address CreateAddress(string street, int streetNumber, int? aptNumber, string city, string postCode)
        {
            Address address = new Address(street, streetNumber, aptNumber, city, postCode);
            return address;
        }

        private static Book CreateBook(string title, long isbn)
        {
            Book book = new Book(title, isbn);
            return book;
        }

        private static Book CreateBook(string title, long isbn, string publisher)
        {
            Book book = new Book(title, isbn, publisher);
            return book;
        }

        public static Author CreateAuthorWithBooks(string firstName, string lastName, List<Book> Books, string publisher)
        {
            Author author = CreateAuthor(firstName, lastName);
            foreach (Book book in Books)
            {
                book.AddPublisher(publisher);
                author.AddBook(book);
            }
            return author;
        }
    }
}
