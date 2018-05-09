using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Interfaces
{
    internal interface ICheckOutable : ILibraryItem
    {
        DateTime CheckOutDate { get; set; }
        DateTime ReturnDate { get; set; }
        string Checkout();
        //LibraryMember IssuedTo { get; set; }
    }
}
