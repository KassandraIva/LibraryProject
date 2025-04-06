using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.classes
{
    public class Genre
    {
        private static string filePath = "../../../genres.txt";
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Genre(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public Genre(string name, string color)
        {
            Name = name;
            Color = color;

            Id = ++counter;
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<Genre> LoadFromFile()
        {
            int maxId = 0;
            List<Genre> genres = new List<Genre>();

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');

                    if (Convert.ToInt32(columns[0]) > maxId) maxId = Convert.ToInt32(columns[0]);

                    Genre genre = new Genre(Convert.ToInt32(columns[0]), columns[1], columns[2]);
                    genres.Add(genre);
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

            return genres;
        }
    }
}
