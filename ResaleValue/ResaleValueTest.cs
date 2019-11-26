using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ResaleValue
{
    [TestClass]
    public class ResaleValueTest
    {
        [TestMethod]
        public void Display_Retail_Price()
        {
            //call the constructor
            ItemPrice itemPrice = new ItemPrice(12.99M);

            //Header rows for tabular format
            Console.WriteLine("{0,-20} {1,25}", "Item", "Percentage Increase");
            Console.Write("{0,-10}", "Price");

            //create the output in tabular format
            for (decimal percentage=0.05M;percentage<0.10M;percentage+=0.01M)
            {
                Console.Write("{0,12}", percentage);
            }

            //linebreak
            Console.WriteLine();
            Console.Write("{0,-10:C}", itemPrice.ResaleItemPrice);

            //create output in tabular format
            for (decimal percentage = 0.05M; percentage < 0.10M; percentage += 0.01M)
            {
                Console.Write("{0,10:C}", (itemPrice.ResaleItemPrice + (percentage * itemPrice.ResaleItemPrice)));
            }


        }
    }
}
