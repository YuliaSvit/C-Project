using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathFunctions
{
    [TestClass]
    public class MathFunctionsTest
    {
        [TestMethod]
        public void Test_Square_Root()
        {
            //double d = MathFunctions.SquareRoot(4);
            //Assert.AreEqual(2, d);  
            Assert.AreEqual(2, MathFunctions.SquareRoot(4));
        }

        [TestMethod]
        public void Test_Int_Sum()
        {
            Assert.AreEqual(70, MathFunctions.Sum(35, 35));
        }

        [TestMethod]
        public void Test_Double_Sum()
        {
            Assert.AreEqual(19.1, MathFunctions.Sum(12.5, 6.6));
        }

        [TestMethod]
        public void Test_Decimal_Sum()
        {
            Assert.AreEqual(24M, MathFunctions.Sum(12M, 12M));
        }
    }
}
