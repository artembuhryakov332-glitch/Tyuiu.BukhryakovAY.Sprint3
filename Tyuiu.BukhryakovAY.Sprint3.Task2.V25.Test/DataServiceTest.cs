using Tyuiu.BukhryakovAY.Sprint3.Task2.V25;
using Tyuiu.BukhryakovAY.Sprint3.Task2.V25.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int value = 5;
            int startValue = 1;            
            int stopValue = 13;
            double wait = 0;
            double res = dataService.GetSumSeries(value, startValue, stopValue);
        }
    }
}
