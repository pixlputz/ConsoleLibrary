using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    internal class Magazine : ILibraryItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Issue { get; set; }

        public Magazine(string name, int issue)
        {
            Name = name;
            Issue = issue;
        }
    }
}
