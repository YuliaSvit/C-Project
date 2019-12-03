using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;


namespace ListCleaner
{
    [TestClass]
    public class ListCleaner
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");
            Console.WriteLine(dataList);

            ArrayList goodValues = CheckList(dataList);
            int sum = SumList(goodValues);
            Assert.AreEqual(147, sum);
        }

        public ArrayList CheckList(ArrayList list)
        {
            ArrayList goodVals = new ArrayList();

            foreach(var item in list)
            {
                int avalue;
                if(int.TryParse(Convert.ToString(item), out avalue)==true)
                {
                    goodVals.Add(avalue);
                }
            }
            return goodVals;
        }
        public int SumList(ArrayList list)
        {
            int sum = 0;
            foreach(int item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
