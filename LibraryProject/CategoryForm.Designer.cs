namespace LibraryProject
{
    partial class CategoryForm
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
            lblId = new Label();
            lblName = new Label();
            lblColor = new Label();
            lblDescription = new Label();
            lblPriority = new Label();
            txtName = new TextBox();
            btnPickColor = new Button();
            txtColor = new TextBox();
            nudPriority = new NumericUpDown();
            rtbDescription = new RichTextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPriority).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(118, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(67, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(70, 69);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 15);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color: ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(39, 127);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description: ";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(61, 96);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(51, 15);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 23);
            txtName.TabIndex = 5;
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(272, 65);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(103, 23);
            btnPickColor.TabIndex = 6;
            btnPickColor.Text = "Pick Color";
            btnPickColor.UseVisualStyleBackColor = true;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(118, 65);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(148, 23);
            txtColor.TabIndex = 7;
            // 
            // nudPriority
            // 
            nudPriority.Location = new Point(118, 94);
            nudPriority.Name = "nudPriority";
            nudPriority.Size = new Size(257, 23);
            nudPriority.TabIndex = 8;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(118, 124);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(257, 96);
            rtbDescription.TabIndex = 9;
            rtbDescription.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(195, 237);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 11;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 281);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(rtbDescription);
            Controls.Add(nudPriority);
            Controls.Add(txtColor);
            Controls.Add(btnPickColor);
            Controls.Add(txtName);
            Controls.Add(lblPriority);
            Controls.Add(lblDescription);
            Controls.Add(lblColor);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)nudPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblColor;
        private Label lblDescription;
        private Label lblPriority;
        private TextBox txtName;
        private Button btnPickColor;
        private TextBox txtColor;
        private NumericUpDown nudPriority;
        private RichTextBox rtbDescription;
        private Button btnCancel;
        private Button btnAccept;
    }
}