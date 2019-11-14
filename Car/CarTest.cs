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
        [TestMethod]
        public void CallMainAccelarationMethod()
            {
        //arange(initiating an object)
        Car myCar = new Car("red", 3, true);

        //act(call methods if needed)
        myCar.Accelarate();
            }

        [TestMethod]
        public void CallFamilyCarMethod()
        {
            Car myCar = new Car("red", 4, true);
            bool carType=myCar.FamilyCar();
            if(carType==true)
            {
                Assert.IsTrue(carType == true);
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}

