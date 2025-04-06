using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.classes
{
    public class Category
    {
        private static string filePath = "../../../categories.txt";
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public Category(int id, string name, string color, string description, int priority)
        {
            Id = id;
            Name = name;
            Color = color;
            Description = description;
            Priority = priority;
        }

        public Category(string name, string color, string description, int priority)
        {
            Name = name;
            Color = color;
            Description = description;
            Priority = priority;

            Id = ++counter;
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<Category> LoadFromFile()
        {
            int maxId = 0;
            List<Category> categories = new List<Category>();

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

                    Category category = new Category(Convert.ToInt32(columns[0]), columns[1], columns[2], columns[3], Convert.ToInt32(columns[4]));
                    categories.Add(category);
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

            return categories;
        }
    }
}
