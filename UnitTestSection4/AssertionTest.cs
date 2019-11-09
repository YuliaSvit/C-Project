using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Exercises
{
    [TestClass]
    [TestCategory("Quiz")]
    public class AssertionTest
    {
        private int a;
        public TestContext Test3Context { get; set; }
        public static TestContext _testContext;
        [TestInitialize]
        //will be executed before each test method
        public void RunBeforeEveryTest()
        {
            a = 1;
        }
        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("This method will be executed after every single test method in class");
        }

        [ClassInitialize]
        public static void RunBeforeAllOfTheTestMethodsStarted(TestContext testContext)
        {
            _testContext = testContext;
            Trace.Write("I will run one time before all the tests int he class started");
        }
        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.Write("I will run one time after all the tests in the class finished");
        }
        [TestMethod]
        //This method checks if 1 +1 = 2
        public void TestMethod1()
        {
            var b = 1;
            Assert.AreEqual(2, a + b);
        }
        [TestMethod]
        //This test will always fail
        public void TestMethod2()
        {
            //Assert.Fail("This test will always fail");
        }

        [TestMethod]
        //Checks if 10+10 =21 and expects the test to fail. But test should be marked itself as pass(expected exception)
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
        [TestMethod]
        //Checks if value is not equal
        public void TestMethod4()
        {
            Assert.AreNotEqual(2, a);
        }
        [TestMethod]
        //Checks if value is true
        public void TestMethod5()
        {
          
            Assert.IsTrue(a==1);
        }
    }
}
