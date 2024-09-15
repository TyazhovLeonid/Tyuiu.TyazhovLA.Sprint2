using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a==b) | (c>d);
            result[1] = (a!=c) & (b<=d);
            result[2] = (a<d) || (b<c);
            result[3] = (b>=c) && (c<d);
            result[4] = !(a!=b);
            result[5] = (a!=d) ^ (b<c);
            return result;
        }
    }
}
