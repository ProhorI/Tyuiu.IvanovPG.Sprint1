using Tyuiu.IvanovPG.Sprint1.Task3.V18.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 9;
            double wait = 6;
            var res = ds.HowManySquares(x, y, z);
            Assert.AreEqual(wait, res, res );
        }
    }
}
