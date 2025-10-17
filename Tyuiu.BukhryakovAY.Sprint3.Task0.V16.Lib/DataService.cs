using System.Runtime.Serialization.Formatters;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BukhryakovAY.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            int i;
            for (i = startValue; i < stopValue; i++)
            {
                res *= (value / i);
            }
            return res;
        }
    }
}
