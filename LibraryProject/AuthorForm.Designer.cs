namespace LibraryProject
{
    partial class AuthorForm
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
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnAccept = new Button();
            btnCancel = new Button();
            lblId = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(31, 48);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(31, 77);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(69, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(109, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(179, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(109, 74);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 23);
            txtLastName.TabIndex = 3;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(109, 123);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(213, 123);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(109, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 6;
            lblId.Text = "Id: ";
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 180);
            Controls.Add(lblId);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "AuthorForm";
            Text = "AuthorForm";
            //Load += AuthorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblFirstName;
        protected Label lblLastName;
        protected TextBox txtFirstName;
        protected TextBox txtLastName;
        protected Button btnAccept;
        protected Button btnCancel;
        protected Label lblId;
    }
}