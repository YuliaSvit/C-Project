using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Receipt
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void ReceiptNumberPositive()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            Assert.AreEqual(1, myReceipt.ReceiptNumber);
        }

        [TestMethod]
        public void ReceiptNumberNegative()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(-1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            var a = myReceipt.ReceiptNumber;
            Assert.AreEqual(0, a);
        }
        [TestMethod]
        public void CustomerNumberPositive()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1,dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            var a = myReceipt.CustomerNumber;
            Assert.AreEqual(2, a);
        }
        [TestMethod]
        public void CustomerNumberNegative()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, -2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            var a = myReceipt.CustomerNumber;
            Assert.AreEqual(0, a);
        }
        [TestMethod]
        public void ItemNumberPositive()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            var a = myReceipt.ItemNumber;
            Assert.AreEqual(3, a);
        }
        [TestMethod]
        public void ItemNumberNegative()
        { 
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 100000, "Cofee", 4M, 5);
            var a = myReceipt.ItemNumber;
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void ItemCostPositive()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            var a = myReceipt.ItemCost;
            Assert.AreEqual(4, a);
        }
        [TestMethod]
        public void ItemCostNegative()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", -4M, 5);
            var a = myReceipt.ItemCost;
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void ItemQtyPurchasedPositive()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 5);
            var a = myReceipt.ItemQtyPurchased;
            Assert.AreEqual(5, a);
        }
        [TestMethod]
        public void ItemQtyPurchasedNegative()
        {
            var dT = DateTime.Now.Date;
            Receipt myReceipt = new Receipt(1, dT, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, -5);
            var a = myReceipt.ItemQtyPurchased;
            Assert.AreEqual(0, a);
        }

        [TestMethod]
        public void CalcMethodTest()
        {
            Receipt myReceipt= new Receipt(1, DateTime.Now.Date, 2, "Yulia Svit", "7055 N Washtenaw Ave", "3129295629", 3, "Cofee", 4M, 7);
            Console.WriteLine(myReceipt.CalcTotalCost());
            Console.WriteLine(myReceipt);
        }
    }
}
