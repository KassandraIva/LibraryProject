using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.entities;

namespace LibraryProject.classes
{
    public class Author : DataModel<Author>
    {
        public override int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string DisplayName => $"{FirstName} {LastName}";

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

        public static Author ParseFromString(string[] columns)
        {
            return new Author(Convert.ToInt32(columns[0]), columns[1], columns[2]);
        }
    }
}
