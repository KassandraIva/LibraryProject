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

        private void DisplayBook()
        {
            lblBookId.Text = $"Id: {Book.Id}";
            txtTitle.Text = Book.Title;
            lbxAuthors.DataSource = Book.Authors;
            cbxStatus.SelectedItem = Book.Status;
            //txtPrice.Text = Product.UnitPrice.ToString("N2");
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

        private void btnAccept_Click(object sender, EventArgs e)
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
                this.Book = new Book(txtTitle.Text, selectedAuthors, rtbDescription.Text, status, new List<Category>(), new List<Genre>());
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
