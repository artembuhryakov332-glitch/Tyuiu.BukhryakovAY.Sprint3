using System.Diagnostics.Tracing;
using System.Runtime.InteropServices.Marshalling;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BukhryakovAY.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int sum = 0;
            int minSum = int.MaxValue;
            foreach (char ch in value)
            {
                if (ch == 'u')
                {
                    sum++; 
                }
                else
                {
                    if (sum > 0 && sum <= minSum)
                    {
                        minSum = sum;
                    }
                    sum = 0;
                }
            }
            return minSum;
        }
    }
}
