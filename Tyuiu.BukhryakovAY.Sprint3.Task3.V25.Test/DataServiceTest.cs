using Tyuiu.BukhryakovAY.Sprint3.Task3.V25.Lib;
namespace Tyuiu.BukhryakovAY.Sprint3.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string value = "fufffuufuffuuu";
            char item = 'u';
            int wait = 1;
            int res = dataService.GetMinCharCount(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}
