using LibraryProject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.entities
{
    internal class MiscItems
    {
        private static string filePath = "../../../MiscellaneousItems.txt";
        private static int counter = 0;  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator{ get; set; }
        public string Genre { get; set; }

        private MiscItems() 
        { 
            this.Id = 0;
            this.Name = "";
            this.Creator = "";
            this.Genre = "";
        }

        public MiscItems(string Name, string Creator, string Genre)
        {
            this.Id = counter++;
            this.Name = Name;
            this.Creator = Creator;
            this.Genre = Genre;
        }
        private static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<MiscItems> LoadFromFile()
        {
            int maxId = 0;
            List<MiscItems> miscItems = new List<MiscItems>();

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

                    MiscItems newItem = new MiscItems(columns[1], columns[2], columns[3]);
                    miscItems.Add(newItem);
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

            return miscItems;
        }
    }
}
