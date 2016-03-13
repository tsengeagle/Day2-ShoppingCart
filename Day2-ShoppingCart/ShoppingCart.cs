using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_ShoppingCart
{
    internal class ShoppingCart
    {
        private List<Order> orders = new List<Order>();
        private List<Book> products = new List<Book>();

        public ShoppingCart()
        {
        }

        public double TotalAmount { get; internal set; }

        internal void AddIn(Book book)
        {
            products.Add(book);
        }

        internal void Checkout()
        {
            CheckoutAllProducts();
            CalculateTotalAmount();
        }

        private void CalculateTotalAmount()
        {
            foreach (var orderForCheckout in orders)
            {
                //訂單中的每一本
                foreach (var item in orderForCheckout.Items)
                {
                    //確認折扣
                    switch (orderForCheckout.Items.Count)
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
            }
        }

        private void CheckoutAllProducts()
        {
            //第一本開始
            foreach (var product in products)
            {
                if (!product.Checked)
                {
                    //用訂單來整理要結帳的商品
                    Order checkoutOrder = new Order();
                    checkoutOrder.Items.Add(product);
                    product.Checked = true;

                    //從還沒結帳，且與剛剛那本書不同書名的書堆中，依照書名群組
                    var itemsGroup = products.Where(w => (!w.Checked) && (w.Name != product.Name)).GroupBy(g => g.Name);
                    //每一組
                    foreach (var items in itemsGroup)
                    {
                        //從還未結帳的書堆中抓第一筆，放進訂單，且註記結帳
                        Book checkedBook = products.Where(w => (!w.Checked) && (w.Name == items.Key)).First();
                        checkoutOrder.Items.Add(checkedBook);
                        checkedBook.Checked = true;
                    }

                    orders.Add(checkoutOrder);
                }
            }
        }
    }
}