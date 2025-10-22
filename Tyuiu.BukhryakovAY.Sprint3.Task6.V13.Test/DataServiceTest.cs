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
            int Start1 = 8;
            int Stop1 = 17;
            int wait = 117;
            int res = dataService.GetSumTheDivisors(Start1, Stop1);
            Assert.AreEqual(wait, res);
        }
    }
}

