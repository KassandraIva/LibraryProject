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
    public partial class AuthorForm : EntityForm<Author>
    {
        protected override Label LblId => lblId;
        protected override Button BtnAccept => btnAccept;
        protected override Button BtnCancel => btnCancel;

        public AuthorForm()
        {
            InitializeComponent();
        }

        //private void AuthorForm_Load(object sender, EventArgs e) { }

        protected override void DisplayEntity()
        {
            lblId.Text = $"Id: {Entity.Id}";
            txtFirstName.Text = Entity.FirstName;
            txtLastName.Text = Entity.LastName;
        }

        protected override bool Validation()
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

        protected override void UpdateEntity()
        {
            if (IsNew)
                Entity = new Author(txtFirstName.Text, txtLastName.Text);
            else
            {
                Entity.FirstName = txtFirstName.Text;
                Entity.LastName = txtLastName.Text;
            }
        }
    }
}
