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

        public string Title { get; set; }





        public List<Author> Author { get; set; } = new List<Author>();
        public string Description { get; set; }
        public BookStatus Status { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        private Review Review;

        public Book(string title, List<Author> author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }

        public Book(string title, List<Author> author, string description, List<Genre> genre) : this(title, author, description)
        {
            Genres = genre;
        }

        public Book(string title, List<Author> author, string description, BookStatus status) : this(title, author, description)
        {
            Status = status;
        }

        public Book(string title, List<Author> author, string description, List<Category> categories) : this(title, author, description)
        {
            Categories = categories;
        }

        public Book(string title, List<Author> author, string description, BookStatus status, List<Category> categories) : this(title, author, description, status)
        {
            Categories = categories;
        }

        public Book(string title, List<Author> author, string description, List<Category> categories, List<Genre> genre) : this(title, author, description, categories)
        {
            Genres = genre;
        }

        public Book(string title, List<Author> author, string description, BookStatus status, List<Genre> genre) : this(title, author, description, status)
        {
            Genres = genre;
        }

        public Book(string title, List<Author> author, string description, BookStatus status, List<Category> categories, List<Genre> genre) : this(title, author, description, status, categories)
        {
            Genres = genre;
        }

        public static List<Book> LoadFromFile(List<Author> authors)
        {
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

                    string[] authorIds = columns[1].Split(',');

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
                        if ((int)s == Convert.ToInt32(columns[3]))
                        {
                            status = s;
                            break;
                        }
                    }

                    Book book = new Book(columns[0], bookAuthors, columns[2], status, new List<Category>(), new List<Genre>());
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

            return books;
        }
    }
}
