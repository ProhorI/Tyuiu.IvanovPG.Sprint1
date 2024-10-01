using Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib;

namespace Tyuiu.IvanovPG.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "Привет друзья!";
            var res = ds.CheckHello(x);
            Assert.AreEqual(res, false);
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
