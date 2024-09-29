using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.IvanovPG.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double res = (temp -  32) * 5 / 9;
            return (int)res;
        }
    }
}

//namespace Tyuiu.IvanovPG.Sprint1.Task5.V2.Lib
//{
//    public class DataService : ISprint1Task5V2
//    {
//        public double Calculate(double x)
//        {
//            double res = Math.Pow(x, 2) / Math.Sqrt(x);
//            return res;
//        }

//    }
//}
