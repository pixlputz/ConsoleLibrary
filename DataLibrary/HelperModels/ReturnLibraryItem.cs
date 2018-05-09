using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.HelperModels
{
    public class ReturnLibraryItem : ILibraryItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ReturnLibraryItem(string id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
