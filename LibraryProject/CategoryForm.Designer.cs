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
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(118, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(60, 86);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 15);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color: ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(29, 156);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description: ";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(51, 119);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(51, 15);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 5;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 223);
            Controls.Add(txtName);
            Controls.Add(lblPriority);
            Controls.Add(lblDescription);
            Controls.Add(lblColor);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "CategoryForm";
            Text = "CategoryForm";
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
    }
}