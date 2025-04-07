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
            txtColor = new TextBox();
            btnPickColor = new Button();
            colorDialog1 = new ColorDialog();
            btnAccept = new Button();
            btnCancel = new Button();
            rtbDescription = new RichTextBox();
            nudPriority = new NumericUpDown();
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
            lblName.Location = new Point(44, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(47, 60);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 15);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color: ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(16, 117);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description: ";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(38, 87);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(51, 15);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 5;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(101, 56);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(105, 23);
            txtColor.TabIndex = 6;
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(212, 56);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(75, 23);
            btnPickColor.TabIndex = 7;
            btnPickColor.Text = "Pick Color";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(131, 184);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 8;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(212, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(101, 114);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(186, 64);
            rtbDescription.TabIndex = 11;
            rtbDescription.Text = "";
            // 
            // nudPriority
            // 
            nudPriority.Location = new Point(101, 85);
            nudPriority.Name = "nudPriority";
            nudPriority.Size = new Size(186, 23);
            nudPriority.TabIndex = 12;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 221);
            Controls.Add(nudPriority);
            Controls.Add(rtbDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(btnPickColor);
            Controls.Add(txtColor);
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

        protected Label lblId;
        protected Label lblName;
        protected Label lblColor;
        protected Label lblDescription;
        protected Label lblPriority;
        protected TextBox txtName;
        protected TextBox txtColor;
        protected Button btnPickColor;
        protected ColorDialog colorDialog1;
        protected Button btnAccept;
        protected Button btnCancel;
        protected RichTextBox rtbDescription;
        protected NumericUpDown nudPriority;
    }
}