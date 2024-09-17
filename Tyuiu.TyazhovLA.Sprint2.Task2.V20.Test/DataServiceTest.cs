using Tyuiu.TyazhovLA.Sprint2.Task2.V20.Lib;
namespace Tyuiu.TyazhovLA.Sprint2.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 13;  int y = 8;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}