using System;
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

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(book);

            double expectedAmount = 100;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
    }
}