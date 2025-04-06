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
        private MiscItems selectedItem;
        private Quotes selectedQuote;

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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAuthors(authorList);
            DisplayBooks(bookList);
            DisplayMiscItems(miscItems);
            DisplayQuotes(quoteList);
            DisplayBorrowedBooks(bookList);
            DisplayReviews(reviewList);
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
            }
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
        private void dgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvAllBooks.Columns[e.ColumnIndex].Name;

            if (columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                int bookId = int.Parse(dgvQuotes.Rows[e.RowIndex].Cells["Id"].Value.ToString().Trim());
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
    }
}
