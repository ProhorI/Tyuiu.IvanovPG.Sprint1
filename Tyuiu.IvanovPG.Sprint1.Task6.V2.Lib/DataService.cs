using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            return value.Contains("Hello");
        }
    }
}


//using tyuiu.cources.programming.interfaces.Sprint1;

//namespace Tyuiu.IvanovPG.Sprint1.Task6.V2.Lib
//{
//    public class DataService : ISprint1Task6V2
//    {
//        public string WorkWithText(string value)
//        {
//            value = value.Replace(" ", "");
//            value = value.Replace("*", "");
//            return value;
//        }

//    }
//}
