using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AleevRI.Sprint0.Review.V0.Lib;

namespace Tyuiu.AleevRI.Sprint0.Review.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 10;
            int y = 20;
            int z = 30;

            int res = DataService.Calc(x, y, z);

            Assert.AreEqual(300, res);
               
        }
    }
}
