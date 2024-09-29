

using Tyuiu.IvanovPG.Sprint1.Task7.V6.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -190.438;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
