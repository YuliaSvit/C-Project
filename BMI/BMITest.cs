using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BMI
{
    [TestClass]
    public class BMITest
    {
        [TestMethod]
        public void Calculate_BMI()
        {
           
                //setup variable to calculate BMI
                string weight = "150";
                string heightInFeet = "6";
                string heightInInches = "72";
                BodyMassIndexCalculator bmi = null;
            try
            {
                //create instance of the BodyMassIndex Calculator, pass over all variables
                bmi = new BodyMassIndexCalculator
                    (int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));
            }
            catch (ArithmeticException exc)
            {
                Console.WriteLine("Arithmetic Problem - " + exc.Message);
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Number Format Problem - " + exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            /*
            CustomException ex = new CustomException("State not Part" + " of Atlantic ICW");
            throw ex;
            */

            //Optional: Argument Exception. No reference exception.
            //get result
            string result = bmi.ToString();
            //create Assertion
            Assert.AreEqual("BMI:5.09", result);
             
        }
    }
}
