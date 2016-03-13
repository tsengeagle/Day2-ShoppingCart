using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_ShoppingCart
{
    internal class ShoppingCart
    {
        private List<Book> _cartItems;

        public ShoppingCart()
        {
            _cartItems = new List<Book>();
        }

        public double TotalAmount { get; internal set; }

        internal void AddIn(Book book)
        {
            _cartItems.Add(book);
        }

        internal void Checkout()
        {
            TotalAmount = _cartItems.Sum(s => s.Price);
        }
    }
}