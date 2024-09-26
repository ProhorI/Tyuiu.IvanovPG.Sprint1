using Tyuiu.IvanovPG.Sprint1.Task2.V9.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 6;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(678.584, res);

        }
    }
}