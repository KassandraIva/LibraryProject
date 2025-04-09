namespace LibraryProject
{
    partial class ReviewForm
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
            lblBooks = new Label();
            lblRating = new Label();
            lblReview = new Label();
            cmbBook = new ComboBox();
            nudRating = new NumericUpDown();
            rtbReview = new RichTextBox();
            btnAddReview = new Button();
            btnCancelReview = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Location = new Point(109, 41);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(46, 20);
            lblBooks.TabIndex = 0;
            lblBooks.Text = "Book:";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(109, 106);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(55, 20);
            lblRating.TabIndex = 1;
            lblRating.Text = "Rating:";
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Location = new Point(110, 166);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(59, 20);
            lblReview.TabIndex = 2;
            lblReview.Text = "Review:";
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(253, 38);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(151, 28);
            cmbBook.TabIndex = 3;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(253, 99);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(150, 27);
            nudRating.TabIndex = 4;
            // 
            // rtbReview
            // 
            rtbReview.Location = new Point(253, 166);
            rtbReview.Name = "rtbReview";
            rtbReview.Size = new Size(151, 191);
            rtbReview.TabIndex = 5;
            rtbReview.Text = "";
            // 
            // btnAddReview
            // 
            btnAddReview.Location = new Point(109, 389);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(101, 29);
            btnAddReview.TabIndex = 6;
            btnAddReview.Text = "Add Review";
            btnAddReview.UseVisualStyleBackColor = true;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // btnCancelReview
            // 
            btnCancelReview.Location = new Point(309, 389);
            btnCancelReview.Name = "btnCancelReview";
            btnCancelReview.Size = new Size(94, 29);
            btnCancelReview.TabIndex = 7;
            btnCancelReview.Text = "Cancel";
            btnCancelReview.UseVisualStyleBackColor = true;
            btnCancelReview.Click += btnCancelReview_Click;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 457);
            Controls.Add(btnCancelReview);
            Controls.Add(btnAddReview);
            Controls.Add(rtbReview);
            Controls.Add(nudRating);
            Controls.Add(cmbBook);
            Controls.Add(lblReview);
            Controls.Add(lblRating);
            Controls.Add(lblBooks);
            Name = "ReviewForm";
            Text = "ReviewForm";
            Load += ReviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBooks;
        private Label lblRating;
        private Label lblReview;
        private ComboBox cmbBook;
        private NumericUpDown nudRating;
        private RichTextBox rtbReview;
        private Button btnAddReview;
        private Button btnCancelReview;
    }
}