using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanovPG.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return 4 / 3 * Math.PI * Math.Pow(6, 3);
        }
    }
}

//using tyuiu.cources.programming.interfaces.Sprint1;

//namespace Tyuiu.IvanovPG.Sprint1.Task2.V0.Lib
//{
//    public class DataService : ISprint1Task2V0
//    {
//        public int Sqr(int value)
//        {
//            return value * value;
//        }
//    }
//}

//return Math.Round(4 /3 * Math.PI * Math.Pow(r, 3), 3);