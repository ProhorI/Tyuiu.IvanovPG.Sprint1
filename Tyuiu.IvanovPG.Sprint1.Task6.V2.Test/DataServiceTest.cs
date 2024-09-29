using Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, World";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            string wait = "World";
            Assert.AreEqual(res, wait);

        }
    }
}

//using Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib;

//namespace Tyuiu.IvanovPG.Sprint1.Task6.V.Test
//{
//    [TestClass]
//    public class DataServiceTest
//    {
//        [TestMethod]
//        public void ValidString()
//        {
//            string strTest = "1 * 2 * 3";
//            DataService ds = new DataService();
//            string res = ds.WorkWithText(strTest);
//            string wait = "123";
//            Assert.AreEqual(res, wait);

//        }
//    }
//}
