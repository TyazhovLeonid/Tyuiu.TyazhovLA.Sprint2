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
            int x = 31; int  y= 5;
            string wait = "01.06";
            string res = ds.FindDateOfNextDay(x,y);
            Assert.AreEqual(wait, res);
        }
    }
}