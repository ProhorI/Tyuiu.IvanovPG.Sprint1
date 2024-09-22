using Tyuiu.IvanovPG.Sprint1.Task1.V0.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 12.0;
            double y = 2.0;
            double a = 6.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(38, res, res);
          
        }
    }
}