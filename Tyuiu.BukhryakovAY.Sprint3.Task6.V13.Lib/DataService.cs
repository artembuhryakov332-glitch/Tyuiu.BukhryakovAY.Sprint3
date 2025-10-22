using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BukhryakovAY.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0 && k > 8)
                    {
                        sum += k;
                    }
                }
            }
            return sum;
        }
    }
}
