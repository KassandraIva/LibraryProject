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
            lblBookId.Location = new Point(463, 24);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(29, 20);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Id: ";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(64, 65);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(45, 20);
            lblBookTitle.TabIndex = 1;
            lblBookTitle.Text = "Title: ";
            // 
            // lblBookAuthors
            // 
            lblBookAuthors.AutoSize = true;
            lblBookAuthors.Location = new Point(42, 339);
            lblBookAuthors.Name = "lblBookAuthors";
            lblBookAuthors.Size = new Size(67, 20);
            lblBookAuthors.TabIndex = 2;
            lblBookAuthors.Text = "Authors: ";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Location = new Point(22, 143);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(92, 20);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Description: ";
            // 
            // lblBookStatus
            // 
            lblBookStatus.AutoSize = true;
            lblBookStatus.Location = new Point(54, 104);
            lblBookStatus.Name = "lblBookStatus";
            lblBookStatus.Size = new Size(56, 20);
            lblBookStatus.TabIndex = 4;
            lblBookStatus.Text = "Status: ";
            // 
            // lbxAuthors
            // 
            lbxAuthors.AllowDrop = true;
            lbxAuthors.FormattingEnabled = true;
            lbxAuthors.Location = new Point(141, 339);
            lbxAuthors.Margin = new Padding(3, 4, 3, 4);
            lbxAuthors.Name = "lbxAuthors";
            lbxAuthors.Size = new Size(286, 104);
            lbxAuthors.TabIndex = 5;
            lbxAuthors.DragDrop += (s, e) => ListBox_DragDrop(s, e, selectedAuthors, "DisplayName");
            lbxAuthors.DragEnter += (s, e) => ListBox_DragEnter<Author>(s, e);
            lbxAuthors.KeyDown += (s, e) => ListBox_KeyDown(s, e, selectedAuthors, "DisplayName");
            // 
            // lbxAllAuthors
            // 
            lbxAllAuthors.AllowDrop = true;
            lbxAllAuthors.FormattingEnabled = true;
            lbxAllAuthors.Location = new Point(602, 339);
            lbxAllAuthors.Margin = new Padding(3, 4, 3, 4);
            lbxAllAuthors.Name = "lbxAllAuthors";
            lbxAllAuthors.Size = new Size(286, 104);
            lbxAllAuthors.TabIndex = 8;
            lbxAllAuthors.MouseDown += (s, e) => ListBox_MouseDown<Author>(s, e);
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(141, 100);
            cbxStatus.Margin = new Padding(3, 4, 3, 4);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(286, 28);
            cbxStatus.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(141, 61);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(286, 27);
            txtTitle.TabIndex = 10;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(141, 139);
            rtbDescription.Margin = new Padding(3, 4, 3, 4);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(286, 191);
            rtbDescription.TabIndex = 11;
            rtbDescription.Text = "";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(26, 452);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(87, 20);
            lblCategories.TabIndex = 13;
            lblCategories.Text = "Categories: ";
            // 
            // lblGenres
            // 
            lblGenres.AutoSize = true;
            lblGenres.Location = new Point(49, 565);
            lblGenres.Name = "lblGenres";
            lblGenres.Size = new Size(61, 20);
            lblGenres.TabIndex = 14;
            lblGenres.Text = "Genres: ";
            // 
            // lbxCategories
            // 
            lbxCategories.AllowDrop = true;
            lbxCategories.FormattingEnabled = true;
            lbxCategories.Location = new Point(141, 452);
            lbxCategories.Margin = new Padding(3, 4, 3, 4);
            lbxCategories.Name = "lbxCategories";
            lbxCategories.Size = new Size(286, 104);
            lbxCategories.TabIndex = 15;
            lbxCategories.DragDrop += (s, e) => ListBox_DragDrop(s, e, selectedCategories, "Name");
            lbxCategories.DragEnter += (s, e) => ListBox_DragEnter<Category>(s, e);
            lbxCategories.KeyDown += (s, e) => ListBox_KeyDown(s, e, selectedCategories, "Name");
            // 
            // lbxAllCategories
            // 
            lbxAllCategories.AllowDrop = true;
            lbxAllCategories.FormattingEnabled = true;
            lbxAllCategories.Location = new Point(602, 452);
            lbxAllCategories.Margin = new Padding(3, 4, 3, 4);
            lbxAllCategories.Name = "lbxAllCategories";
            lbxAllCategories.Size = new Size(286, 104);
            lbxAllCategories.TabIndex = 16;
            lbxAllCategories.MouseDown += (s, e) => ListBox_MouseDown<Category>(s, e);
            // 
            // lbxGenres
            // 
            lbxGenres.AllowDrop = true;
            lbxGenres.FormattingEnabled = true;
            lbxGenres.Location = new Point(141, 565);
            lbxGenres.Margin = new Padding(3, 4, 3, 4);
            lbxGenres.Name = "lbxGenres";
            lbxGenres.Size = new Size(286, 104);
            lbxGenres.TabIndex = 17;
            lbxGenres.DragDrop += (s, e) => ListBox_DragDrop(s, e, selectedGenres, "Name");
            lbxGenres.DragEnter += (s, e) => ListBox_DragEnter<Genre>(s, e);
            lbxGenres.KeyDown += (s, e) => ListBox_KeyDown(s, e, selectedGenres, "Name");
            // 
            // lbxAllGenres
            // 
            lbxAllGenres.AllowDrop = true;
            lbxAllGenres.FormattingEnabled = true;
            lbxAllGenres.Location = new Point(602, 565);
            lbxAllGenres.Margin = new Padding(3, 4, 3, 4);
            lbxAllGenres.Name = "lbxAllGenres";
            lbxAllGenres.Size = new Size(286, 104);
            lbxAllGenres.TabIndex = 18;
            lbxAllGenres.MouseDown += (s, e) => ListBox_MouseDown<Genre>(s, e);
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(607, 704);
            btnAccept.Margin = new Padding(3, 4, 3, 4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(121, 31);
            btnAccept.TabIndex = 19;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(774, 704);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 31);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddNewAuthor
            // 
            btnAddNewAuthor.Location = new Point(434, 359);
            btnAddNewAuthor.Margin = new Padding(3, 4, 3, 4);
            btnAddNewAuthor.Name = "btnAddNewAuthor";
            btnAddNewAuthor.Size = new Size(161, 31);
            btnAddNewAuthor.TabIndex = 21;
            btnAddNewAuthor.Text = "Add New Author";
            btnAddNewAuthor.UseVisualStyleBackColor = true;
            btnAddNewAuthor.Click += btnAddNewAuthor_Click;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(434, 397);
            btnDeleteAuthor.Margin = new Padding(3, 4, 3, 4);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(161, 31);
            btnDeleteAuthor.TabIndex = 22;
            btnDeleteAuthor.Text = "Delete Author";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += (s, e) => btnDelete_Click(lbxAuthors, selectedAuthors, "DisplayName");
            // 
            // btnAddNewCategory
            // 
            btnAddNewCategory.Location = new Point(434, 468);
            btnAddNewCategory.Margin = new Padding(3, 4, 3, 4);
            btnAddNewCategory.Name = "btnAddNewCategory";
            btnAddNewCategory.Size = new Size(161, 31);
            btnAddNewCategory.TabIndex = 23;
            btnAddNewCategory.Text = "Add New Category";
            btnAddNewCategory.UseVisualStyleBackColor = true;
            btnAddNewCategory.Click += btnAddNewCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(434, 507);
            btnDeleteCategory.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(161, 31);
            btnDeleteCategory.TabIndex = 24;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += (s, e) => btnDelete_Click(lbxCategories, selectedCategories, "Name");
            // 
            // btnAddNewGenre
            // 
            btnAddNewGenre.Location = new Point(434, 579);
            btnAddNewGenre.Margin = new Padding(3, 4, 3, 4);
            btnAddNewGenre.Name = "btnAddNewGenre";
            btnAddNewGenre.Size = new Size(161, 31);
            btnAddNewGenre.TabIndex = 25;
            btnAddNewGenre.Text = "Add New Genre";
            btnAddNewGenre.UseVisualStyleBackColor = true;
            btnAddNewGenre.Click += btnAddNewGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Location = new Point(434, 617);
            btnDeleteGenre.Margin = new Padding(3, 4, 3, 4);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(161, 31);
            btnDeleteGenre.TabIndex = 26;
            btnDeleteGenre.Text = "Delete Genre";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += (s, e) => btnDelete_Click(lbxGenres, selectedGenres, "Name");
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 769);
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
            Margin = new Padding(3, 4, 3, 4);
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