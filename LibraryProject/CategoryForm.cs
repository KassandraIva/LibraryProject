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

namespace LibraryProject
{
    public partial class CategoryForm : Form
    {
        public Category Category { get; set; }
        public bool AddCategory { get; set; }

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (AddCategory)
            {
                this.Text = "Add Category";
                lblId.Visible = false;
            }
            else
            {
                this.Text = "Edit Category";
                lblId.Visible = true;
                this.DisplayCategory();
            }
        }

        private void DisplayCategory()
        {
            lblId.Text = $"Id: {Category.Id}";
            txtName.Text = Category.Name;
        }
    }
}
