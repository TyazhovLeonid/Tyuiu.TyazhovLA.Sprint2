using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool result;
            if ((y==3 & ((x<=5 & x>=3) | x==9)) | (y == 4 & ((x <= 5 & x >= 3) | x == 9)) | (y == 5 & (x <= 9 & x >= 3)) | (y == 6 & ((x <= 9 & x >= 6) | x == 3)) | (y == 7 & ((x <= 9 & x >= 6) | x == 13)) | (y == 8 & (x <= 13 & x >= 6)) | (y == 9 & ((x <= 12 & x >= 9) | x == 6)) | (y == 10 & ((x <= 12 & x >= 9) | x == 6)) | (y == 11 & ((x <= 6 & x >= 3) | (x <= 12 & x>=9))) | (y == 12 & (x <= 12 & x >= 9)) | (y == 13 & (x <= 12 & x >= 10))) 
                { result = true; }
            else { result = false; }
            return result;
        }
    }
}
