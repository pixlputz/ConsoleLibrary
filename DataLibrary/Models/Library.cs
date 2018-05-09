using DataLibrary.Abstracts;
using DataLibrary.HelperModels;
using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace DataLibrary.Models
{
    internal class Library
    {

        public string Name { get; private set; }
        string Address { get; set; }

        public bool Visiting { get; private set; }
        public bool InSection { get; private set; }
        public List<Book> Books = new List<Book>();
        private List<VideoGame> VideoGames = new List<VideoGame>();
        private List<ILibraryItem> Items = new List<ILibraryItem>();
        private List<ICheckOutable> ItemsForCheckout = new List<ICheckOutable>();

        public Library(string name, string address)
        {
            Name = name;
            Address = address;
            Visiting = true;
            InSection = false;
        }

        internal string CheckOutBook(string bookId)
        {
            Book b = Books.Find(book => book.Id == bookId);
            if (b !=null)
            {
                return b.Checkout();
            }
            return "Sorry, could not find book.";
        }

        internal List<ReturnLibraryItem> GetBooksInfo()
        {
            var booksInfo = new List<ReturnLibraryItem>();
            foreach (Book b in Books)
            {
                booksInfo.Add(new ReturnLibraryItem(b.Id, b.Name));
            }
            return booksInfo;
        }

        void AssignId(ILibraryItem item)
        {
            item.Id = Guid.NewGuid().ToString();
        }
        
        internal void AddItem(ILibraryItem item)
        {
            AssignId(item);
            Items.Add(item);
        }

        internal void AddItem(Book book)
        {
            AssignId(book);
            Books.Add(book);
            AddItem((CheckoutItem)book);
        }

        internal void AddItem(VideoGame game)
        {
            AssignId(game);
            VideoGames.Add(game);
            AddItem((CheckoutItem)game);
        }

        private void AddItem(CheckoutItem item)
        {
            AssignId(item);
            ItemsForCheckout.Add(item);
        }

    }
}
