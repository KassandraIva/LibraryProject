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

        private Book selectedBook;
        private Author selectedAuthor;
        private Category selectedCategory;
        private Genre selectedGenre;
        private MiscItems selectedItem;
        private Quotes selectedQuote;

        public MainForm()
        {
            InitializeComponent();

            authorList = Author.LoadFromFile(Author.ParseFromString);
            categoryList = Category.LoadFromFile(Category.ParseFromString);
            genreList = Genre.LoadFromFile(Genre.ParseFromString);
            bookList = Book.LoadFromFile(Book.ParseFromString, authorList, categoryList, genreList);
            miscItems = MiscItems.LoadFromFile();
            quoteList = Quotes.LoadFromFile();
            reviewList = Review.LoadFromFile();
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
        }

        private void DisplayAuthors(List<Author> authors)
        {
            dgvAllAuthors.AutoGenerateColumns = false;
            dgvAllAuthors.Columns.Clear();
            dgvAllAuthors.DataSource = new BindingList<Author>(authors.ToList());

            dgvAllAuthors.EnableHeadersVisualStyles = false;
            dgvAllAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvAllAuthors.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvAllAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllAuthors.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;

            dgvAllAuthors.Columns.Add("Id", "Id");
            dgvAllAuthors.Columns["Id"].DataPropertyName = "Id";

            dgvAllAuthors.Columns.Add("FirstName", "First Name");
            dgvAllAuthors.Columns["FirstName"].DataPropertyName = "FirstName";

            dgvAllAuthors.Columns.Add("LastName", "Last Name");
            dgvAllAuthors.Columns["LastName"].DataPropertyName = "LastName";

            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            dgvAllAuthors.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
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
            dgvCategories.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
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
            dgvGenres.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
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

            //dgvAllBooks.Columns["Description"].Visible = false;
            //dgvAllBooks.Columns["DisplayName"].Visible = false;

            //dgvAllBooks.Columns["AuthorNames"].HeaderText = "Authors";
            //dgvAllBooks.Columns["CategoryNames"].HeaderText = "Categories";
            //dgvAllBooks.Columns["GenreNames"].HeaderText = "Genres";

            //dgvAllBooks.Columns["Title"].DisplayIndex = 1;
            //dgvAllBooks.Columns["AuthorNames"].DisplayIndex = 2;

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

            //dgvAllBooks.Columns[0].Width = 30;
            //dgvAllBooks.Columns[1].Width = 225;
            //dgvAllBooks.Columns[3].Width = 70;
            //dgvAllBooks.Columns[5].Width = 110;
            //dgvAllBooks.Columns[7].Width = 170;
            //dgvAllBooks.Columns[8].Width = 170;
            //dgvAllBooks.Columns[9].Width = 70;
            //dgvAllBooks.Columns[10].Width = 70;
            //dgvAllBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private T GetItem<T>(int itemId, List<T> list) where T : DataModel<T>
        {
            foreach (T item in list)
            {
                if (item.Id == itemId) return item;
            }
            return null;
        }

        private void AddEntity<T, FormT>(ref T selectedEntity, List<T> list) where T : class where FormT : EntityForm<T>, new()
        {
            var form = new FormT()
            {
                IsNew = true
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedEntity = form.Entity;
                    list.Add(selectedEntity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm()
            {
                IsNew = true,
                allAuthors = authorList,
                allCategories = categoryList,
                allGenres = genreList
            };

            DialogResult result = bookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedBook = bookForm.Entity;
                    this.bookList.Add(selectedBook);
                    DisplayBooks(bookList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddEntity<Author, AuthorForm>(ref selectedAuthor, authorList);
            DisplayAuthors(authorList);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddEntity<Category, CategoryForm>(ref selectedCategory, categoryList);
            DisplayCategories(categoryList);
        }

        private void btnAddGenres_Click(object sender, EventArgs e)
        {
            AddEntity<Genre, GenreForm>(ref selectedGenre, genreList);
            DisplayGenres(genreList);
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

        private void EditBook(int indexOfOld)
        {
            var bookForm = new BookForm()
            {
                IsNew = false,
                Entity = selectedBook,
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditEntity<T, FormT>(int indexOfOld, ref T selectedEntity, List<T> list) where T : class where FormT : EntityForm<T>, new()
        {
            var form = new FormT()
            {
                IsNew = false,
                Entity = selectedEntity
            };
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    list[indexOfOld] = selectedEntity;
                }
                catch { }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
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
                    DisplayMiscItems(miscItems);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //private void EditAuthor(int indexOfOld)
        //{
        //    var authorForm = new AuthorForm()
        //    {
        //        IsNew = false,
        //        Entity = selectedAuthor
        //    };
        //    DialogResult result = authorForm.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {
        //        try
        //        {
        //            this.authorList[indexOfOld] = selectedAuthor;
        //            DisplayAuthors(authorList);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

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
                    bookList.Remove(selectedBook);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteEntity<T>(ref T selectedEntity, List<T> list, List<string> booksWithEntity) where T : DataModel<T>
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedEntity.DisplayName}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (booksWithEntity.Count > 0)
                {
                    string strBooks = string.Join(", ", booksWithEntity);

                    MessageBox.Show($"Unable delete {typeof(T).Name}. This {typeof(T).Name.ToLower()} has the following books: {strBooks}");
                }
                else
                {
                    try
                    {
                        list.Remove(selectedEntity);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DeleteAuthor()
        {
            List<string> booksByAuthor = bookList
                    .Where(book => book.Authors.Any(a => a.Id == selectedAuthor.Id))
                    .Select(book => book.Title)
                    .ToList();

            DeleteEntity(ref selectedAuthor, authorList, booksByAuthor);
            DisplayAuthors(authorList);
        }
        private void DeleteCategory()
        {
            List<string> booksWithCategory = bookList
                    .Where(book => book.Categories.Any(x => x.Id == selectedCategory.Id))
                    .Select(book => book.Title)
                    .ToList();

            DeleteEntity(ref selectedCategory, categoryList, booksWithCategory);
            DisplayCategories(categoryList);
        }

        private void DeleteGenre()
        {
            List<string> booksWithGenre = bookList
                    .Where(book => book.Genres.Any(x => x.Id == selectedGenre.Id))
                    .Select(book => book.Title)
                    .ToList();

            DeleteEntity(ref selectedGenre, genreList, booksWithGenre);
            DisplayGenres(genreList);
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
        private void dgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            const int EditIndex = 9;
            const int DeleteIndex = 10;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvAllBooks.Columns[e.ColumnIndex].Name;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int bookId = int.Parse(dgvAllBooks.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedBook = GetItem(bookId, bookList);
                //int bookId = int.Parse(dgvQuotes.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
                //selectedBook = GetBook(bookId);
            }

            if (e.ColumnIndex == EditIndex)
            {
                EditBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteBook();
            }

            DisplayBooks(bookList);
        }

        private void dgvAllAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int EditIndex = 3;
            const int DeleteIndex = 4;

            if (e.ColumnIndex == EditIndex || e.ColumnIndex == DeleteIndex)
            {
                int authorId = int.Parse(dgvAllAuthors.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedAuthor = GetItem(authorId, authorList);

                if (e.ColumnIndex == EditIndex)
                {
                    EditEntity<Author, AuthorForm>(e.RowIndex, ref selectedAuthor, authorList);
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteAuthor();
                }

                DisplayAuthors(authorList);
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int EditIndex = 4;
            const int DeleteIndex = 5;

            if (e.ColumnIndex == EditIndex || e.ColumnIndex == DeleteIndex)
            {
                int categoryId = int.Parse(dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedCategory = GetItem(categoryId, categoryList);

                if (e.ColumnIndex == EditIndex)
                {
                    EditEntity<Category, CategoryForm>(e.RowIndex, ref selectedCategory, categoryList);
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteCategory();
                }

                DisplayCategories(categoryList);
            }
        }

        private void dgvGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int EditIndex = 3;
            const int DeleteIndex = 4;

            if (e.ColumnIndex == EditIndex || e.ColumnIndex == DeleteIndex)
            {
                int genreId = int.Parse(dgvGenres.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedGenre = GetItem(genreId, genreList);

                if (e.ColumnIndex == EditIndex)
                {
                    EditEntity<Genre, GenreForm>(e.RowIndex, ref selectedGenre, genreList);
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteGenre();
                }

                DisplayGenres(genreList);
            }
        }

        public static Color GetTextColorForBackground(Color bgColor)
        {
            double brightness = 0.299 * bgColor.R + 0.587 * bgColor.G + 0.114 * bgColor.B;
            return brightness > 160 ? Color.Black : Color.White;
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
    }
}
