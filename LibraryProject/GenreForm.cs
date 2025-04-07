using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LibraryProject.classes;

namespace LibraryProject
{
    public partial class GenreForm : Form
    {
        public Genre Genre { get; set; }
        public bool AddGenre { get; set; }

        public GenreForm()
        {
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            if (AddGenre)
            {
                this.Text = "Add Genre";
                lblId.Visible = false;
            }
            else
            {
                this.Text = "Edit Genre";
                lblId.Visible = true;
                this.DisplayGenre();
            }
        }

        private void DisplayGenre()
        {
            lblId.Text = $"Id: {Genre.Id}";
            txtName.Text = Genre.Name;
            txtColor.Text = Genre.Color;
        }

        private bool Validation()
        {
            bool isValid = true;

            if (txtName.Text == "")
            {
                MessageBox.Show("Name is a required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Color is a required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (AddGenre)
                {
                    this.Genre = new Genre(txtName.Text, txtColor.Text);
                }
                else
                {
                    Genre.Name = txtName.Text;
                    Genre.Color = txtColor.Text;
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
