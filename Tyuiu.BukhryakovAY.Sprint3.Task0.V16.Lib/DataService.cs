using System.Runtime.Serialization.Formatters;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BukhryakovAY.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                res = res * Math.Pow((double) value / i,3);
            }
            return Math.Round(res, 3);
        }
    }
}
