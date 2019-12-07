using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsEg
{
    static class ExceptionHelper
    {
        public static void DivisionTest()
        {
            try
            {
                int totalScores = 10;
                int countOfScores = 0;

                double average = totalScores / countOfScores;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally//it is optional. Will be executed no matter what.
            {
                Console.WriteLine("Divisioen Operation");
            }
            
        }
    }
}
