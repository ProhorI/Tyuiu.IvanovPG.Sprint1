using Tyuiu.IvanovPG.Sprint1.Task4.V15.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = Math.Round(1614.71517397094, 3);
            //double wait = Math.Round(1614.71517397094, 3);
            //double wait = 198241.19215326034;
            //double wait = 247069.358;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}