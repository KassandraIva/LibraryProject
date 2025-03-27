using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.classes
{
    internal class Genre
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        
        public Genre(string name, string color)
        {
            Name = name;
            Color = color;

            Id = counter++;
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }
    }
}
