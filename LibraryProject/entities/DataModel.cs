using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.classes;

namespace LibraryProject.entities
{
    public abstract class DataModel<T> where T : DataModel<T>
    {
        protected static int counter = 0;
        protected static string filePath => Path.Combine("../../../data", $"{typeof(T).Name.ToLower()}List.txt");

        public abstract int Id { get; }
        public abstract string DisplayName { get; }

        protected static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<T> LoadFromFile(Func<string[], List<Author>, List<Category>, List<Genre>, T> parser, List<Author> authors, List<Category> categories, List<Genre> genres)
        {
            int maxId = 0;
            List<T> list = new List<T>();

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

                    list.Add(parser(columns, authors, categories, genres));
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

            return list;
        }

        public static List<T> LoadFromFile(Func<string[],T> parser)
        {
            int maxId = 0;
            List<T> list = new List<T>();

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

                    list.Add(parser(columns));
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

            return list;
        }
    }
}
