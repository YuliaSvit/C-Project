using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExceptionsExamHelper
{
    [TestClass]
    public class ExamHelperTest
    {
        [TestMethod]
        public void Test_weekly_wages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch(IndexOutOfRangeException exc)
            {
                Console.WriteLine("\n\nError in the loop termination condition.");
                Console.WriteLine("\nException type:\t" +exc.Message + "\n\n\n");
            }
        }
        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Number Format Problem - " + exc.Message);
            }
        }
        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch(ArithmeticException exc)
            {
                Console.WriteLine("Arithmetic Problem" + exc.Message);
            }

        }
    }
}
