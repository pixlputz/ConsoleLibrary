using System;
using DataLibrary.Abstracts;
using DataLibrary.Interfaces;

namespace DataLibrary.Models
{
    internal class VideoGame : CheckoutItem
    {
        public string Platform { get; set; }
        
        public new void Checkout()
        {
            base.Checkout();
            ReturnDate = DateTime.Now.AddDays(5);
        }
    }
}