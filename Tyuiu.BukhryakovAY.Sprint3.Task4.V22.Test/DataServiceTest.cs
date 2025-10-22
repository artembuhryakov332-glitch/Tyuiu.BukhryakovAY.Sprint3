using Tyuiu.BukhryakovAY.Sprint3.Task4.V22.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int Start = -5;
            int Stop = 5;
            double wait = 73.346;
            double res = dataService.Calculate(Start, Stop);
            Assert.AreEqual(wait, res);
        }
    }
}
