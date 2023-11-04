using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint4.Task2.V7.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint4.Task2.V7.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 7, 7, 8, 8, 4, 6, 4, 5, 9, 7, 5, 6 };
            int res = ds.Calculate(array);
            int wait = 36;

            Assert.AreEqual(wait, res);
        }
    }
}
