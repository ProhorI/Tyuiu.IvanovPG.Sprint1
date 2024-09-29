

using Tyuiu.IvanovPG.Sprint1.Task5.V2.Lib;


namespace Tyuiu.IvanovPG.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 5;
            DataService ds = new DataService();
            double res = ds.FahrenheitTo—elsius(temp);

            int result = Convert.ToInt32(res);

            int wait = -15;
            Assert.AreEqual(wait, result);
        }
    }
}


//using Tyuiu.IvanovPG.Sprint1.Task5.V2.Lib;


//namespace Tyuiu.IvanovPG.Sprint1.Task5.V2.Test
//{
//    [TestClass]
//    public class DataServiceTest
//    {
//        [TestMethod]
//        public void ValidExpression()
//        {
//            double x = 15;
//            DataService ds = new DataService();
//            double res = ds.Calculate(x);

//            int result = Convert.ToInt32(res);

//            int wait = 58;
//            Assert.AreEqual(wait, result);
//        }
//    }
//}