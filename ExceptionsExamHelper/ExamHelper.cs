﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExamHelper
{
    static class ExamHelper
    {
        public static void WeeklyWages()
        {
            double[] weeklyWages = { 3, 4, 5 };
            Console.WriteLine("Values being displayed from array");
            for (int i=1;i<=4; i++)
            {
                Console.WriteLine("\n\t" + weeklyWages[i]);
            }
        }

        public static void CalculateResult()
        {
            int calcResult;
            for (int i=1;i<=4; i++)
            {
                calcResult = 3 * int.Parse("a");
            }
        }

        public static void NumberCheck()
        {
            int calcResult;
            int input = 0;
            calcResult = (input / (input - input));
            Console.WriteLine(calcResult.ToString());
        }
    }
}
