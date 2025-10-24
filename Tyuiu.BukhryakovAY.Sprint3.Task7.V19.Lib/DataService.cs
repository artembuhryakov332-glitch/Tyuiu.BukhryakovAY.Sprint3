using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BukhryakovAY.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ArrayRange = new double [len];
            double NumFunc;
            int Index = 0;
            for (int x = startValue; x <= stopValue - 1; x++)
            {
                NumFunc = (5*x + 2.5)/(Math.Sin(x) - 2) + 2;
                ArrayRange[Index] = NumFunc;
                Index++;
            }
            return ArrayRange;
        }
    }
}
