using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryProject.entities
{
    public class BookLists
    {
        private static string filePath = "../../../BookLists.txt";
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> BookIds { get; set; }

        public BookLists(int id, string name, List<int> bookIds)
        {
            Id = id;
            Name = name;
            BookIds = bookIds ?? new List<int>();
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom + 1;
        }
        public static int GetNextId()
        {
            return counter++;
        }

        public static List<BookLists> LoadFromFile()
        {
            int maxId = 0;
            List<BookLists> bookLists = new List<BookLists>();

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');

                    int id = Convert.ToInt32(columns[0]);
                    string name = columns[1];
                    List<int> bookIds = new List<int>();

                    if (columns.Length > 2 && !string.IsNullOrWhiteSpace(columns[2]))
                    {
                        bookIds = columns[2]
                            .Split(',')
                            .Select(idStr => int.Parse(idStr))
                            .ToList();
                    }

                    BookLists newBookList = new BookLists(id, name, bookIds);

                    bookLists.Add(newBookList);

                    if (id > maxId)
                    {
                        maxId = id;
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

            return bookLists;
        }
    }
}
