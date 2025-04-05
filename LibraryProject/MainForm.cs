using LibraryProject.classes;
using System.ComponentModel;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        List<Author> authorList = new List<Author>();
        List<Book> bookList = new List<Book>();

        private Book selectedBook;

        public MainForm()
        {
            InitializeComponent();

            authorList = Author.LoadFromFile();
            bookList = Book.LoadFromFile(authorList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAuthors(authorList);
            DisplayBooks(bookList);
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
    }
}
