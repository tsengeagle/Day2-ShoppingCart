﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2_ShoppingCart
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void PromotionTest_GivenBuyVolOneFor_1_ThenHitCheckOut_AmountShouldBe_100()
        {
            //arrange
            Book book = new Book();
            book.Name = "哈利波特第一集";
            //漏了價格
            book.Price = 100;

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(book);

            double expectedAmount = book.Price;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
    }
}