using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BukhryakovAY.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 1;
            while (startValue <= stopValue)
            {
                sum = sum * Math.Pow(1 / (Math.Cos(startValue) + Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            return Math.Round(sum,3);
        }
    }
}
