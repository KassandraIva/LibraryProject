using LibraryProject.classes;
using LibraryProject.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class BookListsForm : Form
    {
        MainForm mainForm;
        Book selectedBook;

        // Add properties for edit mode
        public bool IsEditMode { get; set; } = false;
        public BookLists ListToEdit { get; set; }

        public BookListsForm(MainForm mainForm, Book book)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.selectedBook = book;
        }

        private void BookListsForm_Load(object sender, EventArgs e)
        {
            lsbBooksInList.SelectionMode = SelectionMode.MultiExtended;
            lsbBooksInList.DataSource = new BindingList<Book>(mainForm.bookList);
            lsbBooksInList.DisplayMember = "Title";
            lsbBooksInList.ValueMember = "Id";

            if (IsEditMode && ListToEdit != null)
            {
                txtListName.Text = ListToEdit.Name;

                // Preselect the books in the list
                for (int i = 0; i < lsbBooksInList.Items.Count; i++)
                {
                    Book book = (Book)lsbBooksInList.Items[i];
                    if (ListToEdit.BookIds.Contains(book.Id))
                    {
                        lsbBooksInList.SetSelected(i, true);
                    }
                }
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtListName.Text))
            {
                MessageBox.Show("Please enter a list name.");
                return;
            }

            if (lsbBooksInList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one book.");
                return;
            }

            List<int> selectedBookIds = lsbBooksInList.SelectedItems
                .Cast<Book>()
                .Select(book => book.Id)
                .ToList();

            if (IsEditMode && ListToEdit != null)
            {
                // Edit existing list
                ListToEdit.Name = txtListName.Text;
                ListToEdit.BookIds = selectedBookIds;
            }
            else
            {
                // Create new list
                BookLists newBookList = new BookLists(
                    BookLists.GetNextId(),
                    txtListName.Text,
                    selectedBookIds
                );
                mainForm.bookLists.Add(newBookList);
            }

            mainForm.DisplayBookLists(mainForm.bookLists);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
