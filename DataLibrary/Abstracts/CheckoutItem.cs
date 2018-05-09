using DataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Abstracts
{
    internal abstract class CheckoutItem : ICheckOutable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        //add available and set it

        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public string Checkout()
        {
            CheckOutDate = DateTime.Now;
            ReturnDate = DateTime.Now.AddDays(7);
            return $"You have checked out {Name}, on {CheckOutDate}, it is due {ReturnDate}";
        }
    }
}
