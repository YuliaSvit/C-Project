using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Class_Employee__Set()
        {
            //arange(initiating an object)
            EmployeeClass myEmployee = new EmployeeClass( "Yulia", "Svitukha");


            //act(call methods if needed)
            string a = myEmployee.ReturnEmployee();
            string b = myEmployee.ReturnEmployeeSorted();
            
            //assert
           StringAssert.Equals(myEmployee.FirstName, "Yulia");
           StringAssert.Equals(a, "Yulia Svitukha");
           StringAssert.Equals(b, "Svitukha, Yulia");
           

        }
    }
}
