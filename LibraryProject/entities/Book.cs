using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryProject.classes
{
    internal class Book
    {
        private static string filePath = "../../../books.txt";
        private static int counter = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Author { get; set; } = new List<Author>();
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public Review Review { get; set; }

        public Book(string title, List<Author> author, string description)
        {
            Title = title;
            Author = author;
            Description = description;

            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, List<Genre> genre) : this(title, author, description)
        {
            Genres = genre;
            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, BookStatus status) : this(title, author, description)
        {
            Status = status;
            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, List<Category> categories) : this(title, author, description)
        {
            Categories = categories;
            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, BookStatus status, List<Category> categories) : this(title, author, description, status)
        {
            Categories = categories;
            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, List<Category> categories, List<Genre> genre) : this(title, author, description, categories)
        {
            Genres = genre;
            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, BookStatus status, List<Genre> genre) : this(title, author, description, status)
        {
            Genres = genre;
            Id = counter++;
        }

        public Book(string title, List<Author> author, string description, BookStatus status, List<Category> categories, List<Genre> genre) : this(title, author, description, status, categories)
        {
            Genres = genre;
            Id = counter++;
        }

        public Book(int id, string title, List<Author> author, string description, BookStatus status, List<Category> categories, List<Genre> genre) : this(title, author, description, status, categories, genre)
        {
            Id = id;
            Id = counter++;
        }

        private static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<Book> LoadFromFile(List<Author> authors)
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
                    foreach (string authorId in authorIds)
                    {
                        Author author = authors.Find(a => a.Id == Convert.ToInt32(authorId));
                        if (author != null)
                        {
                            bookAuthors.Add(author);
                        }
                    }

                    BookStatus status = BookStatus.UNKNOWN;
                    foreach (BookStatus s in Enum.GetValues(typeof(BookStatus)))
                    {
                        // Если найдено совпадение с числовым значением
                        if ((int)s == Convert.ToInt32(columns[4]))
                        {
                            status = s;
                            break;
                        }
                    }

                    Book book = new Book(Convert.ToInt32(columns[0]), columns[1], bookAuthors, columns[3], status, new List<Category>(), new List<Genre>());
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
