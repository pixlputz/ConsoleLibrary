using DataLibrary.Abstracts;
using DataLibrary.Interfaces;
using System;

namespace DataLibrary.Models
{
    internal class Book : CheckoutItem
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        
        public Book(string name, string iSBN, string author)
        {
            Name = name;
            ISBN = iSBN;
            Author = author;
        }
    }
}