using LibraryProject.classes;
using LibraryProject.entities;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        List<Author> authorList = new List<Author>();
        List<Category> categoryList = new List<Category>();
        List<Genre> genreList = new List<Genre>();
        List<Book> bookList = new List<Book>();
        public List<MiscItems> miscItems = new List<MiscItems>();

        private Book selectedBook;

        public MainForm()
        {
            InitializeComponent();

            authorList = Author.LoadFromFile();
            categoryList = Category.LoadFromFile();
            genreList = Genre.LoadFromFile();
            bookList = Book.LoadFromFile(authorList, categoryList, genreList);
            miscItems = MiscItems.LoadFromFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayAuthors(authorList);
            DisplayBooks(bookList);
            DisplayMiscItems(miscItems);
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

            dgvAllBooks.Columns[0].Width = 30;
            dgvAllBooks.Columns[1].Width = 225;
            dgvAllBooks.Columns[3].Width = 70;
            dgvAllBooks.Columns[5].Width = 110;
            dgvAllBooks.Columns[6].Width = 170;
            dgvAllBooks.Columns[7].Width = 170;
            dgvAllBooks.Columns[8].Width = 70;
            dgvAllBooks.Columns[9].Width = 70;
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
    }
}
