using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LibraryProject.entities;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryProject.classes
{
    public class Book : DataModel<Book>
    {
        public override int Id { get; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public Review Review { get; set; }
        public override string DisplayName => $"{Title}";
        public Boolean IsBorrowed { get; set; }

        public string AuthorNames => string.Join(", ", Authors.Select(a => a.FirstName + " " + a.LastName));
        public string CategoryNames => string.Join(", ", Categories.Select(c => c.Name));
        public string GenreNames => string.Join(", ", Genres.Select(g => g.Name));

        public Book(string title, List<Author> authors, string description, BookStatus status, List<Category> categories, List<Genre> genre, bool borrowed)
        {
            Title = title;
            Authors = authors;
            Description = description;
            Status = status;
            Categories = categories;
            Genres = genre;
            IsBorrowed= borrowed;
            Id = ++counter;

        }

        public Book(string title, List<Author> authors, string description, BookStatus status, List<Category> categories, List<Genre> genre)
        {
            Title = title;
            Authors = authors;
            Description = description;
            Status = status;
            Categories = categories;
            Genres = genre;
            Id = ++counter;

        }

        public Book(int id, string title, List<Author> author, string description, BookStatus status, List<Category> categories, List<Genre> genre,bool borrowed) : this(title, author, description, status, categories, genre,borrowed)
        {
            Id = id;
        }

        public static Book ParseFromString(string[] columns, List<Author> authors, List<Category> categories, List<Genre> genres)
        {
            string[] authorIds = columns[2].Split(',');

            List<Author> bookAuthors = new List<Author>();
            if (authorIds[0].Length > 0)
            {
                foreach (string authorId in authorIds)
                {
                    Author author = authors.Find(a => a.Id == Convert.ToInt32(authorId));
                    if (author != null)
                    {
                        bookAuthors.Add(author);
                    }
                }
            }

            string[] categoryIds = columns[5].Split(',');

            List<Category> bookCategories = new List<Category>();
            if (categoryIds[0].Length > 0)
            {
                foreach (string categoryId in categoryIds)
                {
                    Category category = categories.Find(c => c.Id == Convert.ToInt32(categoryId));
                    if (category != null)
                    {
                        bookCategories.Add(category);
                    }
                }
            }

            string[] genreIds = columns[6].Split(',');

            List<Genre> bookGenres = new List<Genre>();
            if (genreIds[0].Length > 0)
            {
                foreach (string genreId in genreIds)
                {
                    Genre genre = genres.Find(g => g.Id == Convert.ToInt32(genreId));
                    if (genre != null)
                    {
                        bookGenres.Add(genre);
                    }
                }
            }

            BookStatus status = BookStatus.Unknown;
            foreach (BookStatus s in Enum.GetValues(typeof(BookStatus)))
            {
                if ((int)s == Convert.ToInt32(columns[4]))
                {
                    status = s;
                    break;
                }
            }

            return new Book(Convert.ToInt32(columns[0]), columns[1], bookAuthors, columns[3], status, bookCategories, bookGenres, Convert.ToBoolean(columns[7]));
        }
    }
}
