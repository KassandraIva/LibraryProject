using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.entities;

namespace LibraryProject.classes
{
    public class Genre : DataModel<Genre>
    {
        public override int Id { get; }
        public string Name { get; set; }
        public string Color { get; set; }
        public override string DisplayName => $"{Name}";

        public Genre(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public Genre(string name, string color)
        {
            Name = name;
            Color = color;

            Id = ++counter;
        }

        public static Genre ParseFromString(string[] columns)
        {
            return new Genre(Convert.ToInt32(columns[0]), columns[1], columns[2]);
        }
    }
}
