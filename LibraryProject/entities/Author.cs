﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.classes
{
    internal class Author
    {
        //private static string filePath = Path.Combine(Directory.GetCurrentDirectory(), "authors.txt");
        private static string filePath = "../../../authors.txt";
        private static int counter = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private Author(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Id = counter++;
        }

        private static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }

        public static List<Author> LoadFromFile()
        {
            int maxId = 0;
            List<Author> authors = new List<Author>();

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

                    Author author = new Author(Convert.ToInt32(columns[0]), columns[1], columns[2]);
                    authors.Add(author);
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

            return authors;
        }
    }
}
