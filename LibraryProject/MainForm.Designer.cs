namespace LibraryProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabReviews = new TabControl();
            tabAllBooks = new TabPage();
            btnAddBook = new Button();
            btnSearchBook = new Button();
            dgvAllBooks = new DataGridView();
            txtSearchBook = new TextBox();
            tabAllAuthors = new TabPage();
            btnSearchAuthor = new Button();
            txtSearchAuthor = new TextBox();
            btnAddAuthor = new Button();
            dgvAllAuthors = new DataGridView();
            tabCategoriesGenres = new TabPage();
            lblGenres = new Label();
            lblCategories = new Label();
            btnAddGenre = new Button();
            btnAddCategory = new Button();
            dgvGenres = new DataGridView();
            dgvCategories = new DataGridView();
            tabQuotes = new TabPage();
            btnAddQuote = new Button();
            dgvQuotes = new DataGridView();
            tabBorrowedLent = new TabPage();
            dgvBorrowed = new DataGridView();
            tabPage1 = new TabPage();
            btnAddMisc = new Button();
            dgvMiscItems = new DataGridView();
            tabPage2 = new TabPage();
            BtnAddReview = new Button();
            dgvReviews = new DataGridView();
            tabReviews.SuspendLayout();
            tabAllBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllBooks).BeginInit();
            tabAllAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllAuthors).BeginInit();
            tabCategoriesGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            tabQuotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuotes).BeginInit();
            tabBorrowedLent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiscItems).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            SuspendLayout();
            // 
            // tabReviews
            // 
            tabReviews.Controls.Add(tabAllBooks);
            tabReviews.Controls.Add(tabAllAuthors);
            tabReviews.Controls.Add(tabCategoriesGenres);
            tabReviews.Controls.Add(tabQuotes);
            tabReviews.Controls.Add(tabBorrowedLent);
            tabReviews.Controls.Add(tabPage1);
            tabReviews.Controls.Add(tabPage2);
            tabReviews.Location = new Point(14, 16);
            tabReviews.Margin = new Padding(3, 4, 3, 4);
            tabReviews.Name = "tabReviews";
            tabReviews.SelectedIndex = 0;
            tabReviews.Size = new Size(1150, 729);
            tabReviews.TabIndex = 0;
            // 
            // tabAllBooks
            // 
            tabAllBooks.Controls.Add(btnAddBook);
            tabAllBooks.Controls.Add(btnSearchBook);
            tabAllBooks.Controls.Add(dgvAllBooks);
            tabAllBooks.Controls.Add(txtSearchBook);
            tabAllBooks.Location = new Point(4, 29);
            tabAllBooks.Margin = new Padding(3, 4, 3, 4);
            tabAllBooks.Name = "tabAllBooks";
            tabAllBooks.Padding = new Padding(3, 3, 3, 3);
            tabAllBooks.Size = new Size(1142, 696);
            tabAllBooks.TabIndex = 0;
            tabAllBooks.Text = "All Books";
            tabAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(982, 15);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(152, 31);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(614, 15);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(152, 31);
            btnSearchBook.TabIndex = 2;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // dgvAllBooks
            // 
            dgvAllBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllBooks.Location = new Point(7, 59);
            dgvAllBooks.Margin = new Padding(3, 4, 3, 4);
            dgvAllBooks.Name = "dgvAllBooks";
            dgvAllBooks.RowHeadersWidth = 51;
            dgvAllBooks.Size = new Size(1127, 625);
            dgvAllBooks.TabIndex = 1;
            dgvAllBooks.CellClick += dgvAllBooks_CellClick;
            dgvAllBooks.CellPainting += dgvAllBooks_CellPainting;
            dgvAllBooks.CellValueChanged += dgvAllBooks_CellValueChanged_1;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(6, 15);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(601, 27);
            txtSearchBook.TabIndex = 0;
            // 
            // tabAllAuthors
            // 
            tabAllAuthors.Controls.Add(btnSearchAuthor);
            tabAllAuthors.Controls.Add(txtSearchAuthor);
            tabAllAuthors.Controls.Add(btnAddAuthor);
            tabAllAuthors.Controls.Add(dgvAllAuthors);
            tabAllAuthors.Location = new Point(4, 29);
            tabAllAuthors.Margin = new Padding(3, 4, 3, 4);
            tabAllAuthors.Name = "tabAllAuthors";
            tabAllAuthors.Padding = new Padding(3, 3, 3, 3);
            tabAllAuthors.Size = new Size(1142, 696);
            tabAllAuthors.TabIndex = 1;
            tabAllAuthors.Text = "All Authors";
            tabAllAuthors.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(607, 13);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(150, 31);
            btnSearchAuthor.TabIndex = 3;
            btnSearchAuthor.Text = "Search";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Location = new Point(6, 15);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(594, 27);
            txtSearchAuthor.TabIndex = 2;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(983, 15);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(151, 31);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // dgvAllAuthors
            // 
            dgvAllAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllAuthors.Location = new Point(7, 59);
            dgvAllAuthors.Margin = new Padding(3, 4, 3, 4);
            dgvAllAuthors.Name = "dgvAllAuthors";
            dgvAllAuthors.RowHeadersWidth = 51;
            dgvAllAuthors.Size = new Size(1127, 625);
            dgvAllAuthors.TabIndex = 0;
            dgvAllAuthors.CellClick += dgvAllAuthors_CellClick;
            // 
            // tabCategoriesGenres
            // 
            tabCategoriesGenres.Controls.Add(lblGenres);
            tabCategoriesGenres.Controls.Add(lblCategories);
            tabCategoriesGenres.Controls.Add(btnAddGenre);
            tabCategoriesGenres.Controls.Add(btnAddCategory);
            tabCategoriesGenres.Controls.Add(dgvGenres);
            tabCategoriesGenres.Controls.Add(dgvCategories);
            tabCategoriesGenres.Location = new Point(4, 29);
            tabCategoriesGenres.Margin = new Padding(3, 4, 3, 4);
            tabCategoriesGenres.Name = "tabCategoriesGenres";
            tabCategoriesGenres.Size = new Size(1142, 696);
            tabCategoriesGenres.TabIndex = 6;
            tabCategoriesGenres.Text = "Categories/Genres";
            tabCategoriesGenres.UseVisualStyleBackColor = true;
            // 
            // lblGenres
            // 
            lblGenres.AutoSize = true;
            lblGenres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblGenres.Location = new Point(626, 21);
            lblGenres.Name = "lblGenres";
            lblGenres.Size = new Size(56, 20);
            lblGenres.TabIndex = 5;
            lblGenres.Text = "Genres";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCategories.Location = new Point(25, 21);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(81, 20);
            lblCategories.TabIndex = 4;
            lblCategories.Text = "Categories";
            // 
            // btnAddGenre
            // 
            btnAddGenre.Location = new Point(969, 16);
            btnAddGenre.Margin = new Padding(3, 4, 3, 4);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(142, 31);
            btnAddGenre.TabIndex = 3;
            btnAddGenre.Text = "Add Genre";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += btnAddGenre_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(393, 16);
            btnAddCategory.Margin = new Padding(3, 4, 3, 4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(142, 31);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dgvGenres
            // 
            dgvGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenres.Location = new Point(597, 60);
            dgvGenres.Margin = new Padding(3, 4, 3, 4);
            dgvGenres.Name = "dgvGenres";
            dgvGenres.RowHeadersWidth = 51;
            dgvGenres.Size = new Size(541, 628);
            dgvGenres.TabIndex = 1;
            dgvGenres.CellClick += dgvGenres_CellClick;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(3, 60);
            dgvCategories.Margin = new Padding(3, 4, 3, 4);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(565, 628);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // tabQuotes
            // 
            tabQuotes.Controls.Add(btnAddQuote);
            tabQuotes.Controls.Add(dgvQuotes);
            tabQuotes.Location = new Point(4, 29);
            tabQuotes.Margin = new Padding(3, 4, 3, 4);
            tabQuotes.Name = "tabQuotes";
            tabQuotes.Padding = new Padding(3, 4, 3, 4);
            tabQuotes.Size = new Size(1142, 696);
            tabQuotes.TabIndex = 2;
            tabQuotes.Text = "Quotes";
            tabQuotes.UseVisualStyleBackColor = true;
            // 
            // btnAddQuote
            // 
            btnAddQuote.Location = new Point(1002, 31);
            btnAddQuote.Name = "btnAddQuote";
            btnAddQuote.Size = new Size(94, 29);
            btnAddQuote.TabIndex = 1;
            btnAddQuote.Text = "Add Quote";
            btnAddQuote.UseVisualStyleBackColor = true;
            btnAddQuote.Click += btnAddQuote_Click;
            // 
            // dgvQuotes
            // 
            dgvQuotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuotes.Location = new Point(6, 79);
            dgvQuotes.Name = "dgvQuotes";
            dgvQuotes.RowHeadersWidth = 51;
            dgvQuotes.Size = new Size(1118, 581);
            dgvQuotes.TabIndex = 0;
            dgvQuotes.CellClick += dgvQuotes_CellClick;
            // 
            // tabBorrowedLent
            // 
            tabBorrowedLent.Controls.Add(dgvBorrowed);
            tabBorrowedLent.Location = new Point(4, 29);
            tabBorrowedLent.Margin = new Padding(3, 4, 3, 4);
            tabBorrowedLent.Name = "tabBorrowedLent";
            tabBorrowedLent.Size = new Size(1142, 696);
            tabBorrowedLent.TabIndex = 3;
            tabBorrowedLent.Text = "Borrowed/Lent";
            tabBorrowedLent.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowed
            // 
            dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowed.Location = new Point(25, 47);
            dgvBorrowed.Name = "dgvBorrowed";
            dgvBorrowed.RowHeadersWidth = 51;
            dgvBorrowed.Size = new Size(696, 611);
            dgvBorrowed.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddMisc);
            tabPage1.Controls.Add(dgvMiscItems);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1142, 696);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Misc. Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddMisc
            // 
            btnAddMisc.Location = new Point(959, 35);
            btnAddMisc.Name = "btnAddMisc";
            btnAddMisc.Size = new Size(123, 35);
            btnAddMisc.TabIndex = 1;
            btnAddMisc.Text = "Add New Item";
            btnAddMisc.UseVisualStyleBackColor = true;
            btnAddMisc.Click += btnAddMisc_Click;
            // 
            // dgvMiscItems
            // 
            dgvMiscItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiscItems.Location = new Point(21, 103);
            dgvMiscItems.Name = "dgvMiscItems";
            dgvMiscItems.RowHeadersWidth = 51;
            dgvMiscItems.Size = new Size(1085, 559);
            dgvMiscItems.TabIndex = 0;
            dgvMiscItems.CellClick += dgvMiscItems_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnAddReview);
            tabPage2.Controls.Add(dgvReviews);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1142, 696);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "Review";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnAddReview
            // 
            BtnAddReview.Location = new Point(769, 55);
            BtnAddReview.Name = "BtnAddReview";
            BtnAddReview.Size = new Size(200, 31);
            BtnAddReview.TabIndex = 1;
            BtnAddReview.Text = "Add review";
            BtnAddReview.UseVisualStyleBackColor = true;
            BtnAddReview.Click += BtnAddReview_Click;
            // 
            // dgvReviews
            // 
            dgvReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReviews.Location = new Point(35, 109);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.RowHeadersWidth = 51;
            dgvReviews.Size = new Size(1101, 547);
            dgvReviews.TabIndex = 0;
            dgvReviews.CellClick += dgvReviews_CellClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 761);
            Controls.Add(tabReviews);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Library";
            Load += MainForm_Load;
            tabReviews.ResumeLayout(false);
            tabAllBooks.ResumeLayout(false);
            tabAllBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllBooks).EndInit();
            tabAllAuthors.ResumeLayout(false);
            tabAllAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllAuthors).EndInit();
            tabCategoriesGenres.ResumeLayout(false);
            tabCategoriesGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenres).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            tabQuotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuotes).EndInit();
            tabBorrowedLent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMiscItems).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabReviews;
        private TabPage tabAllBooks;
        private TabPage tabAllAuthors;
        private DataGridView dgvAllBooks;
        private TextBox txtSearchBook;
        private Button btnSearchBook;
        private DataGridView dgvAllAuthors;
        private TabPage tabQuotes;
        private TabPage tabBorrowedLent;
        private Button btnAddBook;
        private TabPage tabPage1;
        private DataGridView dgvMiscItems;
        private Button btnAddMisc;
        private Button btnAddAuthor;
        private Button btnSearchAuthor;
        private TextBox txtSearchAuthor;
        private DataGridView dgvQuotes;
        private DataGridView dgvBorrowed;
        private Button btnAddQuote;
        private TabPage tabPage2;
        private DataGridView dgvReviews;
        private Button BtnAddReview;
        private TabPage tabCategoriesGenres;
        private DataGridView dgvCategories;
        private Label lblGenres;
        private Label lblCategories;
        private Button btnAddGenre;
        private Button btnAddCategory;
        private DataGridView dgvGenres;
    }
}
