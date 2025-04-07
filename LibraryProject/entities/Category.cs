using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.entities;

namespace LibraryProject.classes
{
    public class Category : DataModel<Category>
    {
        public override int Id { get; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public override string DisplayName => $"{Name}";

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

        public static Category ParseFromString(string[] columns)
        {
            return new Category(Convert.ToInt32(columns[0]), columns[1], columns[2], columns[3], Convert.ToInt32(columns[4]));
        }
    }
}
