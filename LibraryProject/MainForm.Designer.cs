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
            tabReviews.Location = new Point(12, 12);
            tabReviews.Name = "tabReviews";
            tabReviews.SelectedIndex = 0;
            tabReviews.Size = new Size(1006, 547);
            tabReviews.TabIndex = 0;
            // 
            // tabAllBooks
            // 
            tabAllBooks.Controls.Add(btnAddBook);
            tabAllBooks.Controls.Add(btnSearchBook);
            tabAllBooks.Controls.Add(dgvAllBooks);
            tabAllBooks.Controls.Add(txtSearch);
            tabAllBooks.Location = new Point(4, 24);
            tabAllBooks.Name = "tabAllBooks";
            tabAllBooks.Padding = new Padding(3, 2, 3, 2);
            tabAllBooks.Size = new Size(998, 519);
            tabAllBooks.TabIndex = 0;
            tabAllBooks.Text = "All Books";
            tabAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(859, 11);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(133, 23);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(537, 11);
            btnSearchBook.Margin = new Padding(3, 2, 3, 2);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(133, 23);
            btnSearchBook.TabIndex = 2;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // dgvAllBooks
            // 
            dgvAllBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllBooks.Location = new Point(6, 44);
            dgvAllBooks.Name = "dgvAllBooks";
            dgvAllBooks.RowHeadersWidth = 51;
            dgvAllBooks.Size = new Size(986, 469);
            dgvAllBooks.TabIndex = 1;
            dgvAllBooks.CellClick += dgvAllBooks_CellClick;
            dgvAllBooks.CellPainting += dgvAllBooks_CellPainting;
            dgvAllBooks.CellValueChanged += dgvAllBooks_CellValueChanged_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(5, 11);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(526, 23);
            txtSearch.TabIndex = 0;
            // 
            // tabAllAuthors
            // 
            tabAllAuthors.Controls.Add(btnSearchAuthor);
            tabAllAuthors.Controls.Add(textBox1);
            tabAllAuthors.Controls.Add(btnAddAuthor);
            tabAllAuthors.Controls.Add(dgvAllAuthors);
            tabAllAuthors.Location = new Point(4, 24);
            tabAllAuthors.Name = "tabAllAuthors";
            tabAllAuthors.Padding = new Padding(3, 2, 3, 2);
            tabAllAuthors.Size = new Size(998, 519);
            tabAllAuthors.TabIndex = 1;
            tabAllAuthors.Text = "All Authors";
            tabAllAuthors.UseVisualStyleBackColor = true;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(531, 10);
            btnSearchAuthor.Margin = new Padding(3, 2, 3, 2);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(131, 23);
            btnSearchAuthor.TabIndex = 3;
            btnSearchAuthor.Text = "Search";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 11);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(520, 23);
            textBox1.TabIndex = 2;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(860, 11);
            btnAddAuthor.Margin = new Padding(3, 2, 3, 2);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(132, 23);
            btnAddAuthor.TabIndex = 1;
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // dgvAllAuthors
            // 
            dgvAllAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllAuthors.Location = new Point(6, 44);
            dgvAllAuthors.Name = "dgvAllAuthors";
            dgvAllAuthors.RowHeadersWidth = 51;
            dgvAllAuthors.Size = new Size(986, 469);
            dgvAllAuthors.TabIndex = 0;
            // 
            // tabQuotes
            // 
            tabQuotes.Controls.Add(btnAddQuote);
            tabQuotes.Controls.Add(dgvQuotes);
            tabQuotes.Location = new Point(4, 24);
            tabQuotes.Name = "tabQuotes";
            tabQuotes.Padding = new Padding(3, 3, 3, 3);
            tabQuotes.Size = new Size(998, 519);
            tabQuotes.TabIndex = 2;
            tabQuotes.Text = "Quotes";
            tabQuotes.UseVisualStyleBackColor = true;
            // 
            // btnAddQuote
            // 
            btnAddQuote.Location = new Point(877, 23);
            btnAddQuote.Margin = new Padding(3, 2, 3, 2);
            btnAddQuote.Name = "btnAddQuote";
            btnAddQuote.Size = new Size(82, 22);
            btnAddQuote.TabIndex = 1;
            btnAddQuote.Text = "Add Quote";
            btnAddQuote.UseVisualStyleBackColor = true;
            btnAddQuote.Click += btnAddQuote_Click;
            // 
            // dgvQuotes
            // 
            dgvQuotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuotes.Location = new Point(5, 59);
            dgvQuotes.Margin = new Padding(3, 2, 3, 2);
            dgvQuotes.Name = "dgvQuotes";
            dgvQuotes.RowHeadersWidth = 51;
            dgvQuotes.Size = new Size(978, 436);
            dgvQuotes.TabIndex = 0;
            dgvQuotes.CellClick += dgvQuotes_CellClick;
            // 
            // tabBorrowedLent
            // 
            tabBorrowedLent.Controls.Add(dgvBorrowed);
            tabBorrowedLent.Location = new Point(4, 24);
            tabBorrowedLent.Name = "tabBorrowedLent";
            tabBorrowedLent.Size = new Size(998, 519);
            tabBorrowedLent.TabIndex = 3;
            tabBorrowedLent.Text = "Borrowed/Lent";
            tabBorrowedLent.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowed
            // 
            dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowed.Location = new Point(22, 35);
            dgvBorrowed.Margin = new Padding(3, 2, 3, 2);
            dgvBorrowed.Name = "dgvBorrowed";
            dgvBorrowed.RowHeadersWidth = 51;
            dgvBorrowed.Size = new Size(609, 458);
            dgvBorrowed.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddMisc);
            tabPage1.Controls.Add(dgvMiscItems);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(998, 519);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Misc. Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddMisc
            // 
            btnAddMisc.Location = new Point(839, 26);
            btnAddMisc.Margin = new Padding(3, 2, 3, 2);
            btnAddMisc.Name = "btnAddMisc";
            btnAddMisc.Size = new Size(108, 26);
            btnAddMisc.TabIndex = 1;
            btnAddMisc.Text = "Add New Item";
            btnAddMisc.UseVisualStyleBackColor = true;
            btnAddMisc.Click += btnAddMisc_Click;
            // 
            // dgvMiscItems
            // 
            dgvMiscItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiscItems.Location = new Point(18, 77);
            dgvMiscItems.Margin = new Padding(3, 2, 3, 2);
            dgvMiscItems.Name = "dgvMiscItems";
            dgvMiscItems.RowHeadersWidth = 51;
            dgvMiscItems.Size = new Size(949, 419);
            dgvMiscItems.TabIndex = 0;
            dgvMiscItems.CellClick += dgvMiscItems_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnAddReview);
            tabPage2.Controls.Add(dgvReviews);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(998, 519);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "Review";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnAddReview
            // 
            BtnAddReview.Location = new Point(673, 41);
            BtnAddReview.Margin = new Padding(3, 2, 3, 2);
            BtnAddReview.Name = "BtnAddReview";
            BtnAddReview.Size = new Size(175, 23);
            BtnAddReview.TabIndex = 1;
            BtnAddReview.Text = "Add review";
            BtnAddReview.UseVisualStyleBackColor = true;
            BtnAddReview.Click += BtnAddReview_Click;
            // 
            // dgvReviews
            // 
            dgvReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReviews.Location = new Point(31, 82);
            dgvReviews.Margin = new Padding(3, 2, 3, 2);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.RowHeadersWidth = 51;
            dgvReviews.Size = new Size(963, 410);
            dgvReviews.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 571);
            Controls.Add(tabReviews);
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
