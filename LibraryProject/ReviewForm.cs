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
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            string selectedTitle = cmbBook.SelectedItem.ToString();

            Book selectedBook = mainForm.bookList.FirstOrDefault(b => b.Title == selectedTitle);

            if (selectedBook != null) 
            {
                
                    string reviewText = rtbReview.Text;
                    int rating = (int)nudRating.Value;
                    DateTime createdAt = DateTime.Now;

                    Review newReview = new Review(Review.GetNextId(), selectedBook.Id, reviewText, rating, createdAt);

                    mainForm.reviewList.Add(newReview);
                }
                mainForm.DisplayReviews(mainForm.reviewList);
            
                MessageBox.Show("Selected book not found.", "Error");
           
            this.Close();
        }
    }
}
