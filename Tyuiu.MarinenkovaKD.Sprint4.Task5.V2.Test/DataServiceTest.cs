using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint4.Task5.V2.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 3, -7, 3, 1, 5, },
                                          { -6, 3, 2, 1, 2, },
                                          { 1, 3, 2, -3, 1, },
                                          { 5, -1, 1, 5, 1, },
                                          { 3, 3, 4, 4, -6, } };
            int res = ds.Calculate(mas2);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}
