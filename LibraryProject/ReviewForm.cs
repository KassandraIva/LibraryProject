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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LibraryProject
{
    public partial class ReviewForm : Form
    {
        MainForm mainForm;
        Book selectedBook;

        public bool IsEditMode { get; set; } = false;
        public Review ItemToEdit { get; set; }
        public ReviewForm(MainForm mainForm, Book book)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.selectedBook = book;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            nudRating.Minimum = 1;
            nudRating.Maximum = 5;
            nudRating.Value = 1;
            foreach (var book in mainForm.bookList)
            {
                cmbBook.Items.Add(book.Title);
            }

            if (IsEditMode && ItemToEdit != null)
            {
                Book book = mainForm.bookList.FirstOrDefault(b => b.Id == ItemToEdit.mediaId);
                if (book != null)
                {
                    cmbBook.SelectedItem = book.Title;
                }
                nudRating.Value = ItemToEdit.Rating;
                rtbReview.Text = ItemToEdit.Text;
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (cmbBook.SelectedItem == null)
            {
                MessageBox.Show("Please select a book.", "Error");
                return;
            }

            string selectedTitle = cmbBook.SelectedItem.ToString();
            Book selectedBook = mainForm.bookList.FirstOrDefault(b => b.Title == selectedTitle);

            string reviewText = rtbReview.Text;
            int rating = (int)nudRating.Value;
            DateTime createdAt = DateTime.Now.Date;

            if (IsEditMode && ItemToEdit != null)
            {
                ItemToEdit.mediaId = selectedBook.Id;
                ItemToEdit.Text = reviewText;
                ItemToEdit.Rating = rating;
                ItemToEdit.CreatedAt = DateTime.Now.Date;
            }
            else
            {
                Review newReview = new Review(Review.GetNextId(), selectedBook.Id, reviewText, rating, createdAt);

                mainForm.reviewList.Add(newReview);
            }
            mainForm.DisplayReviews(mainForm.reviewList);
            this.Close();
        }

        private void btnCancelReview_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
