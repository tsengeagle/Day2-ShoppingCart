using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_ShoppingCart
{
    internal class ShoppingCart
    {
        private List<Book> _cartItems = new List<Book>();
        private List<Book> _checkedItems = new List<Book>();
        private List<Book> _tempItems = new List<Book>();

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
                //先拿到一邊
                _tempItems.Add(firstCheck);
                _cartItems.Remove(firstCheck);
                //再掃剩下的
                foreach (var thenCheck in _cartItems)
                {
                    //如果兩本不一樣
                    if (firstCheck.Name != thenCheck.Name)
                    {
                        //第二本也放一邊
                        _tempItems.Add(thenCheck);
                        _cartItems.Remove(thenCheck);
                        break;
                    }
                }
                //放旁邊的每一本
                foreach (var item in _tempItems)
                {
                    //看總共有幾本
                    switch (_tempItems.Count)
                    {
                        //只有一本，原價
                        case 1:
                            TotalAmount += item.Price;
                            break;

                        //兩本，95折
                        case 2:
                            TotalAmount += item.Price * 0.95;
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}