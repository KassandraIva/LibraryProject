using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.classes;

namespace LibraryProject.entities
{
    public class Review
    {
        public string Text { get; private set; }
        public int Rating { get; private set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Review(string text, int rating)
        {
            Text = text;
            Rating = rating;
        }
    }
}
