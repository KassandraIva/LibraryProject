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
        }
    }
}
