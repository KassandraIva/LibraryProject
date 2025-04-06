using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryProject.classes
{
    public class Book
    {
        private static string filePath = "../../../books.txt";
        private static int counter = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public Boolean IsBorrowed { get; set; }
        public Review Review { get; set; }

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

        private static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<Book> LoadFromFile(List<Author> authors, List<Category> categories, List<Genre> genres)
        {
            int maxId = 0;
            List<Book> books = new List<Book>();

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');

                    if (Convert.ToInt32(columns[0]) > maxId) maxId = Convert.ToInt32(columns[0]);

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

                    Book book = new Book(Convert.ToInt32(columns[0]), columns[1], bookAuthors, columns[3], status, bookCategories, bookGenres, Convert.ToBoolean(columns[7]));
                    books.Add(book);
                }

                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            SetCounter(maxId);

            return books;
        }
    }
}
