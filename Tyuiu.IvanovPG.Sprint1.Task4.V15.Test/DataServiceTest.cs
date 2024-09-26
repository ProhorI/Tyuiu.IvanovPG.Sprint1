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
            double x = 3;
            double y = 3;
            //double wait = Math.Round(2017144, 3);
            double wait = Math.Round(2017.143967463675, 3);
            //double wait = 198241.19215326034;
            //double wait = 2017.144;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}