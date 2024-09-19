 using Tyuiu.TyazhovLA.Sprint2.Task6.V3.Lib;
namespace Tyuiu.TyazhovLA.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 2;
            string wait = "Вторник";
            string res = ds.FindDayName(a);
            Assert.AreEqual(wait, res);
        }
    }
}