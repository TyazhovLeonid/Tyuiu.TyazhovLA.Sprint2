using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TyazhovLA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res;
            m += 1;
            if (m==32) 
            { m=1;n += 1; }
            res = m.ToString("D2")+".";
            switch (n) 
            {
            case 1:
                    res += "01";
                    break;
            case 2:
                    res += "02";
                    break;
            case 3:
                    res += "03";
                    break;
            case 4:
                    res += "04";
                    break;
            case 5:
                    res += "05";
                    break;
            case 6:
                    res += "06";
                    break;
            case 7:
                    res += "07";
                    break;
            case 8:
                    res += "08";
                    break;
            case 9:
                    res += "09";
                    break;
            case 10:
                    res += "10";
                    break;
            case 11:
                    res += "11";
                    break;
            case 12:
                    res += "12";
                    break;
            default: throw new NotImplementedException();
            }
            
            return res;
        }
    }
}
