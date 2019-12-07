using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExceptionsEg
{
    [TestClass]
    public class ExceptionTest
    {
        /*[TestMethod]
        public void Test_Exceptions()
        {
            int totalScores = 10;
            int countOfScores = 0;
            if (countOfScores == 0 || totalScores == 0)
            {
            }
            else
            {
                double average = totalScores / countOfScores;
            }
        }
        */
        [TestMethod]
        public void Test_Division()
        {
            try
            {
                ExceptionHelper.DivisionTest();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
