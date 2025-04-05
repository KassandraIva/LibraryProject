using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.classes;
using LibraryProject.entities;

namespace LibraryProject
{
    public partial class AuthorForm : Form
    {
        public Author Author { get; set; }
        public bool AddAuthor { get; set; }

        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            if (AddAuthor)
            {
                this.Text = "Add Author";
                lblId.Visible = false;
            }
            else
            {
                this.Text = "Edit Author";
                lblId.Visible = true;
                this.DisplayAuthor();
            }
        }

        private void DisplayAuthor()
        {
            lblId.Text = $"Id: {Author.Id}";
            txtFirstName.Text = Author.FirstName;
            txtLastName.Text = Author.LastName;
        }

        private bool Validation()
        {
            bool isValid = true;

            if (txtFirstName.Text == "")
            {
                MessageBox.Show("FirstName is a required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("LastName is a required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (AddAuthor)
                {
                    this.Author = new Author(txtFirstName.Text, txtLastName.Text);
                }
                else
                {
                    Author.FirstName = txtFirstName.Text;
                    Author.LastName = txtLastName.Text;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
