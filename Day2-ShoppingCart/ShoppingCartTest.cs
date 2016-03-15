using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2_ShoppingCart
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void PromotionTest_單買1本_按下結帳_原價_預期金額100()
        {
            //arrange
            Book poterVol1 = new Book();
            poterVol1.Name = "哈利波特第一集";
            //漏了價格
            poterVol1.Price = 100;

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);

            double expectedAmount = 100;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買了第一集到第三集各1本_按下結帳_符合3本9折_預期金額270()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);

            double expectedAmount = 270;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買第一集1本_第二集2本_第三集2本_按下結帳_符合3本9折與2本95折各1套_預期金額460()
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

            double expectedAmount = 460;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買第一集到第五集全套_按下結帳_符合5本75折_預期金額375()
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

            double expectedAmount = 375;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買第一集到第四集各1本_按下結帳_符合4本8折_預期金額320()
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

            double expectedAmount = 320;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買第一集和第二集各1本_按下結帳_符合2本95折_預期金額190()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);

            double expectedAmount = 190;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買第一集第二集第三集各1本_再買第5集2本_按下結帳_符合4本8折與1本原價_預期金額420()
        {
            //arrange
            Book poterVol1 = new Book() { Name = "哈利波特第一集", Price = 100 };
            Book poterVol2 = new Book() { Name = "哈利波特第二集", Price = 100 };
            Book poterVol3 = new Book() { Name = "哈利波特第三集", Price = 100 };
            Book poterVol5 = new Book() { Name = "哈利波特第五集", Price = 100 };
            Book anotherPoterVol5 = new Book() { Name = "哈利波特第五集", Price = 100 };

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddIn(poterVol1);
            shoppingCart.AddIn(poterVol2);
            shoppingCart.AddIn(poterVol3);
            shoppingCart.AddIn(poterVol5);
            shoppingCart.AddIn(anotherPoterVol5);

            double expectedAmount = 420;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [TestMethod]
        public void PromotionTest_買第一集與第二集各1本_再買第三集2本_按下結帳_符合3本9折及1本原價_預期金額370()
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

            double expectedAmount = 370;

            //act
            shoppingCart.Checkout();

            double actualAmount = shoppingCart.TotalAmount;

            //assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
    }
}