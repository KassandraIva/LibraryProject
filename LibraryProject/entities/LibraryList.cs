using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.classes
{
    internal class LibraryList
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        public LibraryList(string name, string description)
        {
            Name = name;
            Description = description;

            Id = counter++;
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public void AddBook(Book book)
        {
            if (!Books.Contains(book))
            {
                Books.Add(book);
            }
        }

        public void RemoveBook(Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
            }
        }
    }
}
