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
using LibraryProject.entities;

namespace LibraryProject
{
    public partial class CategoryForm : EntityForm<Category>
    {
        protected override Label LblId => lblId;
        protected override Button BtnAccept => btnAccept;
        protected override Button BtnCancel => btnCancel;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e) { }

        protected override void DisplayEntity()
        {
            lblId.Text = $"Id: {Entity.Id}";
            txtName.Text = Entity.Name;
            txtColor.Text = Entity.Color;
            rtbDescription.Text = Entity.Description;
            nudPriority.Value = Entity.Priority;
        }

        protected override bool Validation()
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

        protected override void UpdateEntity()
        {
            if (IsNew)
                Entity = new Category(txtName.Text, txtColor.Text, rtbDescription.Text, Convert.ToInt32(nudPriority.Value));
            else
            {
                Entity.Name = txtName.Text;
                Entity.Color = txtColor.Text;
                Entity.Description = rtbDescription.Text;
                Entity.Priority = Convert.ToInt32(nudPriority.Value);
            }
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
