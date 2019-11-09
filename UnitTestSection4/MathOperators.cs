using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises
{
    [TestClass]
    [TestCategory("Quiz")]
    public class MathOperators
    {      
        [TestMethod]
        public void Convert_F_To_C()
        {
            double tempF = 37;
            /*given the temperature in F use a math expression
           to convert the temperature to C*/
            double tempC = (tempF-32)*.5556;
            /*display output string to the console that says 
            the temp in F {given temp} is {temp} in C}*/
            Console.WriteLine($"The temperature in F {tempF} is {tempC} in C");
            //check the work(0.001-tolerance)
            Assert.AreEqual(tempC,2.778, 0.001);
        }
        [TestMethod]
        public void Convert_C_To_F()
        {
            double tempC = 37;
            /*given the temperature in C use a math expression
           to convert the temperature to F*/
            double tempF = tempC*1.8 +32;
            /*display output string to the console that says 
            the temp in C {given temp} is {temp} in F}*/
            Console.WriteLine($"The temperature in C {tempC} is {tempF} in F");
            //check the work(0.001 -tolerance point)
            Assert.AreEqual(tempF, 98.6,0.001);
        }
       
    }
}
