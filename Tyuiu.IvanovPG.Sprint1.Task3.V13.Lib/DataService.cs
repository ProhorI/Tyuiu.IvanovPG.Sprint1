using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvanovPG.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            string numberStr = number.ToString();
            int n1 = int.Parse(numberStr[0].ToString()); // Первая цифра
            int n2 = int.Parse(numberStr[1].ToString()); // Вторая цифра
            int n3 = int.Parse(numberStr[2].ToString()); // Третья цифра

            int p = n1 * n2 * n3;
            return p;
        }
    }
}


//public double MultiplyOfDigits(double number)
//{
//    return number