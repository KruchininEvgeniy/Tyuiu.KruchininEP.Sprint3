﻿using Tyuiu.KruchininEP.Sprint3.Task4.V29.Lib;
namespace Tyuiu.KruchininEP.Sprint3.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(res, wait);
        }
    }
}