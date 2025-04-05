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
            tabControl1 = new TabControl();
            tabAllBooks = new TabPage();
            btnAddBook = new Button();
            btnSearchBook = new Button();
            dgvAllBooks = new DataGridView();
            txtSearch = new TextBox();
            tabAllAuthors = new TabPage();
            dgvAllAuthors = new DataGridView();
            tabQuotes = new TabPage();
            tabBorrowedLent = new TabPage();
            tabPage1 = new TabPage();
            btnAddMisc = new Button();
            dgvMiscItems = new DataGridView();
            tabControl1.SuspendLayout();
            tabAllBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllBooks).BeginInit();
            tabAllAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllAuthors).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiscItems).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAllBooks);
            tabControl1.Controls.Add(tabAllAuthors);
            tabControl1.Controls.Add(tabQuotes);
            tabControl1.Controls.Add(tabBorrowedLent);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1006, 547);
            tabControl1.TabIndex = 0;
            // 
            // tabAllBooks
            // 
            tabAllBooks.Controls.Add(btnAddBook);
            tabAllBooks.Controls.Add(btnSearchBook);
            tabAllBooks.Controls.Add(dgvAllBooks);
            tabAllBooks.Controls.Add(txtSearch);
            tabAllBooks.Location = new Point(4, 24);
            tabAllBooks.Name = "tabAllBooks";
            tabAllBooks.Padding = new Padding(3, 3, 3, 3);
            tabAllBooks.Size = new Size(998, 519);
            tabAllBooks.TabIndex = 0;
            tabAllBooks.Text = "All Books";
            tabAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(859, 16);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(133, 23);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(549, 16);
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
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(526, 23);
            txtSearch.TabIndex = 0;
            // 
            // tabAllAuthors
            // 
            tabAllAuthors.Controls.Add(dgvAllAuthors);
            tabAllAuthors.Location = new Point(4, 24);
            tabAllAuthors.Name = "tabAllAuthors";
            tabAllAuthors.Padding = new Padding(3, 3, 3, 3);
            tabAllAuthors.Size = new Size(998, 519);
            tabAllAuthors.TabIndex = 1;
            tabAllAuthors.Text = "All Authors";
            tabAllAuthors.UseVisualStyleBackColor = true;
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
            tabQuotes.Location = new Point(4, 24);
            tabQuotes.Name = "tabQuotes";
            tabQuotes.Padding = new Padding(3, 3, 3, 3);
            tabQuotes.Size = new Size(998, 519);
            tabQuotes.TabIndex = 2;
            tabQuotes.Text = "Quotes";
            tabQuotes.UseVisualStyleBackColor = true;
            // 
            // tabBorrowedLent
            // 
            tabBorrowedLent.Location = new Point(4, 24);
            tabBorrowedLent.Name = "tabBorrowedLent";
            tabBorrowedLent.Size = new Size(998, 519);
            tabBorrowedLent.TabIndex = 3;
            tabBorrowedLent.Text = "Borrowed/Lent";
            tabBorrowedLent.UseVisualStyleBackColor = true;
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
            btnAddMisc.Location = new Point(64, 44);
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
            dgvMiscItems.Location = new Point(26, 94);
            dgvMiscItems.Margin = new Padding(3, 2, 3, 2);
            dgvMiscItems.Name = "dgvMiscItems";
            dgvMiscItems.RowHeadersWidth = 51;
            dgvMiscItems.Size = new Size(639, 336);
            dgvMiscItems.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 571);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Library";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabAllBooks.ResumeLayout(false);
            tabAllBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllBooks).EndInit();
            tabAllAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllAuthors).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMiscItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
    }
}
