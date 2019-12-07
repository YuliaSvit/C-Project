using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Loan_Program
{
    [TestClass]
    public class Loan_Test
    {
        [TestMethod]
        public void HomeLoanTest()
        {
            HomeLoan myHomeLoan = new HomeLoan("Home Loan",1,"Yulia","Svit",0.035,210000,30,"7055 North",1999,"18 sq foot");
            Assert.AreEqual(3010, myHomeLoan.CalculateInterest());
            Console.WriteLine(myHomeLoan);
        }
        [TestMethod]
        public void AutoLoanTest()
        {
            AutoLoan myAutoLoan = new AutoLoan("Auto Loan", 1, "Yulia", "Svit", 0.075, 12000, 4,1966,"Infinity","2017","black");
            Assert.AreEqual(2925, myAutoLoan.CalculateInterest());
            Console.WriteLine(myAutoLoan);
        }
    }
}
