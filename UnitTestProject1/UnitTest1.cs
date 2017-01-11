using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BASE.DataModel;
using System.Collections.Generic;
using BASE;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, 1, 11, 21));
            products.Add(new Product(2, 2, 12, 22));
            products.Add(new Product(3, 3, 13, 23));
            products.Add(new Product(4, 4, 14, 24));
            products.Add(new Product(5, 5, 15, 25));
            products.Add(new Product(6, 6, 16, 26));
            products.Add(new Product(7, 7, 17, 27));
            products.Add(new Product(8, 8, 18, 28));
            products.Add(new Product(9, 9, 19, 29));
            products.Add(new Product(10, 10, 20, 30));
            products.Add(new Product(11, 11, 21, 31));

            return products;
        }
        [TestMethod]
        [TestCategory("ok")]
        public void Test_Group_Cost_4_ShouldBe_6_15_24_21()
        {
            //arrange
            //建立假資料
            List<DataModel.Product> products = GetProducts();
            Calculator target = new Calculator(products);

            //act
            var actual = target.Sum("cost", 4);
            var expected = new int[] { 6, 15, 24, 21 };

            //assert
            CollectionAssert.AreEqual(expected, actual.ToArray());
        }

        [TestMethod]
        [TestCategory("ok")]
        public void Test_Group_Revenue_3_ShouldBe_50_66_60()
        {
            //arrange
            //建立假資料
            List<DataModel.Product> products = GetProducts();
            Calculator target = new Calculator(products);

            //act
            var actual = target.Sum("revenue", 3);
            var expected = new int[] { 50, 66, 60 };

            //assert
            CollectionAssert.AreEqual(expected, actual.ToArray());
        }

        [TestMethod]
        [TestCategory("error")]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_colName_Error()
        {
            //arrange
            List<DataModel.Product> products = GetProducts();
            Calculator target = new Calculator(products);
            //act
            var actual = target.Sum("error", 3);
            //assert
        }
        [TestMethod]
        [TestCategory("error")]
        [ExpectedException(typeof(OverflowException))]
        public void Test_groupNum_Small_Than_0_Should_Error()
        {
            //arrange
            List<DataModel.Product> products = GetProducts();
            Calculator target = new Calculator(products);
            //act
            var actual = target.Sum("revenue", -999);
            //assert
        }
    }
}
