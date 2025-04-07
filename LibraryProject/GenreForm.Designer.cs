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
            btnCancel = new Button();
            btnAccept = new Button();
            txtColor = new TextBox();
            lblColor = new Label();
            btnPickColor = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(98, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(81, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 23);
            txtName.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(236, 111);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(141, 111);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(81, 70);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(135, 23);
            txtColor.TabIndex = 5;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(30, 73);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 15);
            lblColor.TabIndex = 6;
            lblColor.Text = "Color: ";
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(222, 70);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(89, 23);
            btnPickColor.TabIndex = 7;
            btnPickColor.Text = "Pick Color";
            btnPickColor.UseVisualStyleBackColor = true;
            // 
            // GenreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 160);
            Controls.Add(btnPickColor);
            Controls.Add(lblColor);
            Controls.Add(txtColor);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
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
        private Button btnCancel;
        private Button btnAccept;
        private TextBox txtColor;
        private Label lblColor;
        private Button btnPickColor;
    }
}