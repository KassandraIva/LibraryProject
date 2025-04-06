using LibraryProject.classes;
using LibraryProject.entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryProject
{
    public partial class QuotesForm : Form
    {
        MainForm mainForm;
        Book selectedBook;
        MiscItems selectedMiscItem;

        public bool IsEditMode { get; set; } = false;
        public Quotes ItemToEdit { get; set; }
        public QuotesForm(MainForm mainForm, Book book, MiscItems miscItems)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.selectedBook = book;
            this.selectedMiscItem = miscItems;
        }

        private void QuotesForm_Load(object sender, EventArgs e)
        {
            if (IsEditMode && ItemToEdit != null)
            {
                // Set the existing quote details in the controls
                rtbQuote.Text = ItemToEdit.text;

                // Set the media type
                cmbMedia.SelectedItem = ItemToEdit.media;

                // Set the item name (Book or Miscellaneous)
                if (ItemToEdit.media == "Book")
                {
                    cmbItem.SelectedItem = mainForm.bookList.FirstOrDefault(b => b.Id == ItemToEdit.mediaID)?.Title;
                }
                else
                {
                    cmbItem.SelectedItem = mainForm.miscItems.FirstOrDefault(m => m.Id == ItemToEdit.mediaID)?.Name;
                }
            }
        }

        private void cmbMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();

            // Depending on the media type, fill the second combo box with the relevant data
            if (cmbMedia.SelectedItem.ToString() == "Book")
            {
                foreach (var book in mainForm.bookList)
                {
                    cmbItem.Items.Add(book.Title);
                }
            }
            else
            {
                foreach (var miscItem in mainForm.miscItems)
                {
                    cmbItem.Items.Add(miscItem.Name);
                }
            }

        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            if (cmbMedia.SelectedItem == null)
            {
                MessageBox.Show("Please select a media type (Book or Miscellaneous).");
                return;
            }

            string selectedItem = cmbItem.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            string quoteText = rtbQuote.Text.Trim();

            if (string.IsNullOrEmpty(quoteText))
            {
                MessageBox.Show("Please enter a quote.");
                return;
            }

            int itemId = 0;

            if (cmbMedia.SelectedItem.ToString() == "Book")
            {
                Book selectedBook = mainForm.bookList.FirstOrDefault(b => b.Title == selectedItem);

                if (selectedBook != null)
                {
                    itemId = selectedBook.Id;
                }
                else
                {
                    MessageBox.Show("Selected book not found.");
                    return;
                }
            }
            else
            {
                MiscItems selectedMiscItem = mainForm.miscItems.FirstOrDefault(m => m.Name == selectedItem);
                if (selectedMiscItem != null)
                {
                    itemId = selectedMiscItem.Id;
                }
                else
                {
                    MessageBox.Show("Selected item not found.");
                    return;
                }
            }

            if (IsEditMode && ItemToEdit != null)
            {
                ItemToEdit.text = quoteText;
                ItemToEdit.mediaID = itemId;
                ItemToEdit.media = cmbMedia.SelectedItem.ToString();
            }
            else
            {
                Quotes newQuote = new Quotes(Quotes.GetNextId(), itemId, quoteText, cmbMedia.SelectedItem.ToString());
                mainForm.quoteList.Add(newQuote);
            }

            mainForm.DisplayQuotes(mainForm.quoteList);
            this.Close();
        }

        private void btnCancelQuote_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
