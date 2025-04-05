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
        public AddMiscItems(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            int id = MiscItems.GetNextId(); // Get a unique ID

            // Check if a genre is selected in the ComboBox
            string genre = cmbType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Please select a genre.");
                return; // Exit the method if no genre is selected
            }

            MiscItems newItem = new MiscItems(txtName.Text, txtCreator.Text, genre);
            newItem.Id = id;

            MiscItems.SaveToFile(newItem);
            mainForm.miscItems.Add(newItem);
            mainForm.DisplayMiscItems(mainForm.miscItems);

            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
