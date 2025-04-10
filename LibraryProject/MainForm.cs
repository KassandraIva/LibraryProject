using LibraryProject.classes;
using LibraryProject.entities;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        List<Author> authorList = new List<Author>();
        List<Category> categoryList = new List<Category>();
        List<Genre> genreList = new List<Genre>();
        public List<Book> bookList = new List<Book>();
        public List<MiscItems> miscItems = new List<MiscItems>();
        public List<Quotes> quoteList = new List<Quotes>();
        public List<Review> reviewList = new List<Review>();
        public List<BookLists> bookLists = new List<BookLists>();


        private Book selectedBook;
        private Author selectedAuthor;
        private Category selectedCategory;
        private Genre selectedGenre;
        private MiscItems selectedItem;
        private Quotes selectedQuote;
        private Review selectedReview;
        private BookLists selectedBookList;

        public MainForm()
        {
            InitializeComponent();

            authorList = Author.LoadFromFile();
            categoryList = Category.LoadFromFile();
            genreList = Genre.LoadFromFile();
            bookList = Book.LoadFromFile(authorList, categoryList, genreList);
            miscItems = MiscItems.LoadFromFile();
            quoteList = Quotes.LoadFromFile();
            reviewList = Review.LoadFromFile();
            bookLists = BookLists.LoadFromFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAuthors(authorList);
            DisplayCategories(categoryList);
            DisplayGenres(genreList);
            DisplayBooks(bookList);
            DisplayMiscItems(miscItems);
            DisplayQuotes(quoteList);
            DisplayBorrowedBooks(bookList);
            DisplayReviews(reviewList);
            DisplayBookLists(bookLists);
        }

        private void DisplayAuthors(List<Author> authors)
        {
            dgvAllAuthors.Columns.Clear();
            dgvAllAuthors.DataSource = new BindingList<Author>(authors.ToList());

            dgvAllAuthors.EnableHeadersVisualStyles = false;
            dgvAllAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvAllAuthors.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvAllAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllAuthors.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;

            dgvAllAuthors.Columns["FullName"].Visible = false;

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            editColumn.HeaderText = "EditColumn";
            dgvAllAuthors.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteColumn.HeaderText = "DeleteColumn";
            dgvAllAuthors.Columns.Add(deleteColumn);

            dgvAllAuthors.Columns[1].Width = 200;
            dgvAllAuthors.Columns[2].Width = 200;
        }

        private void DisplayCategories(List<Category> categories)
        {
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.Columns.Clear();
            dgvCategories.DataSource = new BindingList<Category>(categories.ToList());

            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkMagenta;
            dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            dgvCategories.Columns.Add("Id", "Id");
            dgvCategories.Columns["Id"].DataPropertyName = "Id";

            dgvCategories.Columns.Add("Name", "Name");
            dgvCategories.Columns["Name"].DataPropertyName = "Name";

            dgvCategories.Columns.Add("Color", "Color");
            dgvCategories.Columns["Color"].DataPropertyName = "Color";

            dgvCategories.Columns.Add("Priority", "Priority");
            dgvCategories.Columns["Priority"].DataPropertyName = "Priority";

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            editColumn.HeaderText = "EditColumn";
            dgvCategories.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteColumn.HeaderText = "DeleteColumn";
            dgvCategories.Columns.Add(deleteColumn);

            dgvCategories.Columns[0].Width = 30;
            dgvCategories.Columns[1].Width = 120;
            dgvCategories.Columns[2].Width = 70;
            dgvCategories.Columns[3].Width = 60;
            dgvCategories.Columns[4].Width = 80;
            dgvCategories.Columns[5].Width = 80;
        }

        private void DisplayGenres(List<Genre> genres)
        {
            dgvGenres.AutoGenerateColumns = false;
            dgvGenres.Columns.Clear();
            dgvGenres.DataSource = new BindingList<Genre>(genres.ToList());

            dgvGenres.EnableHeadersVisualStyles = false;
            dgvGenres.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvGenres.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvGenres.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGenres.AlternatingRowsDefaultCellStyle.BackColor = Color.MistyRose;

            dgvGenres.Columns.Add("Id", "Id");
            dgvGenres.Columns["Id"].DataPropertyName = "Id";

            dgvGenres.Columns.Add("Name", "Name");
            dgvGenres.Columns["Name"].DataPropertyName = "Name";

            dgvGenres.Columns.Add("Color", "Color");
            dgvGenres.Columns["Color"].DataPropertyName = "Color";

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            editColumn.HeaderText = "EditColumn";
            dgvGenres.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteColumn.HeaderText = "DeleteColumn";
            dgvGenres.Columns.Add(deleteColumn);

            dgvGenres.Columns[0].Width = 30;
            dgvGenres.Columns[1].Width = 140;
            dgvGenres.Columns[2].Width = 90;
            dgvGenres.Columns[3].Width = 80;
            dgvGenres.Columns[4].Width = 80;
        }

        private void DisplayBooks(List<Book> books)
        {
            dgvAllBooks.Columns.Clear();
            dgvAllBooks.DataSource = new BindingList<Book>(books.ToList());

            dgvAllBooks.EnableHeadersVisualStyles = false;
            dgvAllBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvAllBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dgvAllBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dgvAllBooks.Columns["Description"].Visible = false;

            dgvAllBooks.Columns["AuthorNames"].HeaderText = "Authors";
            dgvAllBooks.Columns["CategoryNames"].HeaderText = "Categories";
            dgvAllBooks.Columns["GenreNames"].HeaderText = "Genres";

            dgvAllBooks.Columns["Title"].DisplayIndex = 1;
            dgvAllBooks.Columns["AuthorNames"].DisplayIndex = 2;

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            editColumn.HeaderText = "EditColumn";
            dgvAllBooks.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteColumn.HeaderText = "DeleteColumn";
            dgvAllBooks.Columns.Add(deleteColumn);

            dgvAllBooks.Columns[0].Width = 30;
            dgvAllBooks.Columns[1].Width = 225;
            dgvAllBooks.Columns[3].Width = 70;
            dgvAllBooks.Columns[5].Width = 110;
            dgvAllBooks.Columns[6].Width = 170;
            dgvAllBooks.Columns[7].Width = 170;
            dgvAllBooks.Columns[8].Width = 70;
            dgvAllBooks.Columns[9].Width = 70;

        }

        public void DisplayMiscItems(List<MiscItems> miscItems)
        {
            dgvMiscItems.Columns.Clear();
            dgvMiscItems.DataSource = new BindingList<MiscItems>(miscItems.ToList());

            dgvMiscItems.EnableHeadersVisualStyles = false;
            dgvMiscItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvMiscItems.ColumnHeadersDefaultCellStyle.BackColor = Color.YellowGreen;
            dgvMiscItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMiscItems.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            editColumn.Name = "EditColumn";
            dgvMiscItems.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteColumn.Name = "DeleteColumn";
            dgvMiscItems.Columns.Add(deleteColumn);

            dgvMiscItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void DisplayQuotes(List<Quotes> quoteList)
        {
            dgvQuotes.Columns.Clear();
            dgvQuotes.DataSource = new BindingList<Quotes>(quoteList.ToList());

            dgvQuotes.EnableHeadersVisualStyles = false;
            dgvQuotes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvQuotes.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvQuotes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvQuotes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightPink;

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            editColumn.Name = "EditColumn";
            dgvQuotes.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteColumn.Name = "DeleteColumn";
            dgvQuotes.Columns.Add(deleteColumn);

            dgvQuotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void DisplayReviews(List<Review> reviews)
        {
            dgvReviews.Columns.Clear();

            if (reviews != null && reviews.Count > 0)
            {
                dgvReviews.DataSource = new BindingList<Review>(reviews.ToList());

                dgvReviews.EnableHeadersVisualStyles = false;
                dgvReviews.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                dgvReviews.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
                dgvReviews.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvReviews.AlternatingRowsDefaultCellStyle.BackColor = Color.LightPink;

                var editColumn = new DataGridViewButtonColumn()
                {
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Text = "Edit"
                };
                editColumn.Name = "EditColumn";
                dgvReviews.Columns.Add(editColumn);

                var deleteColumn = new DataGridViewButtonColumn()
                {
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Text = "Delete"
                };
                deleteColumn.Name = "DeleteColumn";
                dgvReviews.Columns.Add(deleteColumn);


                dgvReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                MessageBox.Show("No reviews to display.", "Empty List");
            }
        }

        public void DisplayBorrowedBooks(List<Book> bookList)
        {
            dgvBorrowed.Columns.Clear();
            dgvBorrowed.AutoGenerateColumns = false;

            dgvBorrowed.Columns.Add("Title", "Title");
            dgvBorrowed.Columns.Add("AuthorNames", "Authors");
            dgvBorrowed.Columns.Add("Status", "Status");

            DataGridViewCheckBoxColumn borrowedCheckBoxColumn = new DataGridViewCheckBoxColumn();
            borrowedCheckBoxColumn.Name = "IsBorrowed";
            borrowedCheckBoxColumn.HeaderText = "Borrowed";
            borrowedCheckBoxColumn.Width = 80;
            dgvBorrowed.Columns.Add(borrowedCheckBoxColumn);

            var borrowedBooks = bookList.Where(book => book.IsBorrowed).ToList();

            foreach (Book book in borrowedBooks)
            {
                int rowIndex = dgvBorrowed.Rows.Add(book.Title, book.AuthorNames, book.Status.ToString(), book.IsBorrowed);

                dgvBorrowed.Rows[rowIndex].Cells["IsBorrowed"].Value = book.IsBorrowed;
            }

            dgvBorrowed.EnableHeadersVisualStyles = false;
            dgvBorrowed.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvBorrowed.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dgvBorrowed.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBorrowed.AlternatingRowsDefaultCellStyle.BackColor = Color.Tan;

            dgvBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void DisplayBookLists(List<BookLists> bookLists)
        {
            dgvLists.Columns.Clear();
            dgvLists.AutoGenerateColumns = false;

            var displayList = bookLists.Select(bl => new
            {
                bl.Id,
                bl.Name,
                BookCount = bl.BookIds.Count
            }).ToList();

            dgvLists.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "List ID",
                Name = "Id"
            });

            dgvLists.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "List Name",
                Name = "Name"
            });

            dgvLists.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "BookCount",
                HeaderText = "Number of Books",
                Name = "BookCount"
            });

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit",
                Name = "EditColumn"
            };
            dgvLists.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete",
                Name = "DeleteColumn"
            };
            dgvLists.Columns.Add(deleteColumn);

            dgvLists.DataSource = displayList;

        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm()
            {
                AddBook = true,
                allAuthors = authorList,
                allCategories = categoryList,
                allGenres = genreList
            };

            DialogResult result = bookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedBook = bookForm.Book;
                    this.bookList.Add(selectedBook);
                    DisplayBooks(bookList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Book.SaveNewItem(selectedBook);
            }
        }

        private BookLists GetBookList(int id)
        {
            foreach (BookLists x in bookLists)
            {
                if (x.Id == id) return x;
            }
            return null;
        }

        private Author GetAuthor(int id)
        {
            foreach (Author x in authorList)
            {
                if (x.Id == id) return x;
            }
            return null;
        }

        private Category GetCategory(int id)
        {
            foreach (Category x in categoryList)
            {
                if (x.Id == id) return x;
            }
            return null;
        }

        private Genre GetGenre(int id)
        {
            foreach (Genre x in genreList)
            {
                if (x.Id == id) return x;
            }
            return null;
        }

        private Book GetBook(int bookId)
        {
            foreach (Book b in bookList)
            {
                if (b.Id == bookId) return b;
            }
            return null;
        }

        private MiscItems GetItem(int miscId)
        {
            foreach (MiscItems mi in miscItems)
            {
                if (mi.Id == miscId) return mi;
            }
            return null;
        }
        private Quotes GetQuote(int quoteId)
        {
            foreach (Quotes q in quoteList)
            {
                if (q.id == quoteId) return q;
            }
            return null;
        }

        private Review GetReview(int reviewID)
        {
            foreach (Review r in reviewList)
            {
                if (r.reviewId == reviewID) return r;
            }
            return null;
        }

        private void EditBook(int indexOfOld)
        {
            var bookForm = new BookForm()
            {
                AddBook = false,
                Book = selectedBook,
                allAuthors = authorList,
                allCategories = categoryList,
                allGenres = genreList
            };
            DialogResult result = bookForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    this.bookList[indexOfOld] = selectedBook;
                    DisplayBooks(bookList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Book.SaveToFile(bookList);
            }
        }

        private void EditAuthor(int indexOfOld)
        {
            var form = new AuthorForm()
            {
                AddAuthor = false,
                Author = selectedAuthor
            };
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    this.authorList[indexOfOld] = selectedAuthor;
                    DisplayAuthors(authorList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Author.SaveToFile(authorList);
            }
        }

        private void EditBookList(int index)
        {
            BookLists selectedBookList = bookLists[index];

            var bookListForm = new BookListsForm(this, selectedBook)
            {
                IsEditMode = true,
                ListToEdit = selectedBookList
            };

            DialogResult result = bookListForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    DisplayBookLists(bookLists);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditCategory(int indexOfOld)
        {
            CategoryForm form = new CategoryForm()
            {
                AddCategory = false,
                Category = selectedCategory
            };
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    this.categoryList[indexOfOld] = selectedCategory;
                    DisplayCategories(categoryList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Category.SaveToFile(categoryList);
            }
        }

        private void EditGenre(int indexOfOld)
        {
            var form = new GenreForm()
            {
                AddGenre = false,
                Genre = selectedGenre
            };
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    this.genreList[indexOfOld] = selectedGenre;
                    DisplayGenres(genreList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Genre.SaveToFile(genreList);
            }
        }

        private void EditItem(int index)
        {
            MiscItems selectedItem = miscItems[index];

            var miscItemForm = new AddMiscItems(this)
            {
                IsEditMode = true,
                ItemToEdit = selectedItem
            };

            DialogResult result = miscItemForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    DisplayMiscItems(miscItems);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditQuote(int index)
        {
            Quotes selectedQuote = quoteList[index];

            var quotesForm = new QuotesForm(this, selectedBook, selectedItem)
            {
                IsEditMode = true,
                ItemToEdit = selectedQuote
            };

            DialogResult result = quotesForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    DisplayQuotes(quoteList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditReview(int index)
        {
            Review selectedReview = reviewList[index];

            var reviewForm = new ReviewForm(this, selectedBook)
            {
                IsEditMode = true,
                ItemToEdit = selectedReview
            };

            DialogResult result = reviewForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    DisplayReviews(reviewList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBook()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedBook.Title}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (bookList.Remove(selectedBook))
                    {
                        DisplayBooks(bookList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Book.SaveToFile(bookList);
            }
        }

        private void DeleteAuthor()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedAuthor.FirstName} {selectedAuthor.LastName}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                List<string> booksByAuthor = bookList
                    .Where(book => book.Authors.Any(a => a.Id == selectedAuthor.Id))
                    .Select(book => book.Title)
                    .ToList();

                if (booksByAuthor.Count > 0)
                {
                    string strBooks = string.Join(", ", booksByAuthor);
                    MessageBox.Show($"Unable delete {selectedAuthor.FirstName} {selectedAuthor.LastName}. This author has the following books: {strBooks}");
                }
                else
                {
                    try
                    {
                        if (authorList.Remove(selectedAuthor))
                        {
                            DisplayAuthors(authorList);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Author.SaveToFile(authorList);
                }
            }
        }

        private void DeleteCategory()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedCategory.Name}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                List<string> booksWithCategory = bookList
                    .Where(book => book.Categories.Any(x => x.Id == selectedCategory.Id))
                    .Select(book => book.Title)
                    .ToList();

                if (booksWithCategory.Count > 0)
                {
                    string strBooks = string.Join(", ", booksWithCategory);
                    MessageBox.Show($"Unable delete {selectedCategory.Name}. This category is listed in the following books: {strBooks}");
                }
                else
                {
                    try
                    {
                        if (categoryList.Remove(selectedCategory))
                        {
                            DisplayCategories(categoryList);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Category.SaveToFile(categoryList);
                }
            }
        }

        private void DeleteGenre()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedGenre.Name}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                List<string> booksWithGenre = bookList
                    .Where(book => book.Genres.Any(x => x.Id == selectedGenre.Id))
                    .Select(book => book.Title)
                    .ToList();

                if (booksWithGenre.Count > 0)
                {
                    string strBooks = string.Join(", ", booksWithGenre);
                    MessageBox.Show($"Unable delete {selectedGenre.Name}. This genre is listed in the following books: {strBooks}");
                }
                else
                {
                    try
                    {
                        if (genreList.Remove(selectedGenre))
                        {
                            DisplayGenres(genreList);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Genre.SaveToFile(genreList);
                }
            }
        }

        private void DeleteItem()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedItem.Name}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (miscItems.Remove(selectedItem))
                    {
                        DisplayMiscItems(miscItems);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteQuote()
        {
            if (selectedQuote == null)
            {
                MessageBox.Show("No quote selected.");
                return;
            }

            DialogResult result = MessageBox.Show($"Delete quote with ID {selectedQuote.id}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (quoteList.Remove(selectedQuote))
                    {
                        DisplayQuotes(quoteList);
                    }
                    else
                    {
                        MessageBox.Show("Error: Quote could not be deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void DeleteBookList()
        {
            if (selectedBookList == null)
            {
                MessageBox.Show("No quote selected.");
                return;
            }

            DialogResult result = MessageBox.Show($"Delete book list with ID {selectedBookList.Id}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (bookLists.Remove(selectedBookList))
                    {
                        DisplayBookLists(bookLists);
                    }
                    else
                    {
                        MessageBox.Show("Error: Quote could not be deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void DeleteReview()
        {
            if (selectedReview == null)
            {
                MessageBox.Show("No review selected.");
                return;
            }

            DialogResult result = MessageBox.Show($"Delete review with ID {selectedReview.reviewId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (reviewList.Remove(selectedReview))
                    {
                        DisplayReviews(reviewList);
                    }
                    else
                    {
                        MessageBox.Show("Error: Review could not be deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void dgvAllAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvAllAuthors.Columns[e.ColumnIndex].HeaderText;
            //MessageBox.Show(dgvAllAuthors.Columns[e.ColumnIndex].ToString());

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int id = int.Parse(dgvAllAuthors.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedAuthor = GetAuthor(id);
            }

            if (columnName == "EditColumn")
            {
                EditAuthor(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteAuthor();
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvCategories.Columns[e.ColumnIndex].HeaderText;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int id = int.Parse(dgvCategories.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedCategory = GetCategory(id);
            }

            if (columnName == "EditColumn")
            {
                EditCategory(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteCategory();
            }
        }

        private void dgvGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvGenres.Columns[e.ColumnIndex].HeaderText;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int id = int.Parse(dgvGenres.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedGenre = GetGenre(id);
            }

            if (columnName == "EditColumn")
            {
                EditGenre(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteGenre();
            }
        }

        private void dgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvAllBooks.Columns[e.ColumnIndex].HeaderText;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int bookId = int.Parse(dgvAllBooks.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedBook = GetBook(bookId);
            }

            if (columnName == "EditColumn")
            {
                EditBook(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteBook();
            }
        }

        public static Color GetTextColorForBackground(Color bgColor)
        {
            double luminance = 0.299 * bgColor.R + 0.587 * bgColor.G + 0.114 * bgColor.B;
            return luminance > 160 ? Color.Black : Color.White;
        }

        private void dgvAllBooks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvAllBooks.Columns[e.ColumnIndex].Name == "CategoryNames")
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                var book = dgvAllBooks.Rows[e.RowIndex].DataBoundItem as Book;
                if (book == null) return;

                int x = e.CellBounds.Left + 5;
                int y = e.CellBounds.Top + 5;
                int padding = 4;

                foreach (var category in book.Categories)
                {
                    string text = category.Name;
                    Size textSize = TextRenderer.MeasureText(text, e.CellStyle.Font);
                    Rectangle rect = new Rectangle(x, y, textSize.Width + 10, textSize.Height + 3);

                    using (Brush b = new SolidBrush(ColorTranslator.FromHtml(category.Color)))
                    {
                        e.Graphics.FillRectangle(b, rect);
                    }

                    Color textColor = GetTextColorForBackground(ColorTranslator.FromHtml(category.Color));
                    using (Brush textBrush = new SolidBrush(textColor))
                    {
                        e.Graphics.DrawString(text, e.CellStyle.Font, textBrush, x + 5, y);
                    }

                    x += rect.Width + padding;
                }

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvAllBooks.Columns[e.ColumnIndex].Name == "GenreNames")
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                var book = dgvAllBooks.Rows[e.RowIndex].DataBoundItem as Book;
                if (book == null) return;

                int x = e.CellBounds.Left + 5;
                int y = e.CellBounds.Top + 5;
                int padding = 4;

                foreach (var genre in book.Genres)
                {
                    string text = genre.Name;
                    Size textSize = TextRenderer.MeasureText(text, e.CellStyle.Font);
                    Rectangle rect = new Rectangle(x, y, textSize.Width + 10, textSize.Height + 3);

                    using (Brush b = new SolidBrush(ColorTranslator.FromHtml(genre.Color)))
                    {
                        e.Graphics.FillRectangle(b, rect);
                    }

                    Color textColor = GetTextColorForBackground(ColorTranslator.FromHtml(genre.Color));
                    using (Brush textBrush = new SolidBrush(textColor))
                    {
                        e.Graphics.DrawString(text, e.CellStyle.Font, textBrush, x + 5, y);
                    }

                    x += rect.Width + padding;
                }

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);
            }
        }

        private void btnAddMisc_Click(object sender, EventArgs e)
        {
            Form miscItemForm = new AddMiscItems(this);

            miscItemForm.ShowDialog();
        }

        private void dgvMiscItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvMiscItems.Columns[e.ColumnIndex].Name;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int quoteId = int.Parse(dgvQuotes.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedQuote = GetQuote(quoteId);
            }

            if (columnName == "EditColumn")
            {
                EditItem(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteItem();
            }
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            Form quotes = new QuotesForm(this, selectedBook, selectedItem);

            quotes.ShowDialog();
        }

        private void dgvQuotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvQuotes.Columns[e.ColumnIndex].Name;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int quoteId = int.Parse(dgvQuotes.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedQuote = GetQuote(quoteId);
            }

            if (columnName == "EditColumn")
            {
                EditQuote(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteQuote();
            }
        }

        private void dgvAllBooks_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvAllBooks.Columns[e.ColumnIndex].Name == "IsBorrowed")
            {
                int bookId = int.Parse(dgvAllBooks.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                bool isBorrowed = (bool)dgvAllBooks.Rows[e.RowIndex].Cells["IsBorrowed"].Value;

                Book book = bookList.FirstOrDefault(b => b.Id == bookId);
                if (book != null)
                {
                    book.IsBorrowed = isBorrowed;

                    DisplayBorrowedBooks(bookList);
                }
            }
        }

        private void BtnAddReview_Click(object sender, EventArgs e)
        {
            Form reviews = new ReviewForm(this, selectedBook);

            reviews.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var form = new CategoryForm()
            {
                AddCategory = true
            };

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedCategory = form.Category;
                    this.categoryList.Add(selectedCategory);
                    DisplayCategories(categoryList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Category.SaveNewItem(selectedCategory);
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            var form = new GenreForm()
            {
                AddGenre = true
            };

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedGenre = form.Genre;
                    this.genreList.Add(selectedGenre);
                    DisplayGenres(genreList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Genre.SaveNewItem(selectedGenre);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var form = new AuthorForm()
            {
                AddAuthor = true
            };

            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedAuthor = form.Author;
                    this.authorList.Add(selectedAuthor);
                    DisplayAuthors(authorList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Author.SaveNewItem(selectedAuthor);
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string search = txtSearchBook.Text.ToLower();

            if (search == "")
            {
                DisplayBooks(bookList);
            }
            else
            {
                List<Book> books = bookList
                    .Where(book => book.Title.ToLower().Contains(search) || book.AuthorNames.ToLower().Contains(search))
                    .ToList();

                DisplayBooks(books);
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string search = txtSearchAuthor.Text.ToLower();

            if (search == "")
            {
                DisplayAuthors(authorList);
            }
            else
            {
                List<Author> authors = authorList
                    .Where(book => book.FirstName.ToLower().Contains(search) || book.LastName.ToLower().Contains(search))
                    .ToList();

                DisplayAuthors(authors);
            }
        }

        private void dgvReviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvReviews.Columns[e.ColumnIndex].Name;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int reviewId = int.Parse(dgvReviews.Rows[e.RowIndex].Cells["reviewId"].Value.ToString().Trim());
                selectedReview = GetReview(reviewId);
            }

            if (columnName == "EditColumn")
            {
                EditReview(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteReview();
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            Form booklists = new BookListsForm(this, selectedBook);

            booklists.ShowDialog();
        }

        private void dgvLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvLists.Columns[e.ColumnIndex].Name;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int listId = int.Parse(dgvLists.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                selectedBookList = GetBookList(listId);
            }

            if (columnName == "EditColumn")
            {
                EditBookList(e.RowIndex);
            }
            else if (columnName == "DeleteColumn")
            {
                DeleteBookList();
            }
        }
    }
}
