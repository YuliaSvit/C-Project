using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfacePractice
{
    [TestClass]
    [TestCategory ("Interface Exam")]
    public class InterfaceTest
    {
        [TestMethod]
        public void TestPage1()
        {
            IPageObject pageObject1 = new PageObject1();
            Assert.AreEqual(pageObject1.PageName, "Page Name 1");
        }
        [TestMethod]
        public void TestPage2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual(pageObject2.PageName, "Page Name 2");
        }
    }
}
