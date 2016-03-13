using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_ShoppingCart
{
    internal class ShoppingCart
    {
        private List<Book> _cartItems = new List<Book>();
        private List<Book> _readyForCheckout = new List<Book>();

        public ShoppingCart()
        {
        }

        public double TotalAmount { get; internal set; }

        internal void AddIn(Book book)
        {
            _cartItems.Add(book);
        }

        internal void Checkout()
        {
            //書籍按書名排序
            _cartItems.OrderBy(o => o.Name);

            //第一本開始
            foreach (var firstCheck in _cartItems)
            {
                if (!firstCheck.Checked)
                {
                    //先拿到一邊，註記結帳
                    _readyForCheckout.Add(firstCheck);
                    firstCheck.Checked = true;

                    //從還沒結帳，且與剛剛那本書不同書名的書堆中，依照書名群組
                    var itemsGroup = _cartItems.Where(w => (!w.Checked) && (w.Name != firstCheck.Name)).GroupBy(g => g.Name);
                    //每一組
                    foreach (var items in itemsGroup)
                    {
                        //從還未結帳的書堆中抓第一筆，放進待結帳區，且註記結帳
                        Book checkedBook = _cartItems.Where(w => (!w.Checked) && (w.Name == items.Key)).First();
                        _readyForCheckout.Add(checkedBook);
                        checkedBook.Checked = true;
                    }
                    CalculateTotalAmount();
                }
            }
        }

        private void CalculateTotalAmount()
        {
            //放旁邊的每一本
            foreach (var item in _readyForCheckout)
            {
                //看總共有幾本
                switch (_readyForCheckout.Count)
                {
                    //只有一本，原價
                    case 1:
                        TotalAmount += item.Price;
                        break;

                    //兩本，95折
                    case 2:
                        TotalAmount += item.Price * 0.95;
                        break;

                    //兩本，95折
                    case 3:
                        TotalAmount += item.Price * 0.90;
                        break;

                    //兩本，95折
                    case 4:
                        TotalAmount += item.Price * 0.80;
                        break;

                    //兩本，95折
                    case 5:
                        TotalAmount += item.Price * 0.75;
                        break;

                    default:
                        break;
                }
            }
            _readyForCheckout.Clear();
        }
    }
}