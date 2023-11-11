using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint4.Task7.V10.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "695847142536";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
