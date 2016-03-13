using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2_ShoppingCart
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void PromotionTest_GivenBuyVolOneFor_1_ThenBuyVolTwoFor_1_ThenHitCheckOut_TotalAmountShouldBe190()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);

            double expectedAmount = (poterVol1.Price + poterVol2.Price) * 0.95;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_GivenBuyVolOneFor_1_ThenHitCheckOut_TotalAmountShouldBe_100()
        {
            //arrange
            Book poterVol1 = new Book();
            poterVol1.Name = "哈利波特第一集";
            //漏了價格
            poterVol1.Price = 100;

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);

            double expectedAmount = poterVol1.Price;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_GivenBuyVolOneToVolThreeEachFor_1_ThenHitCheckout_TotalAmountShouldBe_270()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);

            double expectedAmount = (poterVol1.Price + poterVol2.Price + poterVol3.Price) * 0.90;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
    }
}