namespace LibraryProject
{
    partial class QuotesForm
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
            lblSelectMedia = new Label();
            lblSelectItem = new Label();
            lblQuote = new Label();
            cmbMedia = new ComboBox();
            cmbItem = new ComboBox();
            rtbQuote = new RichTextBox();
            btnAddQuote = new Button();
            btnCancelQuote = new Button();
            SuspendLayout();
            // 
            // lblSelectMedia
            // 
            lblSelectMedia.AutoSize = true;
            lblSelectMedia.Location = new Point(84, 44);
            lblSelectMedia.Name = "lblSelectMedia";
            lblSelectMedia.Size = new Size(98, 20);
            lblSelectMedia.TabIndex = 0;
            lblSelectMedia.Text = "Select Media:";
            // 
            // lblSelectItem
            // 
            lblSelectItem.AutoSize = true;
            lblSelectItem.Location = new Point(84, 116);
            lblSelectItem.Name = "lblSelectItem";
            lblSelectItem.Size = new Size(86, 20);
            lblSelectItem.TabIndex = 1;
            lblSelectItem.Text = "Select Item:";
            // 
            // lblQuote
            // 
            lblQuote.AutoSize = true;
            lblQuote.Location = new Point(84, 189);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(53, 20);
            lblQuote.TabIndex = 2;
            lblQuote.Text = "Quote:";
            // 
            // cmbMedia
            // 
            cmbMedia.FormattingEnabled = true;
            cmbMedia.Items.AddRange(new object[] { "Book", "Podcast", "Blog", "Article" });
            cmbMedia.Location = new Point(220, 36);
            cmbMedia.Name = "cmbMedia";
            cmbMedia.Size = new Size(213, 28);
            cmbMedia.TabIndex = 3;
            cmbMedia.SelectedIndexChanged += cmbMedia_SelectedIndexChanged;
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(220, 108);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(213, 28);
            cmbItem.TabIndex = 4;
            // 
            // rtbQuote
            // 
            rtbQuote.Location = new Point(220, 189);
            rtbQuote.Name = "rtbQuote";
            rtbQuote.Size = new Size(213, 141);
            rtbQuote.TabIndex = 5;
            rtbQuote.Text = "";
            // 
            // btnAddQuote
            // 
            btnAddQuote.Location = new Point(84, 380);
            btnAddQuote.Name = "btnAddQuote";
            btnAddQuote.Size = new Size(111, 29);
            btnAddQuote.TabIndex = 6;
            btnAddQuote.Text = "Add Quote";
            btnAddQuote.UseVisualStyleBackColor = true;
            btnAddQuote.Click += btnAddQuote_Click;
            // 
            // btnCancelQuote
            // 
            btnCancelQuote.Location = new Point(317, 380);
            btnCancelQuote.Name = "btnCancelQuote";
            btnCancelQuote.Size = new Size(116, 29);
            btnCancelQuote.TabIndex = 7;
            btnCancelQuote.Text = "Cancel";
            btnCancelQuote.UseVisualStyleBackColor = true;
            btnCancelQuote.Click += btnCancelQuote_Click;
            // 
            // QuotesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 458);
            Controls.Add(btnCancelQuote);
            Controls.Add(btnAddQuote);
            Controls.Add(rtbQuote);
            Controls.Add(cmbItem);
            Controls.Add(cmbMedia);
            Controls.Add(lblQuote);
            Controls.Add(lblSelectItem);
            Controls.Add(lblSelectMedia);
            Name = "QuotesForm";
            Text = "Quotes";
            Load += QuotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectMedia;
        private Label lblSelectItem;
        private Label lblQuote;
        private ComboBox cmbMedia;
        private ComboBox cmbItem;
        private RichTextBox rtbQuote;
        private Button btnAddQuote;
        private Button btnCancelQuote;
    }
}