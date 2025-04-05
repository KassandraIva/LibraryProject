using LibraryProject.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.entities
{
        public class MiscItems
    {
        private static string filePath = "../../../MiscellaneousItems.txt";
        private static int counter = 1;  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator{ get; set; }
        public string Genre { get; set; }

        public MiscItems() 
        { 
            this.Id = 0;
            this.Name = "";
            this.Creator = "";
            this.Genre = "";
        }

        public MiscItems(int id,string Name, string Creator, string Genre)
        {
            this.Id = id;
            this.Name = Name;
            this.Creator = Creator;
            this.Genre = Genre;
        }

        public MiscItems(string Name, string Creator, string Genre)
        {
            this.Name = Name;
            this.Creator = Creator;
            this.Genre = Genre;
        }

        

        public static void SetCounter(int countFrom)
        {
            counter = countFrom+1;
        }

        public static int GetNextId()
        {
            return counter++;
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

                    MiscItems newItem = new MiscItems(Convert.ToInt32(columns[0]), columns[1], columns[2], columns[3]);
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

        public static void SaveToFile(MiscItems item)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string line = $"{item.Id}|{item.Name}|{item.Creator}|{item.Genre}";
                    writer.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "File Write Error");
            }
        }


    }
}
