using Tyuiu.BukhryakovAY.Sprint3.Task5.V13.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int x = 5;
            int Start1 = 1;
            int Stop1 = 3;
            int Start2 = 1;
            int Stop2 = 12;
            double wait = 118.212;
            double res = dataService.GetSumSumSeries(x, Start1, Start2, Stop1, Stop2);
            Assert.AreEqual(wait, res);
        }
    }
}
