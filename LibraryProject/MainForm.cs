using LibraryProject.classes;
using LibraryProject.entities;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        List<Author> authorList = new List<Author>();
        public List<Book> bookList = new List<Book>();
        public List<MiscItems> miscItems = new List<MiscItems>();
        public List<Quotes> quoteList = new List<Quotes>();

        private Book selectedBook;
        private MiscItems selectedItem;
        private Quotes selectedQuote;

        public MainForm()
        {
            InitializeComponent();

            authorList = Author.LoadFromFile();
            bookList = Book.LoadFromFile(authorList);
            miscItems = MiscItems.LoadFromFile();
            quoteList = Quotes.LoadFromFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAuthors(authorList);
            DisplayBooks(bookList);
            DisplayMiscItems(miscItems);
            DisplayQuotes(quoteList);
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

            dgvAllBooks.Columns["Review"].Visible = false;
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
            dgvAllBooks.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvAllBooks.Columns.Add(deleteColumn);

            dgvAllBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var bookForm = new BookForm()
            {
                AddBook = true,
                allAuthors = authorList
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
                allAuthors = authorList
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
            //MessageBox.Show(e.ColumnIndex.ToString());
            const int EditIndex = 8;
            const int DeleteIndex = 9;

            if (e.ColumnIndex == EditIndex || e.ColumnIndex == DeleteIndex)
            {
                int bookId = int.Parse(dgvAllBooks.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedBook = GetBook(bookId);
            }

            if (e.ColumnIndex == EditIndex)
            {
                EditBook(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteBook();
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
                selectedQuote= GetQuote(quoteId);
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
    }
}
