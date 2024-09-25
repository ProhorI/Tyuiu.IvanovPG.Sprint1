using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanovPG.Sprint1.Task2.V0.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            return (4/3) * 3.14 * (r * r * r);
        }
    }
}
