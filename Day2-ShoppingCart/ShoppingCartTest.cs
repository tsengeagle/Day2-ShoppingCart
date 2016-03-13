using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2_ShoppingCart
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void PromotionTest_GivenBuyVol_1_For_1_ThenBuyVol_2And3_EachFor_2_ThenHitCheckout_TotalAmountShouldBe460()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book anotherPoterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };
            Book anotherPoterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);
            shoppingCart.AddIn(anotherPoterVol2);
            shoppingCart.AddIn(anotherPoterVol3);

            double expectedAmount =
                (
                    (poterVol1.Price + poterVol2.Price + poterVol3.Price) * 0.90
                )
                +
                (
                    (anotherPoterVol2.Price + anotherPoterVol3.Price) * 0.95
                )
                ;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_GivenBuyVol_1And2_EachFor_1_ThenBuyVol_3_For2_ThenHitCheckout_TotalAmountShouldBe_370()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };
            Book addPoterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);
            shoppingCart.AddIn(addPoterVol3);

            double expectedAmount =
                (
                    (poterVol1.Price + poterVol2.Price + poterVol3.Price) * 0.90
                )
                +
                (
                    addPoterVol3.Price
                )
                ;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_GivenBuyVol_1To4_EachFor_1_ThenHitCheckout_TotalAmountShouldBe_320()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };
            Book poterVol4 = new Book() { Name = "哈利波特第四集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);
            shoppingCart.AddIn(poterVol4);

            double expectedAmount = (poterVol1.Price + poterVol2.Price + poterVol3.Price + poterVol4.Price) * 0.80;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_GivenBuyVol_1To5_EachFor_1_ThenHitCheckout_TotalAmountShouldBe_375()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };
            Book poterVol4 = new Book() { Name = "哈利波特第四集", Price = 100 };
            Book poterVol5 = new Book() { Name = "哈利波特第五集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);
            shoppingCart.AddIn(poterVol4);
            shoppingCart.AddIn(poterVol5);

            double expectedAmount =
                (
                    poterVol1.Price +
                    poterVol2.Price +
                    poterVol3.Price +
                    poterVol4.Price +
                    poterVol5.Price
                ) * 0.75;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

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