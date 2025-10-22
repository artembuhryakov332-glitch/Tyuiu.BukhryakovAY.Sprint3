using Tyuiu.BukhryakovAY.Sprint3.Task6.V13.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int Start = 8;
            int Stop = 17;
            double wait = 117;
            double res = dataService.GetSumTheDivisors(Start, Stop);
            Assert.AreEqual(wait, res);
        }
    }
}
