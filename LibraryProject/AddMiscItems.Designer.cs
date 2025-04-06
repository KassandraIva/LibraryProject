namespace LibraryProject
{
    partial class AddMiscItems
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
            lblName = new Label();
            lblCreator = new Label();
            lblType = new Label();
            txtName = new TextBox();
            txtCreator = new TextBox();
            cmbType = new ComboBox();
            btnAddNewItem = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(69, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Location = new Point(69, 109);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(61, 20);
            lblCreator.TabIndex = 1;
            lblCreator.Text = "Creator:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(69, 188);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Type:";
            // 
            // txtName
            // 
            txtName.Location = new Point(211, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(211, 102);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(125, 27);
            txtCreator.TabIndex = 4;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Podcast", "Blog", "Article" });
            cmbType.Location = new Point(211, 180);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(125, 28);
            cmbType.TabIndex = 5;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.Location = new Point(69, 266);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(94, 29);
            btnAddNewItem.TabIndex = 6;
            btnAddNewItem.Text = "Add";
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(242, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddMiscItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 360);
            Controls.Add(btnCancel);
            Controls.Add(btnAddNewItem);
            Controls.Add(cmbType);
            Controls.Add(txtCreator);
            Controls.Add(txtName);
            Controls.Add(lblType);
            Controls.Add(lblCreator);
            Controls.Add(lblName);
            Name = "AddMiscItems";
            Text = "AddMiscItems";
            Load += AddMiscItems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCreator;
        private Label lblType;
        private TextBox txtName;
        private TextBox txtCreator;
        private ComboBox cmbType;
        private Button btnAddNewItem;
        private Button btnCancel;
    }
}