using Tyuiu.TyazhovLA.Sprint2.Task0.V30.Lib;
namespace Tyuiu.TyazhovLA.Sprint2.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int x = 95; int y = 1735;
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}