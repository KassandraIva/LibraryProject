using LibraryProject.classes;

namespace LibraryProject
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBookId = new Label();
            lblBookTitle = new Label();
            lblBookAuthors = new Label();
            lblBookDescription = new Label();
            lblBookStatus = new Label();
            lbxAuthors = new ListBox();
            lbxAllAuthors = new ListBox();
            cbxStatus = new ComboBox();
            txtTitle = new TextBox();
            rtbDescription = new RichTextBox();
            gbxReview = new GroupBox();
            lblCategories = new Label();
            lblGenres = new Label();
            lbxCategories = new ListBox();
            lbxAllCategories = new ListBox();
            lbxGenres = new ListBox();
            lbxAllGenres = new ListBox();
            btnAccept = new Button();
            btnCancel = new Button();
            btnAddNewAuthor = new Button();
            btnDeleteAuthor = new Button();
            btnAddNewCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddNewGenre = new Button();
            btnDeleteGenre = new Button();
            SuspendLayout();
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(405, 18);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(23, 15);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Id: ";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(56, 49);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(36, 15);
            lblBookTitle.TabIndex = 1;
            lblBookTitle.Text = "Title: ";
            // 
            // lblBookAuthors
            // 
            lblBookAuthors.AutoSize = true;
            lblBookAuthors.Location = new Point(37, 254);
            lblBookAuthors.Name = "lblBookAuthors";
            lblBookAuthors.Size = new Size(55, 15);
            lblBookAuthors.TabIndex = 2;
            lblBookAuthors.Text = "Authors: ";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Location = new Point(19, 107);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(73, 15);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Description: ";
            // 
            // lblBookStatus
            // 
            lblBookStatus.AutoSize = true;
            lblBookStatus.Location = new Point(47, 78);
            lblBookStatus.Name = "lblBookStatus";
            lblBookStatus.Size = new Size(45, 15);
            lblBookStatus.TabIndex = 4;
            lblBookStatus.Text = "Status: ";
            // 
            // lbxAuthors
            // 
            lbxAuthors.AllowDrop = true;
            lbxAuthors.FormattingEnabled = true;
            lbxAuthors.ItemHeight = 15;
            lbxAuthors.Location = new Point(123, 254);
            lbxAuthors.Name = "lbxAuthors";
            lbxAuthors.Size = new Size(251, 79);
            lbxAuthors.TabIndex = 5;
            lbxAuthors.DragDrop += (s, e) => ListBox_DragDrop(s, e, selectedAuthors, "DisplayName");
            lbxAuthors.DragEnter += (s, e) => ListBox_DragEnter<Author>(s, e);
            lbxAuthors.KeyDown += (s, e) => ListBox_KeyDown(s, e, selectedAuthors, "DisplayName");
            // 
            // lbxAllAuthors
            // 
            lbxAllAuthors.AllowDrop = true;
            lbxAllAuthors.FormattingEnabled = true;
            lbxAllAuthors.ItemHeight = 15;
            lbxAllAuthors.Location = new Point(527, 254);
            lbxAllAuthors.Name = "lbxAllAuthors";
            lbxAllAuthors.Size = new Size(251, 79);
            lbxAllAuthors.TabIndex = 8;
            lbxAllAuthors.MouseDown += (s, e) => ListBox_MouseDown<Author>(s, e);
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(123, 75);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(251, 23);
            cbxStatus.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(123, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(251, 23);
            txtTitle.TabIndex = 10;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(123, 104);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(251, 144);
            rtbDescription.TabIndex = 11;
            rtbDescription.Text = "";
            // 
            // gbxReview
            // 
            gbxReview.Location = new Point(405, 46);
            gbxReview.Name = "gbxReview";
            gbxReview.Size = new Size(373, 202);
            gbxReview.TabIndex = 12;
            gbxReview.TabStop = false;
            gbxReview.Text = "Review";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(23, 339);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(69, 15);
            lblCategories.TabIndex = 13;
            lblCategories.Text = "Categories: ";
            // 
            // lblGenres
            // 
            lblGenres.AutoSize = true;
            lblGenres.Location = new Point(43, 424);
            lblGenres.Name = "lblGenres";
            lblGenres.Size = new Size(49, 15);
            lblGenres.TabIndex = 14;
            lblGenres.Text = "Genres: ";
            // 
            // lbxCategories
            // 
            lbxCategories.AllowDrop = true;
            lbxCategories.FormattingEnabled = true;
            lbxCategories.ItemHeight = 15;
            lbxCategories.Location = new Point(123, 339);
            lbxCategories.Name = "lbxCategories";
            lbxCategories.Size = new Size(251, 79);
            lbxCategories.TabIndex = 15;
            lbxCategories.DragDrop += (s, e) => ListBox_DragDrop(s, e, selectedCategories, "Name");
            lbxCategories.DragEnter += (s, e) => ListBox_DragEnter<Category>(s, e);
            lbxCategories.KeyDown += (s, e) => ListBox_KeyDown(s, e, selectedCategories, "Name");
            // 
            // lbxAllCategories
            // 
            lbxAllCategories.AllowDrop = true;
            lbxAllCategories.FormattingEnabled = true;
            lbxAllCategories.ItemHeight = 15;
            lbxAllCategories.Location = new Point(527, 339);
            lbxAllCategories.Name = "lbxAllCategories";
            lbxAllCategories.Size = new Size(251, 79);
            lbxAllCategories.TabIndex = 16;
            lbxAllCategories.MouseDown += (s, e) => ListBox_MouseDown<Category>(s, e);
            // 
            // lbxGenres
            // 
            lbxGenres.AllowDrop = true;
            lbxGenres.FormattingEnabled = true;
            lbxGenres.ItemHeight = 15;
            lbxGenres.Location = new Point(123, 424);
            lbxGenres.Name = "lbxGenres";
            lbxGenres.Size = new Size(251, 79);
            lbxGenres.TabIndex = 17;
            lbxGenres.DragDrop += (s, e) => ListBox_DragDrop(s, e, selectedGenres, "Name");
            lbxGenres.DragEnter += (s, e) => ListBox_DragEnter<Genre>(s, e);
            lbxGenres.KeyDown += (s, e) => ListBox_KeyDown(s, e, selectedGenres, "Name");
            // 
            // lbxAllGenres
            // 
            lbxAllGenres.AllowDrop = true;
            lbxAllGenres.FormattingEnabled = true;
            lbxAllGenres.ItemHeight = 15;
            lbxAllGenres.Location = new Point(527, 424);
            lbxAllGenres.Name = "lbxAllGenres";
            lbxAllGenres.Size = new Size(251, 79);
            lbxAllGenres.TabIndex = 18;
            lbxAllGenres.MouseDown += (s, e) => ListBox_MouseDown<Genre>(s, e);
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(531, 528);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(106, 23);
            btnAccept.TabIndex = 19;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(677, 528);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddNewAuthor
            // 
            btnAddNewAuthor.Location = new Point(380, 269);
            btnAddNewAuthor.Name = "btnAddNewAuthor";
            btnAddNewAuthor.Size = new Size(141, 23);
            btnAddNewAuthor.TabIndex = 21;
            btnAddNewAuthor.Text = "Add New Author";
            btnAddNewAuthor.UseVisualStyleBackColor = true;
            btnAddNewAuthor.Click += btnAddNewAuthor_Click;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(380, 298);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(141, 23);
            btnDeleteAuthor.TabIndex = 22;
            btnDeleteAuthor.Text = "Delete Author";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += (s, e) => btnDelete_Click(lbxAuthors, selectedAuthors, "DisplayName");
            // 
            // btnAddNewCategory
            // 
            btnAddNewCategory.Location = new Point(380, 351);
            btnAddNewCategory.Name = "btnAddNewCategory";
            btnAddNewCategory.Size = new Size(141, 23);
            btnAddNewCategory.TabIndex = 23;
            btnAddNewCategory.Text = "Add New Category";
            btnAddNewCategory.UseVisualStyleBackColor = true;
            btnAddNewCategory.Click += btnAddNewCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(380, 380);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(141, 23);
            btnDeleteCategory.TabIndex = 24;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += (s, e) => btnDelete_Click(lbxCategories, selectedCategories, "Name");
            // 
            // btnAddNewGenre
            // 
            btnAddNewGenre.Location = new Point(380, 434);
            btnAddNewGenre.Name = "btnAddNewGenre";
            btnAddNewGenre.Size = new Size(141, 23);
            btnAddNewGenre.TabIndex = 25;
            btnAddNewGenre.Text = "Add New Genre";
            btnAddNewGenre.UseVisualStyleBackColor = true;
            btnAddNewGenre.Click += btnAddNewGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Location = new Point(380, 463);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(141, 23);
            btnDeleteGenre.TabIndex = 26;
            btnDeleteGenre.Text = "Delete Genre";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += (s, e) => btnDelete_Click(lbxGenres, selectedGenres, "Name");
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(btnDeleteGenre);
            Controls.Add(btnAddNewGenre);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnDeleteAuthor);
            Controls.Add(btnAddNewCategory);
            Controls.Add(btnAddNewAuthor);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(lbxAllGenres);
            Controls.Add(lbxGenres);
            Controls.Add(lbxAllCategories);
            Controls.Add(lbxCategories);
            Controls.Add(lblGenres);
            Controls.Add(lblCategories);
            Controls.Add(gbxReview);
            Controls.Add(rtbDescription);
            Controls.Add(txtTitle);
            Controls.Add(cbxStatus);
            Controls.Add(lbxAllAuthors);
            Controls.Add(lbxAuthors);
            Controls.Add(lblBookStatus);
            Controls.Add(lblBookDescription);
            Controls.Add(lblBookAuthors);
            Controls.Add(lblBookTitle);
            Controls.Add(lblBookId);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblBookId;
        protected Label lblBookTitle;
        protected Label lblBookAuthors;
        protected Label lblBookDescription;
        protected Label lblBookStatus;
        protected ListBox lbxAuthors;
        protected ListBox lbxAllAuthors;
        protected ComboBox cbxStatus;
        protected TextBox txtTitle;
        protected RichTextBox rtbDescription;
        protected GroupBox gbxReview;
        protected Label lblCategories;
        protected Label lblGenres;
        protected ListBox lbxCategories;
        protected ListBox lbxAllCategories;
        protected ListBox lbxGenres;
        protected ListBox lbxAllGenres;
        protected Button btnAccept;
        protected Button btnCancel;
        protected Button btnAddNewAuthor;
        protected Button btnDeleteAuthor;
        protected Button btnAddNewCategory;
        protected Button btnDeleteCategory;
        protected Button btnAddNewGenre;
        protected Button btnDeleteGenre;
    }
}