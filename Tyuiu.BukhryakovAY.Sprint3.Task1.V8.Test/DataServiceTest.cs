using Tyuiu.BukhryakovAY.Sprint3.Task1.V8.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double value = 0.25;
            double wait = 0;
            double res = dataService.GetSumSeries(value, startValue, stopValue);
        }
    }
}
