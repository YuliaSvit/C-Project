using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions
{
   public  class MathFunctions
    {
        public static  double SquareRoot(double num)
        {
            double sqrtNum = Math.Sqrt(num);
            return sqrtNum;
        }

        public static int  Sum (int num1, int num2)
        {
            return  num1 + num2;
        }
        //Method overloading
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        //Method overloading
        public static decimal Sum (decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
 