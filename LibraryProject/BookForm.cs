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
    public partial class BookForm : EntityForm<Book>
    {
        protected override Label LblId => lblBookId;
        protected override System.Windows.Forms.Button BtnCancel => btnCancel;
        protected override System.Windows.Forms.Button BtnAccept => btnAccept;

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

            if (!IsNew)
            {
                DisplayEntity();
            }
            
            DisplayAllListBox();
        }

        private void DisplayListBox<T>(ListBox listBox, List<T> dataSource, string displayMember)
        {
            listBox.DataSource = null;
            listBox.DataSource = dataSource;
            listBox.DisplayMember = displayMember;
        }

        private void DisplayAllListBox()
        {
            DisplayListBox(lbxAllAuthors, allAuthors, "DisplayName");
            DisplayListBox(lbxAuthors, selectedAuthors, "DisplayName");

            DisplayListBox(lbxAllCategories, allCategories, "Name");
            DisplayListBox(lbxCategories, selectedCategories, "Name");

            DisplayListBox(lbxAllGenres, allGenres, "Name");
            DisplayListBox(lbxGenres, selectedGenres, "Name");
        }

        protected override void DisplayEntity()
        {
            lblBookId.Text = $"Id: {Entity.Id}";
            txtTitle.Text = Entity.Title;
            rtbDescription.Text = Entity.Description;
            cbxStatus.SelectedItem = Entity.Status;

            selectedAuthors = Entity.Authors;
            selectedCategories = Entity.Categories;
            selectedGenres = Entity.Genres;
        }

        protected override bool Validation()
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

        protected override void UpdateEntity()
        {
            var status = (BookStatus)cbxStatus.SelectedItem;

            if (IsNew)
            {
                Entity = new Book(txtTitle.Text, selectedAuthors, rtbDescription.Text, status, selectedCategories, selectedGenres);
            }
            else
            {
                Entity.Title = txtTitle.Text;
                Entity.Description = rtbDescription.Text;
                Entity.Status = status;
                Entity.Authors = selectedAuthors;
                Entity.Categories = selectedCategories;
                Entity.Genres = selectedGenres;
            }
        }

        private void ListBox_MouseDown<T>(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
            }
        }

        private void ListBox_DragEnter<T>(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(T)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListBox_DragDrop<T>(object sender, DragEventArgs e, List<T> dataSource, string displayMember) where T : DataModel<T>
        {
            T droppedItem = (T)e.Data.GetData(typeof(T));

            if (!dataSource.Any(a => a.Id == droppedItem.Id))
            {
                dataSource.Add(droppedItem);
                DisplayListBox((ListBox)sender, dataSource, displayMember);
            }
        }

        private void DeleteSelectedItem<T>(ListBox listBox, List<T> dataSource, string displayMember) where T : DataModel<T>
        {
            T selectedItem = (T)listBox.SelectedItem;

            if (selectedItem != null)
            {
                DialogResult result =
                    MessageBox.Show($"Delete {selectedItem.DisplayName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataSource.Remove(selectedItem);
                    DisplayListBox(listBox, dataSource, displayMember);
                }
            }
        }

        private void ListBox_KeyDown<T>(object sender, KeyEventArgs e, List<T> dataSource, string displayMember) where T : DataModel<T>
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedItem((ListBox)sender, dataSource, displayMember);
            }
        }

        private void btnDelete_Click<T>(ListBox listBox, List<T> list, string displayMember) where T : DataModel<T>
        {
            DeleteSelectedItem(listBox, list, displayMember);
        }

        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {
            var authorForm = new AuthorForm()
            {
                IsNew = true
            };

            DialogResult result = authorForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    allAuthors.Add(authorForm.Entity);
                    selectedAuthors.Add(authorForm.Entity);

                    DisplayListBox(lbxAllAuthors, allAuthors, "DisplayName");
                    DisplayListBox(lbxAuthors, selectedAuthors, "DisplayName");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryForm()
            {
                IsNew = true
            };

            DialogResult result = categoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    allCategories.Add(categoryForm.Entity);
                    selectedCategories.Add(categoryForm.Entity);

                    DisplayListBox(lbxAllCategories, allCategories, "Name");
                    DisplayListBox(lbxCategories, selectedCategories, "Name");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddNewGenre_Click(object sender, EventArgs e)
        {
            var genreForm = new GenreForm()
            {
                IsNew = true
            };

            DialogResult result = genreForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    allGenres.Add(genreForm.Entity);
                    selectedGenres.Add(genreForm.Entity);

                    DisplayListBox(lbxAllGenres, allGenres, "Name");
                    DisplayListBox(lbxGenres, selectedGenres, "Name");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
