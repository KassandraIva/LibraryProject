using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.classes
{
    public class Category
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public Category(string name, string color, string description)
        {
            Name = name;
            Color = color;
            Description = description;

            Id = counter++;
        }

        public Category(string name, string color, string description, int priority) : this(name, color, description)
        {
            Priority = priority;
            Id = counter++;
        }

        public static void SetCounter(int countFrom)
        {
            counter = countFrom;
        }
    }
}
