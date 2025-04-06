using LibraryProject.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class AddMiscItems : Form
    {
        private MainForm mainForm;
        public bool IsEditMode { get; set; } = false;
        public MiscItems ItemToEdit { get; set; }

        public AddMiscItems(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void AddMiscItems_Load(object sender, EventArgs e)
        {
            if (IsEditMode && ItemToEdit != null)
            {
                txtName.Text = ItemToEdit.Name;
                txtCreator.Text = ItemToEdit.Creator;
                cmbType.SelectedItem = ItemToEdit.Genre;
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            int id = MiscItems.GetNextId();

            string genre = cmbType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Please select a genre.");
                return;
            }

            if (IsEditMode && ItemToEdit != null)
            {
                ItemToEdit.Name = txtName.Text;
                ItemToEdit.Creator = txtCreator.Text;
                ItemToEdit.Genre = genre;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MiscItems newItem = new MiscItems(txtName.Text, txtCreator.Text, genre);
                newItem.Id = id;

                MiscItems.SaveToFile(newItem);
                mainForm.miscItems.Add(newItem);
                mainForm.DisplayMiscItems(mainForm.miscItems);

                this.Close();
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
