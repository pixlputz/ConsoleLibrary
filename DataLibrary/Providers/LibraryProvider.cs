using DataLibrary.HelperModels;
using DataLibrary.Interfaces;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Providers
{
    public class LibraryProvider
    {

        private FakeDb _db;

        //private List<Book> Books = new List<Book>();
        //private List<VideoGame> VideoGames = new List<VideoGame>();
        //private List<ILibraryItem> Items = new List<ILibraryItem>();
        //private List<ICheckOutable> ItemsForCheckout = new List<ICheckOutable>();


        public LibraryProvider()
        {
            _db = new FakeDb();
        }

        public List<string> GetLibraries()
        {
            List<string> libNames = new List<string>();
            foreach (var l in _db.Libraries)
            {
                libNames.Add(l.Name);
            }
            return libNames;
        }

        public List<ReturnLibraryItem> GetBooks(int libraryId)
        {
            return _db.Libraries[libraryId].GetBooksInfo();
        }

        public string CheckOutBook(int libraryId, string bookId)
        {
            return _db.Libraries[libraryId].CheckOutBook(bookId);
        }

    }

}
