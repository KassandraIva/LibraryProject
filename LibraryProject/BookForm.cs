using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.classes;
using LibraryProject.entities;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryProject
{
    public partial class BookForm : Form
    {
        public Book Book { get; set; }
        public bool AddBook { get; set; }

        public List<Author> allAuthors;
        private List<Author> selectedAuthors = new List<Author>();

        public List<Category> allCategories;
        private List<Category> selectedCategories = new List<Category>();

        public List<Genre> allGenres;
        private List<Genre> selectedGenres = new List<Genre>();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cbxStatus.DataSource = Enum.GetValues(typeof(BookStatus));

            if (AddBook)
            {
                this.Text = "Add Book";
                lblBookId.Visible = false;
            }
            else
            {
                this.Text = "Edit Book";
                lblBookId.Visible = true;
                this.DisplayBook();
            }

            DisplayAllAuthors();
            DisplaySelectedAuthors();

            DisplayAllCategories();
            DisplaySelectedCategories();

            DisplayAllGenres();
            DisplaySelectedGenres();
        }

        private void DisplayAllAuthors()
        {
            lbxAllAuthors.DataSource = null;
            lbxAllAuthors.DataSource = allAuthors;
            lbxAllAuthors.DisplayMember = "FullName";
        }

        private void DisplaySelectedAuthors()
        {
            lbxAuthors.DataSource = null;
            lbxAuthors.DataSource = selectedAuthors;
            lbxAuthors.DisplayMember = "FullName";
        }

        private void DisplayAllCategories()
        {
            lbxAllCategories.DataSource = null;
            lbxAllCategories.DataSource = allCategories;
            lbxAllCategories.DisplayMember = "Name";
        }

        private void DisplaySelectedCategories()
        {
            lbxCategories.DataSource = null;
            lbxCategories.DataSource = selectedCategories;
            lbxCategories.DisplayMember = "Name";
        }

        private void DisplayAllGenres()
        {
            lbxAllGenres.DataSource = null;
            lbxAllGenres.DataSource = allGenres;
            lbxAllGenres.DisplayMember = "Name";
        }

        private void DisplaySelectedGenres()
        {
            lbxGenres.DataSource = null;
            lbxGenres.DataSource = selectedGenres;
            lbxGenres.DisplayMember = "Name";
        }

        private void DisplayBook()
        {
            lblBookId.Text = $"Id: {Book.Id}";
            txtTitle.Text = Book.Title;
            rtbDescription.Text = Book.Description;
            cbxStatus.SelectedItem = Book.Status;

            selectedAuthors = Book.Authors;
            selectedCategories = Book.Categories;
            selectedGenres = Book.Genres;
        }

        private void lbxAllAuthors_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbxAllAuthors.SelectedItem != null)
            {
                lbxAllAuthors.DoDragDrop(lbxAllAuthors.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lbxAuthors_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Author)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lbxAuthors_DragDrop(object sender, DragEventArgs e)
        {
            Author droppedAuthor = (Author)e.Data.GetData(typeof(Author));

            if (!selectedAuthors.Any(a => a.Id == droppedAuthor.Id))
            {
                selectedAuthors.Add(droppedAuthor);
                DisplaySelectedAuthors();
            }
        }

        private void lbxAllCategories_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbxAllCategories.SelectedItem != null)
            {
                lbxAllCategories.DoDragDrop(lbxAllCategories.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lbxCategories_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Category)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lbxCategories_DragDrop(object sender, DragEventArgs e)
        {
            Category droppedCategory = (Category)e.Data.GetData(typeof(Category));

            if (!selectedCategories.Any(c => c.Id == droppedCategory.Id))
            {
                selectedCategories.Add(droppedCategory);
                DisplaySelectedCategories();
            }
        }

        private void lbxAllGenres_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbxAllGenres.SelectedItem != null)
            {
                lbxAllGenres.DoDragDrop(lbxAllGenres.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lbxGenres_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Genre)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lbxGenres_DragDrop(object sender, DragEventArgs e)
        {
            Genre droppedGenre = (Genre)e.Data.GetData(typeof(Genre));

            if (!selectedGenres.Any(g => g.Id == droppedGenre.Id))
            {
                selectedGenres.Add(droppedGenre);
                DisplaySelectedGenres();
            }
        }

        private bool Validation()
        {
            bool isValid = true;

            if (txtTitle.Text == "")
            {
                MessageBox.Show("Title is a required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (selectedAuthors.Count == 0)
            {
                MessageBox.Show("Author is a required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                BookStatus status = BookStatus.Unknown;
                foreach (BookStatus s in Enum.GetValues(typeof(BookStatus)))
                {
                    if ((int)s == Convert.ToInt32(cbxStatus.SelectedItem))
                    {
                        status = s;
                        break;
                    }
                }

                if (AddBook)
                {
                    this.Book = new Book(txtTitle.Text, selectedAuthors, rtbDescription.Text, status, selectedCategories, selectedGenres);
                }
                else
                {
                    Book.Title = txtTitle.Text;
                    Book.Description = rtbDescription.Text;
                    Book.Status = status;
                    Book.Authors = selectedAuthors;
                    Book.Categories = selectedCategories;
                    Book.Genres = selectedGenres;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAuthor()
        {
            Author selectedAuthor = (Author)lbxAuthors.SelectedItem;

            if (selectedAuthor != null)
            {
                DialogResult result =
                    MessageBox.Show($"Delete {selectedAuthor.FullName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedAuthors.Remove(selectedAuthor);
                    DisplaySelectedAuthors();
                }
            }
        }

        private void DeleteCategory()
        {
            Category selectedCategory = (Category)lbxCategories.SelectedItem;

            if (selectedCategory != null)
            {
                DialogResult result =
                    MessageBox.Show($"Delete {selectedCategory.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedCategories.Remove(selectedCategory);
                    DisplaySelectedCategories();
                }
            }
        }

        private void DeleteGenre()
        {
            Genre selectedGenre = (Genre)lbxGenres.SelectedItem;

            if (selectedGenre != null)
            {
                DialogResult result =
                    MessageBox.Show($"Delete {selectedGenre.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedGenres.Remove(selectedGenre);
                    DisplaySelectedGenres();
                }
            }
        }

        private void lbxAuthors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteAuthor();
            }
        }

        private void lbxCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteCategory();
            }
        }

        private void lbxGenres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteGenre();
            }
        }

        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {
            var authorForm = new AuthorForm()
            {
                AddAuthor = true
            };

            DialogResult result = authorForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    allAuthors.Add(authorForm.Author);
                    selectedAuthors.Add(authorForm.Author);

                    DisplayAllAuthors();
                    DisplaySelectedAuthors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            DeleteAuthor();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryForm()
            {
                AddCategory = true
            };

            DialogResult result = categoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    allCategories.Add(categoryForm.Category);
                    selectedCategories.Add(categoryForm.Category);

                    DisplayAllCategories();
                    DisplaySelectedCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void btnAddNewGenre_Click(object sender, EventArgs e)
        {
            var genreForm = new GenreForm()
            {
                AddGenre = true
            };

            DialogResult result = genreForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    allGenres.Add(genreForm.Genre);
                    selectedGenres.Add(genreForm.Genre);

                    DisplayAllGenres();
                    DisplaySelectedGenres();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            DeleteGenre();
        }
    }
}
