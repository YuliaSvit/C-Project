using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arange(initiating an object)
            Car myCar = new Car("red", 3, true);


            //act(call methods if needed)

            //assert
            StringAssert.Equals(myCar.Color, "red");

        }
    }
}

