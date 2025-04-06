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
            txtSearch = new TextBox();
            tabAllAuthors = new TabPage();
            btnSearchAuthor = new Button();
            textBox1 = new TextBox();
            btnAddAuthor = new Button();
            dgvAllAuthors = new DataGridView();
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
            tabAllBooks.Controls.Add(txtSearch);
            tabAllBooks.Location = new Point(4, 29);
            tabAllBooks.Margin = new Padding(3, 4, 3, 4);
            tabAllBooks.Name = "tabAllBooks";
            tabAllBooks.Padding = new Padding(3);
            tabAllBooks.Size = new Size(1142, 696);
            tabAllBooks.TabIndex = 0;
            tabAllBooks.Text = "All Books";
            tabAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(859, 15);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(152, 31);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(538, 15);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(152, 31);
            btnSearchBook.TabIndex = 2;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
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
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(601, 27);
            txtSearch.TabIndex = 0;
            // 
            // tabAllAuthors
            // 
            tabAllAuthors.Controls.Add(btnSearchAuthor);
            tabAllAuthors.Controls.Add(textBox1);
            tabAllAuthors.Controls.Add(btnAddAuthor);
            tabAllAuthors.Controls.Add(dgvAllAuthors);
            tabAllAuthors.Location = new Point(4, 29);
            tabAllAuthors.Margin = new Padding(3, 4, 3, 4);
            tabAllAuthors.Name = "tabAllAuthors";
            tabAllAuthors.Padding = new Padding(3);
            tabAllAuthors.Size = new Size(1142, 696);
            tabAllAuthors.TabIndex = 1;
            tabAllAuthors.Text = "All Authors";
            tabAllAuthors.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(538, 15);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(134, 23);
            btnSearchAuthor.TabIndex = 3;
            btnSearchAuthor.Text = "Search";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 27);
            textBox1.TabIndex = 2;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(858, 15);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(134, 23);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
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
            dgvQuotes.Size = new Size(1118, 582);
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
            tabPage1.Padding = new Padding(3);
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
            dgvMiscItems.Location = new Point(20, 103);
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
            tabPage2.Padding = new Padding(3);
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
            dgvReviews.Size = new Size(1101, 546);
            dgvReviews.TabIndex = 0;
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
        private TextBox txtSearch;
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
        private TextBox textBox1;
        private DataGridView dgvQuotes;
        private DataGridView dgvBorrowed;
        private Button btnAddQuote;
        private TabPage tabPage2;
        private DataGridView dgvReviews;
        private Button BtnAddReview;
    }
}
