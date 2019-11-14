using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Employee
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        [Description("Correct Employee is returned")]
        public void Class_Employee__Set()
        {
            //arange(initiating an object)
            EmployeeClass myEmployee = new EmployeeClass( "Yulia", "Svitukha");


            //act(call methods if needed)
            string a = myEmployee.ReturnEmployee();
            string b = myEmployee.ReturnEmployeeSorted();
            
            //assert 
            //Check that correct employee is returned
           StringAssert.Equals(myEmployee.FirstName, "Yulia");
           StringAssert.Equals(a, "Yulia Svitukha");
           StringAssert.Equals(b, "Svitukha, Yulia");
        }
        [TestMethod]
        [Description("Correct job location is returned based on provided title")]
        public void JobLocationTitleTest()
        {
            //arrnge
            EmployeeClass myEmployee = new EmployeeClass(12, "Yulia Svit", "Manager");

            //act
            string jobLocation = myEmployee.JobLocation();

            //assert
            //check if correct location is returned
            StringAssert.Equals("Boston", jobLocation);
        }
        [TestMethod]
        [Description("Correct job location is returned for user without a title ")]
        public void JobLocationNoTitleTest()
        {
            //arrnge
            EmployeeClass myEmployee = new EmployeeClass(12);

            //act
            string jobLocation = myEmployee.JobLocation();

            //assert
            //check if correct location is returned
            StringAssert.Equals("New York", jobLocation);
        }

        [TestMethod]
        [Description("Correct job location is returned for user with the overwritten title ")]
        public void JobLocationOverwrittenTitleTest()
        {
            //arrnge
            EmployeeClass myEmployee = new EmployeeClass(12);
            myEmployee.JobTitle = "Staff";

            //act
            string jobLocation = myEmployee.JobLocation();

            //assert
            //check if correct location is returned
            StringAssert.Equals("Boston", jobLocation);
        }
        [TestMethod]
        public void To_String_Test()
        {
            EmployeeClass myEmployee = new EmployeeClass(123,"Yulia Svit","Manager");
            Console.WriteLine(myEmployee);
        }
    }
}
