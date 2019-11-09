using System;
using System.Collections.Generic;
using System.Text;
using LeapYearCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises
{
    [TestClass]
    [TestCategory("Quiz")]
    public class LeapYear
    {
        //Run unit test method  times with multiple parametrs.
        [DataTestMethod]
        [DataRow(2000, "Yes")]
        [DataRow(1999,  "No")]
        [DataRow(2004,  "No")]
        
        public void EnterYear_Unit(int enteredYear, string isLeapYear)
        {
            var leapYear=Program.EnterYear(enteredYear);         
            Assert.AreEqual(isLeapYear, leapYear);
            }

        //}//Run unit test method  times with multiple parametrs.
        //[DataTestMethod]
        //[DataRow(2000, "Yes", "Yes", "Yes", "Yes")]
        //[DataRow(1999, "No", "No", "No", "No")]
        //[DataRow(2004, "Yes", "No", "No", "No")]
        
        //public void EnterYear_Unit(int enteredYear,string div4expected, string div100expected, string div400expected, string isLeapYear)
        //{
        //    Program.EnterYear();
        //    var  
        //        Assert.AreEqual(div4expected, div4);
        //        Assert.AreEqual(div100expected, div100);
        //        Assert.AreEqual(div400expected, div400);
         //        Assert.AreEqual(isLeapYear, leapYear);
        //    }

        //}

    }
}
