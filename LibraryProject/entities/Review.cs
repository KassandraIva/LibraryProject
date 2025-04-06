using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LibraryProject.classes;

namespace LibraryProject.entities
{
    public class Review
    {
        private static string filePath = "../../../Review.txt";
        private static int counter = 0;
        public int reviewId { get; set; }
        public int mediaId { get; set; }
        public string Text { get; private set; }
        public int Rating { get; private set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Review(int ReviewId, int MediaId, string text, int rating, DateTime createdAt)
        {
            this.reviewId = ReviewId;
            this.mediaId = MediaId;
            this.Text = text;
            this.Rating = rating;
            this.CreatedAt = createdAt;

        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom + 1;
        }
        public static int GetNextId()
        {
            return counter++;
        }

        public static List<Review> LoadFromFile()
        {
            int maxId = 0;
            List<Review> reviews = new List<Review>();

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');

                    Review newReview = new Review
                    (
                        Convert.ToInt32(columns[0]),
                        Convert.ToInt32(columns[1]),
                        columns[2],
                        Convert.ToInt32(columns[3]),
                        Convert.ToDateTime(columns[4])
                    );


                    reviews.Add(newReview);

                    if (newReview.reviewId > maxId)
                    {
                        maxId = newReview.reviewId;
                    }
                }

                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            SetCounter(maxId);

            return reviews;
        }


    }
}
