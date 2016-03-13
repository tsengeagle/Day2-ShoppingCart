using System.Collections.Generic;

namespace Day2_ShoppingCart
{
    internal class Order
    {
        public Order()
        {
            Items = new List<Book>();
        }

        public List<Book> Items { get; internal set; }
    }
}