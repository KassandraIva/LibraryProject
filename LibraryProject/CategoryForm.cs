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
            txtColor.Text = Category.Color;
            rtbDescription.Text = Category.Description;
            nudPriority.Value = Category.Priority;

            Color color = ColorTranslator.FromHtml(Category.Color);
            txtColor.BackColor = color;
            txtColor.ForeColor = GetTextColorForBackground(color);

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
                if (AddCategory)
                {
                    this.Category = new Category(txtName.Text, txtColor.Text, rtbDescription.Text, Convert.ToInt32(nudPriority.Value));
                }
                else
                {
                    Category.Name = txtName.Text;
                    Category.Color = txtColor.Text;
                    Category.Description = rtbDescription.Text;
                    Category.Priority = Convert.ToInt32(nudPriority.Value);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Color GetTextColorForBackground(Color bgColor)
        {
            double brightness = 0.299 * bgColor.R + 0.587 * bgColor.G + 0.114 * bgColor.B;
            return brightness > 160 ? Color.Black : Color.White;
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            try
            {
                colorDialog.Color = ColorTranslator.FromHtml(txtColor.Text);
            }
            catch { }

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                txtColor.Text = ColorTranslator.ToHtml(selectedColor);
                txtColor.BackColor = selectedColor;
                txtColor.ForeColor = GetTextColorForBackground(selectedColor);
            }
        }
    }
}
