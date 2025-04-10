namespace LibraryProject
{
    partial class BookListsForm
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
            lblListName = new Label();
            txtListName = new TextBox();
            lblBooksInList = new Label();
            lsbBooksInList = new ListBox();
            btnAddList = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.Location = new Point(108, 51);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(78, 20);
            lblListName.TabIndex = 0;
            lblListName.Text = "List Name:";
            // 
            // txtListName
            // 
            txtListName.Location = new Point(296, 48);
            txtListName.Name = "txtListName";
            txtListName.Size = new Size(125, 27);
            txtListName.TabIndex = 1;
            // 
            // lblBooksInList
            // 
            lblBooksInList.AutoSize = true;
            lblBooksInList.Location = new Point(108, 135);
            lblBooksInList.Name = "lblBooksInList";
            lblBooksInList.Size = new Size(94, 20);
            lblBooksInList.TabIndex = 2;
            lblBooksInList.Text = "Books In List:";
            // 
            // lsbBooksInList
            // 
            lsbBooksInList.FormattingEnabled = true;
            lsbBooksInList.Location = new Point(296, 135);
            lsbBooksInList.Name = "lsbBooksInList";
            lsbBooksInList.SelectionMode = SelectionMode.MultiExtended;
            lsbBooksInList.Size = new Size(215, 204);
            lsbBooksInList.TabIndex = 3;
            // 
            // btnAddList
            // 
            btnAddList.Location = new Point(150, 378);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(94, 29);
            btnAddList.TabIndex = 4;
            btnAddList.Text = "Add List";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += btnAddList_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(361, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += this.btnCancel_Click;
            // 
            // BookListsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAddList);
            Controls.Add(lsbBooksInList);
            Controls.Add(lblBooksInList);
            Controls.Add(txtListName);
            Controls.Add(lblListName);
            Name = "BookListsForm";
            Text = "BookLists";
            Load += BookListsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListName;
        private TextBox txtListName;
        private Label lblBooksInList;
        private ListBox lsbBooksInList;
        private Button btnAddList;
        private Button btnCancel;
    }
}