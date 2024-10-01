using Tyuiu.IvanovPG.Sprint1.Task2.V9.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new();
            Assert.AreEqual(dataService.CalculateVolumeCircle(12), 7234.56);

        }
    }
}