 using Tyuiu.TyazhovLA.Sprint2.Task4.V5.Lib;
namespace Tyuiu.TyazhovLA.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 1;
            double wait = 17.086;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(wait,res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 11;
            double wait = 119.091;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}