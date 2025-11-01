using Tyuiu.KruchininEP.Sprint3.Task1.V4.Lib;
namespace Tyuiu.KruchininEP.Sprint3.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            var varForTest = 1.55;
            Assert.AreEqual(varForTest, ds.GetSumSeries(1, 15));
        }


    }
}