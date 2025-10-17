using Tyuiu.BukhryakovAY.Sprint3.Task0.V16.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int StartValue = 1;
            int StopValue = 6;
            int value = 5;
            double res = dataService.GetMultiplySeries(StartValue, StopValue, value);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
