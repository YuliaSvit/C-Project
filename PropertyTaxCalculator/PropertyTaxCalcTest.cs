using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PropertyTaxCalculator
{
    [TestClass]
    public class PropertyTaxCalcTest
    {
        [TestMethod]
        public void Test_Calc_Taxable_Value()
        {
            PropertyTaxCalculator home1 = new PropertyTaxCalculator("7055 N Wash street", 110000, 115000);
            Assert.AreEqual(90000, home1.CalculateTaxableValue());
        }

        [TestMethod]
        public void Test_Calc_New_Assessed_Value()
        {
            PropertyTaxCalculator home1 = new PropertyTaxCalculator("7055 N Wash street", 110000, 115000);
            Assert.AreEqual(112970, home1.CalculateNewAssessedValue());
        }
        [TestMethod]
        public void Test_Class_Output()
        {
            PropertyTaxCalculator home1 = new PropertyTaxCalculator("7055 N Wash street", 110000, 115000);
            Console.WriteLine(home1);
            Console.WriteLine();
            PropertyTaxCalculator home2 = new PropertyTaxCalculator("7055 N Wells street", 150000, 160000);
            Console.WriteLine(home2);
            Console.WriteLine();
            PropertyTaxCalculator home3 = new PropertyTaxCalculator("7055 N Estes street", 190000, 200000);
            Console.WriteLine(home3);

        }
    }
}
