using LibraryProject.classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.entities
{
    public class Quotes
    {
        private static string filePath = "../../../Quotes.txt";
        private static int counter = 1;

        public int id { get; set; }
        public int mediaID { get; set; }
        public string text { get; set; }
        public string media { get; set; }

        public Quotes()
        {
            this.id = 0;
            this.mediaID = 0;
            this.text = "";
            this.media = "";
        }

        public Quotes(int id, int mediaID, string text, string media)
        {
            this.id = id;
            this.mediaID = mediaID;
            this.text = text;
            this.media = media;
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom + 1;
        }
        public static int GetNextId()
        {
            return counter++;
        }

        public static List<Quotes> LoadFromFile()
        {
            int maxId = 0;
            List<Quotes> quotes = new List<Quotes>();

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');

                    Quotes newQuote = new Quotes
                    {
                        id = Convert.ToInt32(columns[0]),
                        mediaID = Convert.ToInt32(columns[1]),
                        text = columns[2],
                        media = columns[3]
                    };

                    quotes.Add(newQuote);

                    // Track the maximum ID found
                    if (newQuote.id > maxId)
                    {
                        maxId = newQuote.id;
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

            // Set the counter to the max ID found in the file
            SetCounter(maxId);

            return quotes;
        }
    }
}
