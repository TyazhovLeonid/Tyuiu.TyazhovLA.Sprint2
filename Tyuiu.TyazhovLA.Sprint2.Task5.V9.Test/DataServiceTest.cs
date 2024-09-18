using Tyuiu.TyazhovLA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.TyazhovLA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5; int  y= 31;
            string wait = "Èþíü 1";
            string res = ds.FindDateOfNextDay(x,y);
            Assert.AreEqual(wait, res);
        }
    }
}