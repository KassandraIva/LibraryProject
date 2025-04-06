namespace LibraryProject
{
    partial class GenreForm
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
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(111, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(43, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 2;
            // 
            // GenreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 213);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "GenreForm";
            Text = "GenreForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private TextBox txtName;
    }
}