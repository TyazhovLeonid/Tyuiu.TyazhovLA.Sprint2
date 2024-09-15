using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task0.V30.Lib
{
    public class DataService : ISprint2Task0V30
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x+1640==y; 
            result[1] = x+1640!=y;
            result[2] = x < y;  
            result[3] = x > y;
            result[4] = x <= y;
            result[5] = x >= y;
            return result;
        }
    }
}
