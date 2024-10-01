using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanovPG.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            //return Math.Round(((Math.PI * Math.Pow(r, 3) * 4 / 3)), 3);
            return Math.Round((4.0 / 3 * Math.PI * Math.Pow(r, 3)), 3);
        }
    }
}
