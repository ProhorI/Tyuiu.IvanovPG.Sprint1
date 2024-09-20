using Tyuiu.IvanovPG.Sprint1.Task0.V16.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-7, res);

        }
    }
}